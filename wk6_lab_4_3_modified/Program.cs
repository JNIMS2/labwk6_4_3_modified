using System;

namespace wk6_lab_4_3_modified
{



    public class Program
    {
        /* i need to:
         * 1st make a method to FIND prime numbers
         * 2nd make a method to find the Nth prime
         * 
         * 
         * 
         * 
         */
        //*******************testing jazz  //else***********************
        //{
        //    return false;
        //}
        //var limit = Math.Ceiling(Math.Sqrt(num));
        //while (true)
        //{
        //    for (int i = 2; i <=limit; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //}

        //********i also know this goes a sep class. but, i wanted to get it working first. it did not...
        public static bool IsPrime(int num)
        {
            //special situation for 1 and 0...
            if (num <=1)
            {
                if (num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


            for (int i = 3; (i * i) <= num; i += 2)
            {
                if ((num % 1) == 0)
                {
                    return false;
                }
            }
            return num != 1;

        }



        //it keeps making everything true
        //1 makes it a forever loop
        //got out of the forever loop. now i get 13 passed. but not all prime or not....idk what is happening..



        static void Main(string[] args)
        {

        }

    }
}