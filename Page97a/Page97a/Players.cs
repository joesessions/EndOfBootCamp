using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page97a
{
    public class Players
    {
        const string notApplicable = "N/A";
        public Players(string name) : this(name, notApplicable)
        {

        }
        public Players(string name, string shoeSize)
        {
            string Name = name;
            string ShoeSize = shoeSize;
            Console.WriteLine(ShoeSize);
        }
        



    }
}
