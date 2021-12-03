using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class FileService
    {
        public IEnumerable<string> ReadFile(string filePath)
        {
            var text = System.IO.File.ReadAllLines(filePath);
            var uncommentedRows = text.Where(row => row.Contains("//") == false);

            return uncommentedRows;
        }
    }
}