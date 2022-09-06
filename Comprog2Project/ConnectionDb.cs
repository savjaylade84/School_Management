using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Comprog2Project
{
   public class ConnectionDb
    {
        public static SqlConnection Connection = new SqlConnection();
        public static SqlCommand Command = new SqlCommand();
        public static SqlDataAdapter Adapter = new SqlDataAdapter();
        public static DataSet dataSet = new DataSet();
        public static SqlCommandBuilder builder = new SqlCommandBuilder();
        public static string QueryCommand;

        //--------------------------------------------------------------------------------------

         /// <summary>
         /// this method insert data to the student table
         /// </summary>
         /// <param name="student">get the information in the student object</param>
        public static void EnterStudent(IStudent student){

            QueryCommand = "EXEC AddStudent  @ID = @id,@FNAME = @fname,@MNAME = @mname,@LNAME = @lname,@EMAIL = @email,@CONTACT = @contact,@PROFILE_PIC = profile_pic";

            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection)) {

                Connection.Open();
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@id",student.StudenID);
                Command.Parameters.AddWithValue("@fname", student.FirstName);
                Command.Parameters.AddWithValue("@mname", student.MiddleName);
                Command.Parameters.AddWithValue("@lname", student.LastName);
                Command.Parameters.AddWithValue("@email", student.Email);
                Command.Parameters.AddWithValue("@contact", student.Contact);
                Command.Parameters.AddWithValue("@profile_pic", student.ProfilePic);
                Command.ExecuteNonQuery();

                Connection.Close();
            
            }
        
        }

        public static void EnterTeacher(ITeacher teacher)
        {

            QueryCommand = "EXEC AddTeacher @ID = @id,@FNAME = @fname,@MNAME = @mname,@LNAME = @lname,@EMAIL = @email,@CONTACT = @contact,@UNAME = @uname,@PWORD = @pword,@PROFILE_PIC = profile_pic";

            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            {

                Connection.Open();
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@id", teacher.ProfessorID);
                Command.Parameters.AddWithValue("@fname", teacher.FirstName);
                Command.Parameters.AddWithValue("@mname", teacher.MiddleName);
                Command.Parameters.AddWithValue("@lname", teacher.LastName);
                Command.Parameters.AddWithValue("@email", teacher.Email);
                Command.Parameters.AddWithValue("@contact", teacher.Contact);
                Command.Parameters.AddWithValue("@uname", teacher.username);
                Command.Parameters.AddWithValue("@pword", teacher.Password);
                Command.Parameters.AddWithValue("@profile_pic", teacher.ProfilePic);
                Command.ExecuteNonQuery();

                Connection.Close();

            }

        }

        //------------------------------------------------------------------------------------------

        /// <summary>
        /// show the record in specific
        /// </summary>
        /// <param name="ViewRecordName">name of the view in the database</param>
        /// <param name="dataGridView">data gride view that will insert the data in the view</param>
        public static void ViewRecord(string ViewRecordName,DataGridView dataGridView) {

            QueryCommand = "SELECT * FROM " + ViewRecordName;
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();

                if (Connection.State != ConnectionState.Connecting)
                { 

                 Adapter.SelectCommand = Command;
                Adapter.Fill(dataSet);
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = dataSet.Tables[0];
                }
                Connection.Close();



            }

        }

        //-----------------------------------------------------------------------------------------

            /// <summary>
            /// return the count of specific column in the specific table
            /// </summary>
            /// <param name="Column">column name in the table</param>
            /// <param name="table">table name</param>
            /// <returns>string version of the count of specific column</returns>
        public static string getCount(string Column , string table) {


            QueryCommand = $@"SELECT COUNT({Column}) AS TotalCount From {table}";
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dataSet);
                Connection.Close();
                return dataSet.Tables[0].Rows[0][0].ToString();
                

            }

        }

        //------------------------------------------------------------------------------------------

        /// <summary>
        /// return the value in a specific column in the table
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="table">table name</param>
        /// <returns></returns>
        public static string getValue(string column, string table)
        {

            QueryCommand = $@"SELECT {column} AS TotalCount From {table}";
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();
                if (Connection.State != ConnectionState.Connecting)
                {
                    Adapter.SelectCommand = Command;
                    Adapter.Fill(dataSet);
                    Connection.Close();
                }
                return dataSet.Tables[0].Rows[0][0].ToString();


            }


        }

        public static bool getCompareValue(string column,string column2, string table,string compare,string compare2)
        {

            QueryCommand = $@"SELECT COUNT({column})AS TotalCount,COUNT({column2}) AS TotalCount2 From {table} WHERE {column} = '{compare}' AND {column2} = '{compare2}'";
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();
                if (Connection.State != ConnectionState.Connecting)
                {

                        Adapter.SelectCommand = Command;
                    try {
                        
                        Adapter.Fill(dataSet);
                        if ((Convert.ToInt32(dataSet.Tables[0].Rows[0][0].ToString()) >= 0) && (Convert.ToInt32(dataSet.Tables[0].Rows[0][1].ToString()) >= 0))
                            return true;

                    } catch {

                        return false;
                    }
       
                    Connection.Close();
                }



                return  false;


            }


        }

        public static string getValueWithUsername(string column, string table, string username) {

            QueryCommand = $@"SELECT {column} AS TotalCount From {table} WHERE username = '{username}'";
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();
                if (Connection.State != ConnectionState.Connecting)
                {
                    Adapter.SelectCommand = Command;
                    Adapter.Fill(dataSet);
                    Connection.Close();
                }
                return dataSet.Tables[0].Rows[0][0].ToString();


            }

        }

        public static void getValueInAdmin(Control[] control,string table) {

            QueryCommand = $@"SELECT * FROM {table}";
            using (Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (Command = new SqlCommand(QueryCommand, Connection))
            using (Adapter = new SqlDataAdapter())
            {

                Connection.Open();
                builder = new SqlCommandBuilder(Adapter);
                dataSet = new DataSet();
                if (Connection.State != ConnectionState.Connecting)
                {
                    Adapter.SelectCommand = Command;
                    Adapter.Fill(dataSet);
                }

                Connection.Close();

                        control[0].Text = dataSet.Tables[0].Rows[0][0].ToString();
                        control[1].Text = dataSet.Tables[0].Rows[0][1].ToString();
                        control[2].Text = dataSet.Tables[0].Rows[0][2].ToString();
                        control[3].Text = dataSet.Tables[0].Rows[0][3].ToString();

                         if(control.Length == 5)
                        control[4].Text = dataSet.Tables[0].Rows[0][4].ToString();

            }

        }

       

  

    }
}
