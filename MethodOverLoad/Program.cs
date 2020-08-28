using System;

namespace MethodOverLoad
{
    class Program
    {
       public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isDollars)
        {
            var sum = num1 + num2;

            if (isDollars == true && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isDollars == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (isDollars == true && sum < 1)
            {
                return $"{sum} dollars";

            }
            else
            {
                return sum.ToString();
            }

        }
        public  static void Main(string[] args)
        {
            
            var x = 16;
            var y = 33;

            var answer = Add(x, y);

            var a = 43.0m;
            var b = 55.0m;

            var decimalAnswer = Add(a, b);
            var thirdAnswer = Add(x, y, true);

            Console.WriteLine($"int add: {answer} decimal add : {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
           
       

        }
        
       



    }
}
