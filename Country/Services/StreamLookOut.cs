using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Country.Services
{
    class StreamLookOut
    {
        internal List<string> ReadText(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path).ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
