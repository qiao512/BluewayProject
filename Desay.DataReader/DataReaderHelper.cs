using Desay.DataManager;
using EZ.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desay.DataReader
{
    public static class DataReaderHelper
    {
        public static string GetDataUniqueId(string path, string machineName, string dataName, bool isForBack=false)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            string folder = info.Parent.Name;
            string id = string.Empty;
            if (isForBack==false)
            {
                id = string.Format("{0}{1}{2}TEMP", folder, machineName, dataName);
            }
            else
            {
                id = string.Format("{0}{1}{2}{3}", folder, machineName, dataName, info.CreationTime.Ticks);
            }
            return id.ToMD5();
        }

        public static string GetDataName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public static FLEXSA_DATA_TYPE JudgeFlexaDataFileType(string fileName)
        {
            string fname = Path.GetFileName(fileName).ToUpper();
            string[] flexsaDataTypes = Enum.GetNames(typeof(FLEXSA_DATA_TYPE));
            foreach (string dtype in flexsaDataTypes)
            {
                if (fname.StartsWith(dtype))
                {
                    return (FLEXSA_DATA_TYPE)Enum.Parse(typeof(FLEXSA_DATA_TYPE), dtype);
                }
            }

            return FLEXSA_DATA_TYPE.NOT_SUPPORTED;

        }

        public static bool IsValidFlexaDataFile(string fileName)
        {
            string fname = Path.GetFileNameWithoutExtension(fileName).ToUpper();
            string[] flexsaDataTypes = Enum.GetNames(typeof(FLEXSA_DATA_TYPE));
            foreach (string dtype in flexsaDataTypes)
            {
                if (fname.StartsWith(fname))
                    return true;
            }
            return false;
        }
    }
}
