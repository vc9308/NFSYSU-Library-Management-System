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
    public class User2Admin
    {
        public User2Admin(string id)
        {
            string tempId = String.Empty;
            string tempPsw = String.Empty;
            string tempFullName = String.Empty;

            string strSQL = String.Format("select * from Users where UserId = {0}", id);
            SqlCommand cmd = new SqlCommand(strSQL, Connection.cn);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    tempId = (string)dr["UserId"];
                    tempPsw = (string)dr["UserPsw"];
                    tempFullName = (string)dr["FullName"];
                }
                else
                {
                    MessageBox.Show("通过您输入的ID搜索不到任何用户");
                    return;
                }
            }

            string strRemove = String.Format("delete from Users where UserId = {0}", id);
            SqlCommand cmdRemove = new SqlCommand(strRemove, Connection.cn);

            string strInsert = String.Format("insert into Admins (AdminId, AdminPsw, FullName) " + 
                "values ('{0}', '{1}', '{2}');",
                tempId, tempPsw, tempFullName);
            SqlCommand cmdInsert = new SqlCommand(strInsert, Connection.cn);

            SqlTransaction tx = null;
            try
            {
                tx = Connection.cn.BeginTransaction();

                cmdRemove.Transaction = tx;
                cmdInsert.Transaction = tx;

                cmdRemove.ExecuteNonQuery();
                cmdInsert.ExecuteNonQuery();

                tx.Commit();
                MessageBox.Show("已升级为管理员账户");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tx.Rollback();
            }
        }
    }
}
