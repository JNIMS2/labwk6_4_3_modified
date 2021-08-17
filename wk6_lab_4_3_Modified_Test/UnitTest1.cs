using System;
using Xunit;
using wk6_lab_4_3_Modified_Test;

namespace wk6_lab_4_3_Modified_Test
{
    public class UnitTest1
    {
        /* test for prime numbers in a sequence
         * 1 is not considered prime. so it will require special conditions
         * N    Expected
         * 1    2
         * 2    3
         * 3    5
         * 4    7
         * 5    11
         * 6    13
         * 7    17
         * 8    19
         * 9    23
         * 10   29
         * 11   31
         * 12   37
         * 13   41
         * 14   43
         * 15   47
         * 16   53
         * 25   97
        
         */
        //[Theory]
        //[InlineData(1, 2)]
        //[InlineData(2,3)]
        //[InlineData(3,5)]
        //[InlineData(4, 7)]
        //[InlineData(5, 11)]
        //[InlineData(6, 13)]
        //[InlineData(7, 17)]
        //[InlineData(8, 19)]
        //[InlineData(9, 23)]
        //[InlineData(10, 29)]
        //[InlineData(11, 31)]
        //[InlineData(12, 37)]
        //[InlineData(13, 41)]
        //[InlineData(14, 43)]
        //[InlineData(15, 47)]
        //[InlineData(16, 53)]
        //[InlineData(25, 97)]

        //public void Test1()
        //{

        //}


        /* more sample tests to FIND the primes
         * do the data THEN the functions
         * prime numbers are only divisible by 1 AND themselves.
         * 
         */
         [Theory]
        [InlineData(1, false)]
        [InlineData(2,true)]
        [InlineData(3,true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(13, true)]
        [InlineData(14, false)]
        [InlineData(15, false)]
        [InlineData(16, false)]
        [InlineData(25, false)]
        [InlineData(47, true)]
        [InlineData(100, false)]
         public void TestIsPrime(int num, bool expected)
        {
            bool primecheck = wk6_lab_4_3_modified.Program.IsPrime(num);
            Assert.Equal(expected, primecheck); //it won't call my program here and idk why
        }

        //first test failed half cuz no parameters
        //i can't get past 13 or 14 passed...
    }
}
