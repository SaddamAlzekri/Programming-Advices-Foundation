using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.GlobalClasses
{
    public class clsUtilityOfCopyTheImagePath
    {
        public static string CreatedGUID()
        {
            Guid newGuid = new Guid();

            return newGuid.ToString();
        }

        public static string ReplaceTheFileNameByGUID(string SourseFile)
        {
            string fileName = SourseFile;
            FileInfo FileInfo = new FileInfo(fileName);
            string exten = FileInfo.Extension;
            return CreatedGUID() + exten;

        }

        public static bool CreatePrjectFolderIfDoesnotFound(string DestinationFolder)
        {
            if(!Directory.Exists(DestinationFolder))
            {

                try
                {
                    Directory.CreateDirectory(DestinationFolder);
                    return true;
                }catch(IOException ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool CopyTheImageToProjectFolder(ref string SourseFile)
        {
            string DestinationFolder = @"C:\DVLD-People-Images\";
            if (!CreatePrjectFolderIfDoesnotFound(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceTheFileNameByGUID(SourseFile);

            return true;
        }

    }
}
