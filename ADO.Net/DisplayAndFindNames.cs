using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.Common;

namespace Consoleee
{
      internal class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }

            public string empAddress { get; set; }

            public int empSalary { get; set; }
        }
        
        class DataComponent
        {
            const string strConnection = "Data Source=MALLIKARJUN\\SQLEXPRESS;Initial Catalog=3320;Integrated Security=True";
           static SqlDataAdapter ada = null;
           static DataSet realObj = new DataSet("allRecords");
           private static void fillRecords()
            {
                 SqlConnection con = new SqlConnection(strConnection);
                 string Query = "select * from tblEmployee";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(realObj);
                SqlCommandBuilder Builder = new SqlCommandBuilder(ada);
                realObj.Tables[0].TableName = "EmpData";
               

            }
            //Assignment5
            private static List<Employee> DisplayData()
            {
                fillRecords();
                List<Employee> list = new List<Employee>();
                foreach (DataRow row in realObj.Tables[0].Rows)
                {
                    Employee employee = new Employee
                    {
                        EmpId = (int)row[0],
                        EmpName = (string)row[1],
                        empAddress= (string)row[2],
                        empSalary= (int)row[3]

                    };
                    list.Add(employee);
                }

                return list;
            }
            //Assignment6
            private static List<Employee> FindByName(string name)
            {
                fillRecords();
                List<Employee> list = new List<Employee>();
                foreach (DataRow row in realObj.Tables[0].Rows)
                {
                    if (name == row[1].ToString())
                    {
                        Employee emp = new Employee
                        {
                            EmpId= (int)row[0],
                            EmpName = (string)row[1],
                            empAddress= (string)row[2],
                            empSalary = (int)row[3]
                        };
                        list.Add(emp);
                    }

                }
                return list;
            }
            static void Main(string[] args)
            {
                var data=FindByName("Luca Jeandeau");
                foreach (var item in data)
                {
                    Console.WriteLine(item.EmpId+" "+item.EmpName+" "+item.empAddress+""+item.empSalary);
                }
            }
        }
          
    }
