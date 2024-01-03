using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneApp
{
    public class DataAccess
    {
        /// <summary>
        /// This is the Data Access tier.  It is responsible for all
        /// file input and output operations.  The other tiers need
        /// not be concerned with whether the data is in a text file,
        /// a database, or some other format.
        /// </summary>
        private static StreamReader sr = null;
        private static StreamWriter sw = null;

        public static string FileFilter
        {
            get { return "Text File (*.txt)|*.txt"; }
        }

        public static void InitializeRead(string fileName)
        {
            sr = new StreamReader(fileName);
        }

        public static Phone ReadPhone()
        {
            // Return the next Phone object, or null at end-of-file
            string name, phone;
            if (sr == null)
                throw new ApplicationException("Input file not open");
            name = sr.ReadLine();
            if (name == null)
                return null;
            phone = sr.ReadLine();
            return new Phone(name, phone);
        }

        public static void FinishRead()
        {
            sr.Close();
        }

        public static void InitializeWrite(string fileName)
        {
            sw = new StreamWriter(fileName);
        }

        public static void WritePhone(Phone ph)
        {
            if (sw == null)
                throw new ApplicationException("Output file not open");
            sw.WriteLine(ph.Name);
            sw.WriteLine(ph.PhoneNumber);
        }

        public static void FinishWrite()
        {
            sw.Close();
        }
    }
}
