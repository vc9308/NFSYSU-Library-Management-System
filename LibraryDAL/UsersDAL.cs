using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDAL
{
    public class UsersDAL
    {
        public static void Del(string id)
        {
            bool hasFound = false;
            try
            {
                string strSQL = "select * from Users where UserId = @UserId";
                SqlCommand cmd = new SqlCommand(strSQL, Connection.cn);

                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Char;
                param.Size = 7;
                param.ParameterName = "@UserId";
                param.Value = id;

                cmd.Parameters.Add(param);
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("找不到相关用户");
                    dr.Close();
                    hasFound = false;
                }
                else
                {
                    hasFound = true;
                    dr.Close();
                }
                if (hasFound)
                {
                    strSQL = "delete from Users where UserId = @UserId";
                    using (cmd = new SqlCommand(strSQL, Connection.cn))
                    {
                        param = new SqlParameter();
                        param.SqlDbType = SqlDbType.Char;
                        param.Size = 7;
                        param.ParameterName = "@UserId";
                        param.Value = id;

                        cmd.Parameters.Add(param);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Create(string id, string psw, string fName)
        {
            string strSQL = "Select * from Users where UserId = @UserId";
            using (SqlCommand cmd = new SqlCommand(strSQL, Connection.cn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@UserId";
                param.SqlDbType = SqlDbType.NChar;
                param.Size = 7;
                param.Value = id;
                cmd.Parameters.Add(param);
                SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("用户名已存在，请换另一个用户名");

            }
            else
            {

            }
                strSQL = "insert into Users values (@UserId, @UserPassword, @FullName)";
                using (SqlCommand cmdDel = new SqlCommand(strSQL, Connection.cn))
                {
                    param = new SqlParameter();
                    param.ParameterName = "@UserId";
                    param.SqlDbType = SqlDbType.NChar;
                    param.Size = 7;
                    param.Value = id;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@UserPassword";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 50;
                    param.Value = psw;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@FullName";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 50;
                    param.Value = fName;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
