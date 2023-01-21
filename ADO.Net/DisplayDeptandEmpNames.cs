using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseApp
{
    class Assignment3
    {
       const string strConnection = "Data Source=192.168.171.36;Initial Catalog=3320;Integrated Security=True";
      const  string query = "select Deptname,EmpName from tblEmployee tblDept where tblemployee.deptId=tbldept.deptId ";

        private static void DisplayRecords()
        {
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var data = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(data);
                foreach (DataRow item in table.Rows)
                {
                    Console.WriteLine($"EmpName: {item["EmpName"]} DeptName:{item["DeptName"]}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            DisplayRecords();
        }
    }
}
