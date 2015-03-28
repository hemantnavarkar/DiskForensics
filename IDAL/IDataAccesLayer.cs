using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskForensics
{
    public interface IDataAccesLayer
    {  
        int Insert(object objInserObject);
        int Delete(Object objDeleteObject);
    }
}
