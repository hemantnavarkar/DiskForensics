using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
//using System.Data.ADO;



namespace TestDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
           CreateConnection();
           // CreateMSAccessDB();
        }

        //Creatting new MSAccess DB and Using It


       







        public static bool CreateConnection()
        {
            try
            {
                using (SqlConnection objSqlCon = new SqlConnection(@"Data Source=HEMANT-PC;Initial Catalog=EyeForensic;Integrated Security=True"))
                {
                    objSqlCon.Open();
                    try 
                    {
                      using (SqlCommand command  = new SqlCommand("Select* From EyeForensic.dbo.TBL_INVESTIGATOR_DETAILS",objSqlCon))
                      {
                         SqlDataReader objDataReader = command.ExecuteReader();
                      }
                    }
                    catch(Exception Ex)
                    {
                    }
                }
            }
            catch (Exception Ex)
            {
                return false;
            }
            return true;
        }
    }
}
