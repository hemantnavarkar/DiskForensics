using System;
using System.Collections.Generic;

using System.Text;
using DiskForensics.DBObjects;


namespace DiskForensics.QueryBuilder
{
    public class QueryBuilderEngine
    {
        public QueryBuilderEngine()
        {}




        public String PrepareQuery(object objDBObject)
        {
            String strQuery = null ;
            if (objDBObject.GetType().Equals(typeof(DBObjects.TBL_CASE_DETAILS)))
            { 
                DBObjects.TBL_CASE_DETAILS objCaseDetails = (DBObjects.TBL_CASE_DETAILS)objDBObject;

                strQuery = "Insert Into " + objCaseDetails.p_STR_TBL_CASE_DETAILS + " Values("
                            +"'" + objCaseDetails.p_CASE_NAME + "',"
                            + "'" + objCaseDetails.p_CASE_DESCRIPTION + "',"+ "'" +objCaseDetails.p_CASE_CREATED_ON
                            +"',"+ objCaseDetails.p_CASE_INVESTIGATOR_ID + ");";
            }
            return strQuery;
        }



    }
}
