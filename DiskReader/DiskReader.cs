/**********
 * CLASS NAME : DiskReader Reader 
 * 
 * 
 * 
 * 
 *********/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiskForensics.IReader;
using System.IO;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
namespace DiskForensic
{
    public class DiskReader : IReader
    {

        private UInt64 f_fileCount;
        private UInt64 f_FolderCount;
        private ArrayList f_objArraylist;


        public UInt64 fileCount
        {
            get { return f_fileCount; }
            set { f_fileCount = value; }
        }


        public UInt64 folderCount
        {
            get { return f_FolderCount; }
            set { f_FolderCount = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>

        public event EventHandler<DiskForensics.FileFoundEventArgs> FileFound;


        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<DiskForensics.FolderFoundEventArgs> FolderFound;



        public DiskReader()
        {
            f_objArraylist = new ArrayList();
        }


        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="f_FilePath"></param>
        /// <returns></returns>
        public bool Scan(string f_folderPath)
        {
            String METHOD_NAME = @"Scan";
            try
            {

                DateTime f_objStartTime = DateTime.Now;
                
                ScanFolderRecursively(f_folderPath);
                Console.WriteLine("File Count = " + fileCount);
                Console.WriteLine("Folder Count = " + folderCount);


                Console.WriteLine(f_objStartTime);
                Console.WriteLine(DateTime.Now);


                Console.ReadLine();
            }
            catch (Exception Ex)
            {}
            finally
            {}
            return true;
        }




        private void ScanFolderRecursively(string f_folderPath)
        {
            String METHOD_NAME = "ScanFolderRecursively";
            try
            {

                folderCount++; 
                if (!Directory.Exists(f_folderPath))
                {
                    return;
                }

                //FOLDER FOUND EVEMT 

                if (FolderFound != null)
                    FolderFound(this, new DiskForensics.FolderFoundEventArgs(f_folderPath,f_folderPath));

                //LETS CALL THIS ON THREAD

                //Thread f_objFileProcessor = new Thread(processDirecoryForFilesWithThread);
                //f_objFileProcessor.Start(f_folderPath);

                Task f_objTask = Task.Factory.StartNew(processDirecoryForFiles(f_folderPath));

                f_objArraylist.Add(f_objTask);
                

                //processDirecoryForFiles(f_folderPath);

               
                string[] f_subDirectories = Directory.GetDirectories(f_folderPath);

                foreach (string f_strsubDir in f_subDirectories)
                {
                    ScanFolderRecursively(f_strsubDir);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }





        public void processDirecoryForFilesWithThread(object f_objDirPath)
        {
            String f_DirPath = (String)f_objDirPath;

            try
            {
                if (String.IsNullOrEmpty(f_DirPath))
                    return;

                if (!Directory.Exists(f_DirPath))
                    return;

                String[] f_objFileArray = Directory.GetFiles(f_DirPath);

                if (f_objFileArray != null)
                {
                    foreach (String file in f_objFileArray)
                    {
                        fileCount++;

                        FileInfo f_objFileInfo = new FileInfo(file);
                        Console.WriteLine(f_objFileInfo.FullName);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return;
        }






        public void TaskDone()
        {
            try
            {
                f_objArraylist.Remove(f_objArraylist.Capacity);
            }
            catch (Exception Ex)
            { 
              
            }
        }





        public Action processDirecoryForFiles(object f_objDirPath)
        {
            String f_DirPath = (String)f_objDirPath;
            
            try
            {
                if (String.IsNullOrEmpty(f_DirPath))
                    return new Action(TaskDone);

                if (!Directory.Exists(f_DirPath))
                    return new Action(TaskDone);

                String[] f_objFileArray = Directory.GetFiles(f_DirPath);

                if (f_objFileArray != null)
                {
                    foreach (String file in f_objFileArray)
                    {

                        //FILE FOUND EVENT ARGS

                        fileCount++;

                        FileInfo f_objFileInfo = new FileInfo(file);

                        if (FileFound != null)
                        {
                            FileFound(this, new DiskForensics.FileFoundEventArgs(new DiskForensics.FileInfoHolder(f_objFileInfo.Name,
                                                                                                                 f_objFileInfo.Extension,
                                                                                                                 f_objFileInfo.FullName,
                                                                                                                 f_objFileInfo.DirectoryName,
                                                                                                                 f_objFileInfo.CreationTime,
                                                                                                                 f_objFileInfo.LastAccessTime,
                                                                                                                 f_objFileInfo.Length.ToString()),@"",0))
                           ;
                        }
                        Console.WriteLine(f_objFileInfo.FullName);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return new Action(TaskDone);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Scan()
        {
            Console.WriteLine("Inside Scan Method");
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="f_DriveName"></param>
        /// <returns></returns>
        public bool ScanDrive(string f_DriveName)
        {
            throw new NotImplementedException();
        }

        public void test()
        {
            Console.Write("Hemant");
        }
    }
}
