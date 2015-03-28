using System;
using System.Collections.Generic;
using System.Text;
using DiskForensics;

namespace DiskForensics.IFactory
{
    public interface IFactory
    {   
       object GetReaderProduct(Readers objReaderType);
       object GetWriterProduct(Writer objWriter);
    }
}