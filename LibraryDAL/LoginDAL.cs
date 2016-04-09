using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryDAL
{
    public class LoginDAL
    {
        public void Login4User(string id, string psw, ref bool access)
        {
            try
            {
                string strSQL = "select * from Users where UserId = @UserId and UserPsw = @UserPsw";
                using (SqlCommand cmd = new SqlCommand(strSQL, Connection.cn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@UserId";
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 7;
                    param.Value = id;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@UserPsw";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 50;
                    param.Value = psw;
                    cmd.Parameters.Add(param);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome Users!");
                        access = true;
                    }
                    else
                    {
                        access = false;
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Login4Admin(string id, string psw, ref bool access)
        {
            try
            {
                string strSQL = "select * from Admins where AdminId = @AdminId and AdminPsw = @AdminPsw";
                using (SqlCommand cmd = new SqlCommand(strSQL, Connection.cn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@AdminId";
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 7;
                    param.Value = id;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@AdminPsw";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 50;
                    param.Value = psw;
                    cmd.Parameters.Add(param);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome Boss!");
                        access = true;
                    }
                    else
                    {
                        access = false;
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
