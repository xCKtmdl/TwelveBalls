using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveBalls
{
    class Program
    {


        static void Finish(String a, bool b)
        {
            Console.WriteLine("Fake is: " + a + " , boolFakeLighter is: " + b);
        }

        // 12 is lighter

        static int getWeight(String input)
        {
            if (input == "12")
                return 0;
            else
                return 1;
        }
        // ^^ function for getting weight of a ball

        // function for getting weight of a group of the balls
        static int getWeightOfArry(String[] input)
        {
            int returnSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                returnSum = returnSum + getWeight(input[i]);
            }
            return returnSum;
        }



        static String Weigh(String[] a, String[] b)
        {

            if (getWeightOfArry(a) == getWeightOfArry(b))
                return "BALANCE";
            if (getWeightOfArry(a) > getWeightOfArry(b))
                return "LEFT";
            if (getWeightOfArry(a) < getWeightOfArry(b))
                return "RIGHT";
            return "Weigh Error";

        }


        static void Main(string[] args)
        {

            String fake = "";
            bool boolFakeLighter = true;
            String[] stringArry = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            String[] group1 = { stringArry[0], stringArry[1], stringArry[2], stringArry[3] };

            String[] group2 = { stringArry[4], stringArry[5], stringArry[6], stringArry[7] };

            String[] group3 = { stringArry[8], stringArry[9], stringArry[10], stringArry[11] };



            String comparison1 = Weigh(group1, group2);

            if (comparison1 == "LEFT")
            {
                /* Either one of 1,2,3,4 is heavier, or one of 5,6,7,8 is lighter */
                /* 9,10,11,12 ARE NOT FAKE  */

                String[] group6 = { stringArry[0], stringArry[1], stringArry[4] };
                String[] group7 = { stringArry[2], stringArry[5], stringArry[8] };

                // Compare 1,2,5  with 3,6,9
                String comparison3 = Weigh(group6, group7);
                // 9 is surely not fake
                if (comparison3 == "BALANCE")
                {
                    /* If they balance then either 4 is heavy or 7 is light or 8 is light */
                    if (getWeight(stringArry[6]) == getWeight(stringArry[7]))
                    {
                        fake = stringArry[3];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    if (getWeight(stringArry[6]) < getWeight(stringArry[7]))
                    {
                        fake = stringArry[6];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[7];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }

                }

                //if 1,2,5 is heavier
                if (comparison3 == "LEFT")
                {
                    /* Either 1 is heavy or 2 is heavy or 6 is light */
                    if (getWeight(stringArry[0]) == getWeight(stringArry[1]))
                    {
                        fake = stringArry[5];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    if (getWeight(stringArry[0]) > getWeight(stringArry[1]))
                    {
                        fake = stringArry[0];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[1];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }


                }



                //if 3,6,9 is heavier
                if (comparison3 == "RIGHT")
                {
                    /* Either 3 is heavy or 5 is light */
                    if (getWeight(stringArry[4]) < getWeight(stringArry[8]))
                    {
                        fake = stringArry[4];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[2];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }


                }

            }

























            if (comparison1 == "RIGHT")
            {
                /* Either one of 1,2,3,4 is lighter, or one of 5,6,7,8 is heavier */
                /* 9,10,11,12 ARE NOT FAKE  */

                String[] group6 = { stringArry[4], stringArry[5], stringArry[0] };
                String[] group7 = { stringArry[6], stringArry[1], stringArry[8] };

                // Compare 5,6,1 with 7,2,9
                String comparison3 = Weigh(group6, group7);
                // 9 is surely not fake
                if (comparison3 == "BALANCE")
                {
                    /* If they balance then either 8 is heavy or 3 is light or 4 is light */
                    if (getWeight(stringArry[2]) == getWeight(stringArry[3]))
                    {
                        fake = stringArry[7];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    if (getWeight(stringArry[2]) < getWeight(stringArry[3]))
                    {
                        fake = stringArry[2];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[3];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }

                }

                //if 5,6,1 is heavier
                if (comparison3 == "LEFT")
                {
                    /* Either 5 is heavy or 6 is heavy or 2 is light */
                    if (getWeight(stringArry[4]) == getWeight(stringArry[5]))
                    {
                        fake = stringArry[1];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    if (getWeight(stringArry[4]) > getWeight(stringArry[5]))
                    {
                        fake = stringArry[4];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[5];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                }




                //if 7,2,9 is heavier
                if (comparison3 == "RIGHT")
                {
                    /* 9 is not fake */
                    /* Either 7 is heavy or 1 is light */
                    if (getWeight(stringArry[0]) == getWeight(stringArry[8]))
                    {
                        fake = stringArry[6];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[0];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }


                }





            }












            if (comparison1 == "BALANCE")
            {
                /* "9","10","11", or "12" is fake */

                // weigh 8,9 and 10,11
                String[] group4 = { stringArry[7], stringArry[8] };
                String[] group5 = { stringArry[9], stringArry[10] };
                String comparison2 = Weigh(group4, group5);



                /* comparison2 code */
                /* *********************** */
                // surely 8 is not the fake
                // if they are equal, 12 is the fake
                if (comparison2 == "BALANCE")
                {
                    fake = stringArry[11];

                    boolFakeLighter = false;
                    if (getWeight(fake) < getWeight(stringArry[10]))
                    {
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                }


                // If 8,9 is heavier
                if (comparison2 == "LEFT")
                {
                    /*  either 9 is heavy or 10 is light or 11 is light  */


                    if (getWeight(stringArry[9]) == getWeight(stringArry[10]))
                    {
                        fake = stringArry[8];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }

                    if (getWeight(stringArry[9]) < getWeight(stringArry[10]))
                    {
                        fake = stringArry[9];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[10];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }


                }


                // if 8,9 is lighter
                if (comparison2 == "RIGHT")
                {

                    // remember, 8 is NOT fake
                    // so either 9 is lighter or 10 is heavier or 11 is heavier


                    if (getWeight(stringArry[9]) == getWeight(stringArry[10]))
                    {
                        fake = stringArry[8];
                        boolFakeLighter = true;
                        Finish(fake, boolFakeLighter);
                    }

                    if (getWeight(stringArry[9]) > getWeight(stringArry[10]))
                    {
                        fake = stringArry[9];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }
                    else
                    {
                        fake = stringArry[10];
                        boolFakeLighter = false;
                        Finish(fake, boolFakeLighter);
                    }



                }

                /* *********************** */
                /* comparison2 code */
















            }









        }
    }
}
