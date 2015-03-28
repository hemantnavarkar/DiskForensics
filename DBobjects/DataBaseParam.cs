using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiskForensics.DBObjects
{
    public class DataBaseParam
    {
        /// <summary>
        /// 
        /// </summary>
        public DataBaseParam(String p_strDBConnectionSring,
                              String p_strDbName,
                              bool p_iSWindOwAuthentication,
                              String p_strUserName,
                              String p_StrPassword) 
        {
            strDBConnectionString       = p_strDBConnectionSring;
            strDBName                   = p_strDBName;
            isWindowAuhentication       = p_iSWindOwAuthentication;
            strUserName                 = p_strUserName;
            strUserPassword               = p_StrPassword;
        }

        /// <summary>
        /// LOCAL MEMERS
        /// </summary>

        private String strDBConnectionString;
        private String strDBName;
        private bool   isWindowAuhentication;
        private String strUserName;
        private String strUserPassword;


        /// <summary>
        /// PROPERTIES
        /// </summary>
        /// 

        public String p_strDBConnectionString
        {
            get { return strDBConnectionString; }
            set { strDBConnectionString = value; }
        }

        public String p_strDBName
        {
            get { return strDBName; }
            set { strDBName = value; }
        }

        public  bool p_isWindowAuhentication
        {
            get { return isWindowAuhentication; }
            set { isWindowAuhentication = value; }
        }

        public String p_strUserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public String p_strUserPassword
        {
            get { return strUserPassword; }
            set { strUserPassword = value; }
        }
    }
}
