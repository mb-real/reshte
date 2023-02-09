using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace reshte
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //***    for sort code  Ctrl+K, Ctrl+E     ***//
            //***    for Comment   Ctrl + K + C     ***//
            //***    for Uncomment    Ctrl + K + C    ***//

            //kalamebekalame c = new kalamebekalame();
            //dastgahekhodpardaz c = new dastgahekhodpardaz();
            //reshtereshte.quer();
            //Test.app();

            List<string> cor = new List<string>();
            cor.Add("tehran: esfahan,mashhad,tabriz");
            cor.Add("esfahan: mashhad,yazd");
            cor.Add("mashhad: yazd,kerman");
            cor.Add("yazd: kerman,rasht");
            cor.Add("rasht: tehran,esfahan");

            Dictionary<int,string> mydic = new Dictionary<int,string>();
            mydic.Add(0,"ewre");
            mydic.Add(1, "ewre");
            mydic.Add(-1, "ewre");
            mydic.Add(3, "ewre");
            mydic.Add(5, "eghjmhmre");
            bool b = mydic.ContainsKey(1);

            foreach (var item in cor)
            {
                Console.WriteLine(item.Split(',')[1]);

            }


            Console.ReadLine();
        }


        static int fun (IEnumerable<char> input , HashSet<int> charTOMatch)
        {
            var map = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (charTOMatch.Contains(item))
                {
                    map.TryGetValue(item, out var i);
                    map[item] = i + 1;
                }
            }
            return map.Sum(kv => kv.Value);
        }

        static int Foo(int a, int b, params int[] reto)
        {
            // Return the sum of the integers in args, ignoring a and b.
            int sum = 0;
            foreach (int i in reto)
                sum += i;
            return sum;
        }

    }
}
