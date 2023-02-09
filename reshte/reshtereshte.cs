using System;

namespace reshte
{
    internal class reshtereshte
    {
        public static void quer()
        {

            string[] s = Console.ReadLine().Split();


            int o = Convert.ToInt32(s[0]);
            int o1 = Convert.ToInt32(s[1]);

            string[] n = new string[o];
            string[] k = new string[o1];

            for (int i = 0; i <= o - 1; i++)
            {
                n[i] = Console.ReadLine();
            }


            for (int ii = 0; ii <= o1 - 1; ii++)
            {
                k[ii] = Console.ReadLine();
            }

            /// this loop for word count in n or k ///
            for (int a = 0; a <= o; a++)
            {
                /// this loop for limit Range number of letters in a word n ///
                for (int r = 0; r <= n[a].Length; r++)
                {
                    int sum = 0;

                    /// Condition one ///
                    if ((n[a].Length - k[r].Length) <= 1 && (n[a].Length - k[r].Length) >= -1)
                    {

                        int iii = 0;
                        int p = 0;


                        for (int i = 0; i < 50; i++)
                        {
                            for (int ii = 0; ii < n[a].Length; ii++)
                            {
                                for (; iii < k[r].Length; iii++)
                                {
                                    if (n[a][ii] == k[r][iii])
                                    {
                                        //Console.WriteLine("barabr");
                                        iii++;
                                        break;
                                    }
                                    else
                                    {
                                        //Console.WriteLine("na ----- barabr");
                                        iii++;
                                        p++;
                                        break;
                                    }
                                }
                            }
                            break;
                        }

                        if (p >= 2)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            sum++;
                            Console.WriteLine(1);
                        }

                    }
                    else
                    {
                        Console.WriteLine(0);
                        //break;
                    }


                    /// Condition two ///
                    if (n[a].Length == k[r].Length)
                    {
                        int iii = 0;
                        int p = 0;


                        for (int i = 0; i < 50; i++)
                        {
                            for (int ii = 0; ii < n[a].Length; ii++)
                            {
                                for (; iii < k[r].Length; iii++)
                                {
                                    if (n[a][ii] == k[r][iii])
                                    {
                                        //Console.WriteLine("barabr");
                                        iii++;
                                        break;
                                    }
                                    else
                                    {
                                        //Console.WriteLine("na ----- barabr");
                                        iii++;
                                        p++;
                                        break;
                                    }
                                }
                            }
                            break;
                        }

                        if (p >= 1)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            sum++;
                            Console.WriteLine(1);
                        }

                    }
                    else
                    {
                        Console.WriteLine(0);
                        //break;
                    }





                }
            }



        }
    }
}
