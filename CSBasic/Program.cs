using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //273;
            var name = "김" + "수" + "경";
            Console.Write("Hello C# ");
            int add = 2;
            int Alpha;
            //주석
            /*
             * 여러줄주석
             */

            Console.WriteLine("Hello World ");
            Console.Write("HEllo World ");
            Console.Write("HEllo World ");

            Console.Write(52);
            Console.WriteLine(7 % 3);
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");

            Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
            Console.WriteLine(true);
        }
    }
}
