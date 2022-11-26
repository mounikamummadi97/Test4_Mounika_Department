using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Mounika_Department
{
    internal class DBConnection:DepartmentList
    {
        string connetionString = "";
        SqlCommand cmd;
        SqlConnection SqlCon;
        string query = "";
        public  void Method1()
        {
            //connetionString = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;";
            //query = "Insert into Department Values()";
            //SqlCon.Open();
            //SqlCon.Close();
            DepartmentList departmentListobj = new DepartmentList();
            var departmentList = departmentListobj.Method();

            SqlConnection connectionstring = new SqlConnection("Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;");
            string query = "Insert Into Department (DeptName, DeptShortName) " +
                               "VALUES (@DN, @SN) ";
            foreach (var dept in departmentList)
            {
                
                    // add parameters and their values
                    cmd=new SqlCommand(query, connectionstring);
                    cmd.Parameters.Add("@DN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptName;
                    cmd.Parameters.Add("@SN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptShortName;

                    connectionstring.Open();
                    cmd.ExecuteNonQuery();
                    connectionstring.Close();
                
            }
        }
    }
}
