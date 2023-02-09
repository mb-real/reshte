using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reshte
{
    internal class kalamebekalame
    {
        public kalamebekalame()
        {

            //string s = Console.ReadLine();
            //string[] p = Console.ReadLine().Split(',');
            //Console.WriteLine(p[1]);
            int sum = 0;
            string str = Console.ReadLine();
            foreach (var item in str)
            {

                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    sum++;
                }
            }

            Console.WriteLine(Math.Pow(2, sum));

            Console.ReadKey();

        }

        ~kalamebekalame()
        {

        }
    }
}

