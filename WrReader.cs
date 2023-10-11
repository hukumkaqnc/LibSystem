using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibSystem
{
    internal class WrReader
    {
        public string[] LocalArr = { };
        string path = "note1.txt";
        public WrReader(string val) {
            path = val;
                    
        }
        public void FileConverter()
        {
            string[] result = { };
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Append(line);
                }
            }
            LocalArr = result;
        }
        public void FileWriter() {

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string line in LocalArr)
                {
                    writer.WriteLineAsync(line);
                }
                
            }
        }
    }
}
