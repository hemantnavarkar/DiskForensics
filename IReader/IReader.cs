using System;
using System.Collections.Generic;
using System.Text;



namespace DiskForensics.IReader
{
    public interface IReader
    {
        #region METHODS
        bool Scan();
        bool Scan(String f_FilePath);
        bool ScanDrive(String f_DriveName);


        event EventHandler<FileFoundEventArgs> FileFound;
        event EventHandler<FolderFoundEventArgs> FolderFound;
        #endregion
    }
}
