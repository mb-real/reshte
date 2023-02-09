/// https://quera.org/problemset/108667/ ///


using System;
using System.Collections;

namespace reshte
{
    internal class dastgahekhodpardaz
    {

        public dastgahekhodpardaz()
        {
            ArrayList amount = new ArrayList();
            ArrayList name = new ArrayList();

            int coin100 = 10;
            int coin50 = 10;
            int coin10 = 10;
            int coin5 = 10;
            int coin1 = 10;

            ///

            string[,] users = new string[200, 2];
            int index = -1;

            ///

            int loop = Convert.ToInt32(Console.ReadLine());
            string[] strloop = new string[loop];
            for (int i = 0; i < loop; i++)
            {
                strloop[i] = Console.ReadLine();
            }

            // for sort of timestampe
            //for (int i = 0; i < loop; i++)
            //{
            //    string[] time = strloop[i].Split();
            //    DateTime d1 = new DateTime(time[3]);
            //    DateTime d2 = new DateTime(time[3]);
            //    int res = DateTime.Compare(d1, d2);
            //}


            for (int i = 0; i < loop; i++)
            {
                string[] str = strloop[i].Split();

                switch (str[0])
                {
                    case "REGISTER":
                        if (!name.Contains(str[1]))
                        {
                            ///
                            index++;
                            users[index, 0] = str[1];
                            users[index, 1] = "100";
                            ///

                            name.Add(str[1]);
                            amount.Add(100);
                            Console.WriteLine("Registered Successfully");
                        }
                        else
                            Console.WriteLine("Duplicate User!");
                        break;

                    case "DEPOSIT":
                        if (Convert.ToInt32(str[2]) > 0)
                        {
                            if (name.Contains(str[1]))
                            {
                                ///
                                int t = name.IndexOf(str[1]);
                                users[t, 1] = Convert.ToString(Convert.ToInt32(users[t, 1]) + Convert.ToInt32(str[2]));
                                ///

                                amount[t] = Convert.ToInt32(str[2]) + Convert.ToInt32(amount[t]);
                                Console.WriteLine(amount[t]);
                            }
                            else
                                Console.WriteLine("No Such User Found!");
                        }
                        else
                            Console.WriteLine("Value Maines for DEPOSIT----- -----");
                        break;

                    case "WITHDRAW":
                        if (Convert.ToInt32(str[2]) > 0)
                        {
                            if (name.Contains(str[1]))
                            {
                                if (Convert.ToInt32(str[2]) <= 200)
                                {
                                    // name = "t" or "of" 
                                    int of = name.IndexOf(str[1]);
                                    if (!(Convert.ToInt32(amount[of]) - Convert.ToInt32(str[2]) <= 0))
                                    {

                                        int sum = 0;
                                        int vorvod = Convert.ToInt32(str[2]);

                                        if (vorvod < 1660)
                                        {
                                            for (int num = 1; num < coin100;)
                                            {
                                                sum = 100;
                                                if ((vorvod - sum) >= 0 && coin100 >= vorvod)
                                                {
                                                    coin100--;
                                                    vorvod = vorvod - sum;
                                                    amount[of] = Convert.ToInt32(amount[of]) - sum;
                                                    //Console.WriteLine(amount[of]);
                                                    continue;
                                                }
                                                break;
                                            }
                                            for (int num = 1; num < coin50;)
                                            {
                                                sum = 50;
                                                if ((vorvod - sum) >= 0 && coin50 >= vorvod)
                                                {
                                                    coin50--;
                                                    vorvod = vorvod - sum;
                                                    amount[of] = Convert.ToInt32(amount[of]) - sum;
                                                    //Console.WriteLine(amount[of]);
                                                    continue;
                                                }
                                                break;
                                            }
                                            for (int num = 1; num < coin10;)
                                            {
                                                sum = 10;
                                                if ((vorvod - sum) >= 0 && coin10 >= vorvod)
                                                {
                                                    coin10--;
                                                    vorvod = vorvod - sum;
                                                    amount[of] = Convert.ToInt32(amount[of]) - sum;
                                                    //Console.WriteLine(amount[of]);
                                                    continue;
                                                }
                                                break;
                                            }
                                            for (int num = 1; num < coin5;)
                                            {
                                                sum = 5;
                                                if ((vorvod - sum) >= 0 && coin5 >= vorvod)
                                                {
                                                    coin5--;
                                                    vorvod = vorvod - sum;
                                                    amount[of] = Convert.ToInt32(amount[of]) - sum;
                                                    //Console.WriteLine(amount[of]);
                                                    continue;
                                                }
                                                break;
                                            }
                                            for (int num = 1; num < coin1;)
                                            {
                                                sum = 1;
                                                if ((vorvod - sum) >= 0 && coin1 >= vorvod)
                                                {
                                                    coin1--;
                                                    vorvod = vorvod - sum;
                                                    amount[of] = Convert.ToInt32(amount[of]) - sum;
                                                    //Console.WriteLine(amount[of]);
                                                    continue;
                                                }
                                                break;
                                            }
                                            if (vorvod == 0)
                                            {
                                                Console.WriteLine(amount[of]);
                                                break;
                                            }
                                            else
                                                Console.WriteLine("Not Enough Banknotes!");
                                        }
                                        else
                                            Console.WriteLine("Not Enough Banknotes!");
                                    }
                                    else
                                        Console.WriteLine("Not Enough Fund!");
                                }
                                else
                                    Console.WriteLine("Maximum Amount Exceeded!");
                            }
                            else
                                Console.WriteLine("No Such User Found!");
                        }
                        else
                            Console.WriteLine("Value Maines for WITHDRAW----- -----");
                        break;

                    case "TRANSFER":
                        if (name.Contains(str[1]) && name.Contains(str[2]))
                        {
                            if (Convert.ToInt32(str[3]) < 3000)
                            {
                                int of = name.IndexOf(str[1]);
                                if (!(Convert.ToInt32(amount[of]) - Convert.ToInt32(str[3]) < 0))
                                {
                                    ///

                                    ///

                                    int adrss = name.IndexOf(str[2]);
                                    amount[adrss] = Convert.ToInt32(str[3]) + Convert.ToInt32(amount[adrss]);
                                    amount[of] = Convert.ToInt32(amount[of]) - Convert.ToInt32(str[3]);
                                    Console.WriteLine(amount[of]);
                                }
                                else
                                    Console.WriteLine("Not Enough Fund!");
                            }
                            else
                                Console.WriteLine("Maximum Amount Exceeded!");

                        }
                        else
                            Console.WriteLine("No Such User Found!");
                        break;


                    case "GET_BALANCE":
                        if (name.Contains(str[1]))
                        {
                            int of = name.IndexOf(str[1]);
                            if (!(Convert.ToInt32(amount[of]) < 10))
                            {
                                amount[of] = Convert.ToInt32(amount[of]) - 10;
                                Console.WriteLine(amount[of]);
                            }
                            else
                                Console.WriteLine("Not Enough Fund!");
                        }
                        else
                            Console.WriteLine("No Such User Found!");
                        break;

                    case "ADD_BANKNOTE":
                        if (str[1] == "100")
                        {
                            coin100 = coin100 + Convert.ToInt32(str[2]);
                            Console.WriteLine((coin100 * 100) + (coin50 * 50) + (coin10 * 10) + (coin5 * 5) + (coin1 * 1));
                        }
                        if (str[1] == "50")
                        {
                            coin50 = coin50 + Convert.ToInt32(str[2]);
                            Console.WriteLine((coin100 * 100) + (coin50 * 50) + (coin10 * 10) + (coin5 * 5) + (coin1 * 1));
                        }
                        if (str[1] == "10")
                        {
                            coin10 = coin10 + Convert.ToInt32(str[2]);
                            Console.WriteLine((coin100 * 100) + (coin50 * 50) + (coin10 * 10) + (coin5 * 5) + (coin1 * 1));
                        }
                        if (str[1] == "5")
                        {
                            coin5 = coin5 + Convert.ToInt32(str[2]);
                            Console.WriteLine((coin100 * 100) + (coin50 * 50) + (coin10 * 10) + (coin5 * 5) + (coin1 * 1));
                        }
                        if (str[1] == "1")
                        {
                            coin1 = coin1 + Convert.ToInt32(str[2]);
                            Console.WriteLine((coin100 * 100) + (coin50 * 50) + (coin10 * 10) + (coin5 * 5) + (coin1 * 1));
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        ~dastgahekhodpardaz()
        {

        }

    }
}
