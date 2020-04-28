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
            var name = "이" + "의" + "진";
            Console.Write("Hello C#");
            int add = 2;
            int alpha;
            /*
             여
             러
             줄
             주
             석
             */
            Console.WriteLine("Hello world");
            Console.Write("Hello~~");

            Console.Write(5 + 2 + 3);
            Console.WriteLine(7 % 2);
            Console.WriteLine("A");
            Console.WriteLine('a');
            Console.WriteLine("살짝\n졸린데?");
            Console.WriteLine("살짝\t졸린데?");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("살짝"+"졸린데?");

            Console.WriteLine("살짝"[1000]); //문법적 오류x

            Console.WriteLine(true);




        }
    }
}
