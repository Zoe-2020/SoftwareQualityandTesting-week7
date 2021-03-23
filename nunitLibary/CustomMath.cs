using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nunitLibary
{
    public class CustomMath
    {

        public int multiply(int a, int b)
        {
            // throw new System.NotImplementedException();
            return a * b;
        }
        public bool divisible(long n , long x , long y)
        {
            if (n%x == 0 && n%y ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Q2Div(int weight1 , int weight2)
        {
           int evenNum = 2;
            if ( weight1 % evenNum == 0 && weight2 % evenNum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }

}
