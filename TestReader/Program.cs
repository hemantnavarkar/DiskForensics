using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory;
using DiskForensics.IReader;
using DiskForensics;

using DiskForensics.DAL;
using DiskForensics.DBObjects;



namespace TestReader
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCaseRecordToDB();
            
            Factory.Factory f_objfactory    = new Factory.Factory();
            IReader objReader               =  (IReader)f_objfactory.GetReaderProduct(DiskForensics.Readers.DiskReader);
            objReader.FileFound              += new EventHandler<DiskForensics.FileFoundEventArgs>(objReader_FileFound);
            objReader.FolderFound += new EventHandler<DiskForensics.FolderFoundEventArgs>(objReader_FolderFound);
            objReader.Scan(@"C:\");
        }


        static void AddCaseRecordToDB()
        {
            for (int i = 0; i < 100; i++)
            {

                TBL_CASE_DETAILS objCaseDetails = new TBL_CASE_DETAILS();

                objCaseDetails.p_CASE_ID = 1;
                objCaseDetails.p_CASE_NAME = @"Hemant Test" + i;
                objCaseDetails.p_CASE_DESCRIPTION = @"This Is The Test Case" + i;
                objCaseDetails.p_CASE_INVESTIGATOR_ID = 10;
                objCaseDetails.p_CASE_CREATED_ON = DateTime.Now;

                DataAccessLayer objdataAccessLayer = new DataAccessLayer(new DataBaseParam(@"Data Source=HEMANT-PC;Initial Catalog=EyeForensic;Integrated Security=True", @"", false, @"", @""));
                objdataAccessLayer.Insert(objCaseDetails);
            }

        }
        
        
        static void objReader_FolderFound(object sender, DiskForensics.FolderFoundEventArgs e)
        {
            try
            {

            }
            catch (Exception Ex)
            { 
            
            }
        }

        
        
        
        
        static void objReader_FileFound(object sender, DiskForensics.FileFoundEventArgs e)
        {
            try
            {   
               //BUSINESS LOGIC GONNA HOOK DB HANDLER TO SAVE THE DATA TO DB AND 


            }
            catch (Exception Ex)
            { 
            
            }
        }
    }
}
