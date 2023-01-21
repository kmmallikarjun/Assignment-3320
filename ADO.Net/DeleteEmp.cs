using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataBaseApp
{
    class Assign
    {
        public static void DeleteEmployee(int id)
        {
            string strConnection = "Data Source=192.168.171.36;Initial Catalog=3320;Integrated Security=True";
            string DeleteEmp = "delete tblemployee where empId=" + id;
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(DeleteEmp, con);
            try
            {
                con.Open();
                var data = cmd.ExecuteNonQuery();
                if (data > 0)
                {
                    Console.WriteLine("data deleted" + data);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        static void Main(string[] args)
        {

            DeleteEmployee(1001);
            Console.WriteLine("deleted");
        }
    }
  

}
