using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DiskForensics.DBObjects;
using DiskForensics.QueryBuilder;

namespace DiskForensics.DAL
{
    public class DataAccessLayer
    {
        private QueryBuilderEngine objQueryBuilderEngine = null;
        private DataBaseParam objDataBaseParam = null; 


        public DataAccessLayer(DataBaseParam p_objDataBaseParam)
        {
            objDataBaseParam        = p_objDataBaseParam;
            objQueryBuilderEngine   = new QueryBuilderEngine();
        }




        public int Delete(object objDeleteObject)
        {
            throw new NotImplementedException();
        }



         
        public int Insert(object objInserObject)
        {
            int retResult = 0;
            String strQuerryToExecute = String.Empty;

            if (objQueryBuilderEngine != null)
            {
                strQuerryToExecute = objQueryBuilderEngine.PrepareQuery(objInserObject);

                if (strQuerryToExecute != null)
                {
                    using (SqlConnection objSqlConnection = new SqlConnection(objDataBaseParam.p_strDBConnectionString))
                    {
                        objSqlConnection.Open();

                        SqlCommand objCommand = new SqlCommand(strQuerryToExecute,objSqlConnection);

                        retResult = objCommand.ExecuteNonQuery();
                    }
                }
            }
            return retResult;
        }




    }
}
