using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiskForensics.IFactory;
using System.Reflection;
using DiskForensics;

namespace Factory
{
    public class Factory :IFactory
    {
        String CLASS_NAME = "DiskForensics.IFactory";


        public Factory()
        { 
         
        }


        public object GetReaderProduct(DiskForensics.Readers objReaderType)
        {   
            String METHOD_NAME = "GetReaderProduct";
            Object f_objReaderObject = null;
            try
            {
                switch (objReaderType)
                { 
                   case DiskForensics.Readers.DiskReader:
                        f_objReaderObject = LoadReaderAssembly(@"X:\Binaries\DiskReader.dll");

                   break;
                   case DiskForensics.Readers.VHDReader:
                   break;
                }
            }
            catch (Exception Ex)
            {
            }
            finally
            {
                METHOD_NAME = null;
            }
            return f_objReaderObject;
        }


        public object GetWriterProduct(DiskForensics.Writer objWriter)
        {
            throw new NotImplementedException();
        }



        private object LoadReaderAssembly(String p_PathofAssembly)
        {
            object f_objReader = null;
            if (String.IsNullOrEmpty(p_PathofAssembly))
            {
                return null;
            }
            Assembly objAssembly = Assembly.LoadFrom(p_PathofAssembly);

            Type[] objTypeInfo = objAssembly.GetTypes();


            foreach (Type f_objType in objTypeInfo)
            {
                if (f_objType.Name.Equals(Common.DISK_READER_NAME))
                {
                    f_objReader = Activator.CreateInstance(f_objType);
                    break;
                }
            }
            return f_objReader;
        
        
        }

        

    }
}
