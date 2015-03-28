using System;
using System.Collections.Generic;
using System.Text;

namespace DiskForensics.DBObjects
{
    public class TBL_CASE_DETAILS
    {

        /// <summary>
        /// 
        /// </summary>
        public TBL_CASE_DETAILS()
        {
        }

        /// <summary>
        /// LOCAL DATA MEMBERS
        /// </summary>




        private UInt16 CASE_ID;
        private String   CASE_NAME;
        private String   CASE_DESCRIPTION;
        private DateTime CASE_CREATED_ON;
        private UInt16   CASE_INVESTIGATOR_ID;

        private static String STR_CASE_ID               = @"CASE_ID";
        private static String STR_CASE_NAME             = @"CASE_NAME";
        private static String STR_CASE_DESCRIPTION      = @"CASE_DESCRIPTION";
        private static String STR_CASE_CREATED_ON     = @"CASE_CREATED_ON";
        private static String STR_CASE_INVESTIGATOR_ID  = @"CASE_INVESTIGATOR_ID";
        private static String STR_TBL_CASE_DETAILS      = @"TBL_CASE_DETAILS";
        
        
        
        /// <summary>
        /// PROPERTIES
        /// </summary>

        public UInt16 p_CASE_ID
        {
            get { return CASE_ID; }
            set { CASE_ID = value; }
        }

        public String p_CASE_NAME
        {
            get { return CASE_NAME; }
            set { CASE_NAME = value; }
        }

        public String p_CASE_DESCRIPTION
        {
            get { return CASE_DESCRIPTION; }
            set { CASE_DESCRIPTION = value; }
        }

        public DateTime p_CASE_CREATED_ON
        {
            get { return CASE_CREATED_ON; }
            set { CASE_CREATED_ON = value; }
        }

        public UInt16 p_CASE_INVESTIGATOR_ID
        {
            get { return CASE_INVESTIGATOR_ID; }
            set { CASE_INVESTIGATOR_ID = value; }
        }

        public String p_STR_CASE_ID
        {
            get { return STR_CASE_ID; }
        }

        public String p_STR_CASE_NAME
        {
            get { return STR_CASE_NAME; }
        }

        public String p_STR_CASE_DESCRIPTION
        {
            get { return STR_CASE_DESCRIPTION; }
        }

        public String p_STR_CASE_CREATED_ON
        {
            get { return STR_CASE_CREATED_ON; }
        }

        public String p_STR_CASE_INVESTIGATOR_ID
        {
            get { return STR_CASE_INVESTIGATOR_ID; }
        }

        public String p_STR_TBL_CASE_DETAILS
        {
            get { return STR_TBL_CASE_DETAILS; }
        }




        /// <summary>
        /// METHODS
        /// </summary>

        public void GetXMLNode()
        { 
        
        }
        public void GetFilterArray()
        { 
        
        }
    }
}
