using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Page64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number please.");
            string numeroUno = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Joe\CSharpRepos-master\log3.txt", numeroUno);
            string fileback = File.ReadAllText(@"C:\Users\Joe\CSharpRepos-master\log3.txt");
            Console.WriteLine(fileback);
            Console.ReadLine();
        }
    }
}
