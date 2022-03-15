using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNet5
{
    internal class Services
    {
        public void Writer<T>(List<T> ar)
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
