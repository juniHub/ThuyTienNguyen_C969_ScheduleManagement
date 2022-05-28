using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ThuyTienNguyen_C969_ScheduleManagement.DBModel
{
    public class DBConnection
    {
        public static MySqlConnection conn { get;  set; }

        //start connection to database
        public static void startConnection()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["ScheduleManagement"].ConnectionString;

                conn = new MySqlConnection(connString);

                conn.Open();

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        //close connection from database
        public static void closeConnection()
        {  
            try { 
            
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
