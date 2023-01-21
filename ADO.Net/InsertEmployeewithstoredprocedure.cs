using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Consoleee
{
    class Assigment1
    {
        const string strConnection = "Data Source=MALLIKARJUN\\SQLEXPRESS;Initial Catalog=3320;Integrated Security=True";
        const string Insert = "insert into tblEmployee values(@empName,@empaddress,@empsalary,@deptId)";
        const string storedInsert = "InsertEmp1";

        //Assignment1
        public static void AddEmployee(string name, string address, int salary, int deptId)
        {
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@empname", name);
            cmd.Parameters.AddWithValue("@empaddress", address);
            cmd.Parameters.AddWithValue("@empSalary", salary);
            cmd.Parameters.AddWithValue("@deptId", deptId);

            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("data not inserted");
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
        //Assignment7
        public static void StoredProcInsert(string name, string address,  int deptId)
        {
            SqlConnection con = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(storedInsert, con);
            cmd.Parameters.AddWithValue("@empname", name);
            cmd.Parameters.AddWithValue("@empaddress", address);
            //cmd.Parameters.AddWithValue("@empSalary", salary);
            cmd.Parameters.AddWithValue("@deptId", deptId);

            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("data not inserted");
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
            string name = Utilities.prompt("Enter the Name");
            string address = Utilities.prompt("Enter the address");
            int Salary = Utilities.GetNumber("Enter the Salary");
            int DeptId = Utilities.GetNumber("Enter the deptId");
            AddEmployee(name,address, Salary, DeptId);
            StoredProcInsert(name, address,  DeptId);
            Console.WriteLine("added");
        }
    }
}
