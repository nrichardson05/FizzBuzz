using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int number)
        {

            if (IsDivisibleby3(number) && IsDivisibleby5(number))
            {
                return "FizzBuzz";
            }else if (IsDivisibleby5(number))
            {
                return "Buzz";
            }else if (IsDivisibleby3(number))
            {
                return "Fizz";
            }
            
             
           return number.ToString();
        }

        private bool IsDivisibleby3(int number){
            return number % 3 ==0;
        }
        
        private bool IsDivisibleby5(int number){
            return number % 5 ==0;
        }
    }
}