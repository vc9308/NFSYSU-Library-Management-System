using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryDAL
{
    public class Admin2User
    {
        public Admin2User(string id)
        {
            string tempId = String.Empty;
            string tempPsw = String.Empty;
            string tempFullName = String.Empty;

            string strSQL = String.Format("select * from Admins where AdminId = {0}", id);
            SqlCommand cmd = new SqlCommand(strSQL, Connection.cn);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    tempId = (string)dr["AdminId"];
                    tempPsw = (string)dr["AdminPsw"];
                    tempFullName = (string)dr["FullName"];
                }
                else
                {
                    MessageBox.Show("通过您输入的ID搜索不到任何用户");
                    return;
                }
            }

            string strRemove = String.Format("delete from Admins where AdminId = {0}", id);
            SqlCommand cmdRemove = new SqlCommand(strRemove, Connection.cn);

            string strInsert = String.Format("insert into Users (UserId, UserPsw, FullName) " +
                "values ('{0}', '{1}', '{2}');",
                tempId, tempPsw, tempFullName);
            SqlCommand cmdInsert = new SqlCommand(strInsert, Connection.cn);

            SqlTransaction tx = null;
            SqlTransaction tx2 = null;

            tx2 = Connection.cn.BeginTransaction();
            tx2.Commit();

            try
            {
                tx = Connection.cn.BeginTransaction();

                cmdRemove.Transaction = tx;
                cmdInsert.Transaction = tx;

                cmdRemove.ExecuteNonQuery();
                cmdInsert.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tx.Rollback();
            }
        }
    }
}
