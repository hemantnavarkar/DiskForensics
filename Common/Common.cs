using System;
using System.Collections.Generic;
using System.Text;

namespace DiskForensics
{

    //CLASS TO STORE CUSTOME EVEN ARGUMENTS



    public class ApplicationInput
    {

        public ApplicationInput()
        { 
         
        }

        private String strErrorLogPath;
        private String strDBPath;
        private String strDBConnectionPath;
        private String strAppConfigPath;
        private String strTempLocPath;
        private String DBUserName;
        private String DBPassword;



        public String p_strDBConnectionPath
        {
            get { return p_strDBConnectionPath; }
            set { strDBConnectionPath = p_strDBConnectionPath; }
        }

    }








    public class FileInfoHolder
    {
        public FileInfoHolder()
        { 
        
        }

        public FileInfoHolder(string p_fileName,
                              string p_fileExt,
                              string p_filePath,
                              string p_folderPath,
                              DateTime p_creationDateTime, 
                              DateTime p_lastModifiedDateime,
                              string p_fileSize)
        {
            fileName = p_fileName;
            fileExt  = p_fileExt;
            filePath = p_filePath;
            folderPath = p_folderPath;
            creationDate = p_creationDateTime;
            lastModifiedDate = p_lastModifiedDateime;
            fileSize = p_fileSize;
        }
        

        private String fileName;

        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private String fileExt;

        public String FileExt
        {
            get { return fileExt; }
            set { fileExt = value; }
        }
        private String filePath;

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private String folderPath;

        public String FolderPath
        {
            get { return folderPath; }
            set { folderPath = value; }
        }

        private DateTime creationDate;

        public DateTime CreationDate
        {
         get{return creationDate;}
            set{creationDate = value;}
        }

         private DateTime lastModifiedDate;

        public DateTime LastModifiedDate
        {
         get{return lastModifiedDate;}
            set{lastModifiedDate = value;}
        }

        private string fileSize;

        public string FileSize
        {
         get{return fileSize;}
            set{fileSize = value;}
        }
    }





    public class FileFoundEventArgs : EventArgs
    {
        private FileInfoHolder f_objFileInfoHolder;
        private String         f_ErrorMessage;
        private int            f_ErrorCode;


        public FileInfoHolder objFileInfoHolder
        {
            get { return f_objFileInfoHolder; }
        }

        public String ErrorMessage
        {
            get { return f_ErrorMessage; }
        }

        public int ErrorCode
        {
            get { return f_ErrorCode; }
        }



        public FileFoundEventArgs()
        {}
        public FileFoundEventArgs(FileInfoHolder p_objFileInfoHolder,String p_errorMes,int p_errorCode)
        {
            f_objFileInfoHolder = p_objFileInfoHolder;
            f_ErrorMessage = p_errorMes;
            f_ErrorCode = p_errorCode;
        }
    }


    public class FolderFoundEventArgs : EventArgs
    {
        public FolderFoundEventArgs(String p_folderName,String p_parentFolderName)
        {
            folderName              = p_folderName;
            parentFolderName        = p_folderName;
        }

        private String folderName;
        private String parentFolderName;
    }


    public enum Readers
    {
        DiskReader = 0,
        VHDReader = 1,
    }

    public enum Writer
    { 
      CSVWriter = 0
    }



    public static class Common
    {
        public const string DISK_READER_NAME    = "DiskReader";
        public const string VHD_READER_NAME     = "VHDreader";
        public const string PRODUCT_NAME        = "";
    }
}
