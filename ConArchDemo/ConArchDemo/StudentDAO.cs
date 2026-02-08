using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For Ado.Net
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace ConArchDemo
{
    /// <summary>
    /// Demo code for connected Architecture in StudentDAO class
    /// </summary>
    public class StudentDAO
    {

        //type of connection
        //connected -> ccd -> connection, command, datareader
        //disconnected -> cdd -> connection, data adaptor, dataset

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress03;Integrated Security=SSPI;Database=TopBrains";
        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList = new List<Student>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from Employees";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Holding Data via Reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();

                myDt.Load(sdr);
                if (myDt != null)
                {
                    //Convert Table into List
                    foreach (DataRow drow in myDt.Rows)
                    {
                        Student sObj = new Student()
                        {
                            RollNo = Convert.ToInt32(drow[0].ToString()),
                            Name = drow[1].ToString(),
                            Address = drow[3].ToString(),
                            PhoneNo = "0000000000",
                        };

                        if (sObj != null)
                        {
                            studList.Add(sObj);
                        }
                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            //Code for Connected Architecture

            return studList;
        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList = new List<Student>();

            SqlParameter param1 = new SqlParameter("@Name", name);

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from Employees where Name = @Name";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Param is to be added to Command
                cmd.Parameters.Add(param1);

                //Holding Data via Reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();

                myDt.Load(sdr);
                if (myDt != null)
                {
                    //Convert Table into List
                    foreach (DataRow drow in myDt.Rows)
                    {
                        Student sObj = new Student()
                        {
                            RollNo = Convert.ToInt32(drow[0].ToString()),
                            Name = drow[1].ToString(),
                            Address = drow[3].ToString(),
                            PhoneNo = "0000000000",
                        };

                        if (sObj != null)
                        {
                            studList.Add(sObj);
                        }
                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            //Code for Connected Architecture

            return studList;
        }

        public Student SearchByRollNo(string name)
        {
            Student tempObj = null;

            return tempObj;
        }

        public bool AddStudent(Student student)
        {
            bool flag = false;
            con.Open();
            SqlParameter[] param = new SqlParameter[2];
            for(int i = 0;i<param.Length;i++)
            {
                param[i] = new SqlParameter();
            }
            param[0].ParameterName = "@RollNo";
            param[0].Value = student.RollNo;

            param[1].ParameterName = "@Name";
            param[1].Value = student.Name;

            param[2].ParameterName = "@Dept";
            param[2].Value = student.Address;

            cmd = new SqlCommand();
            cmd.CommandText = "Insert into Employees(ID, Name, Dept) values(@RollNo, @Name, @Dept)";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(param);
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
