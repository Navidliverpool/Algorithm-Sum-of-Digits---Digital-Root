using System;

namespace Sum_of_Digits___Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInstance = new Number();
            Console.WriteLine(numberInstance.DigitalRoot(942));
        }
    }

    public class Number
    {
        public int DigitalRoot(long n)
        {
            var inputToString = n.ToString();
            var splitedInpt = inputToString.ToCharArray();
            var sum = 0;
            var inputToInt = 0;
            foreach (var item in splitedInpt)
            {
                inputToInt = int.Parse(item.ToString());
                sum += inputToInt;
            }

            var readyForResult = sum.ToString();
            var readyForResult2 = 0;
            var finalResult = 0;
            foreach(var item2 in readyForResult)
            {
                readyForResult2 = int.Parse(item2.ToString());
                finalResult += readyForResult2;
            }

            return finalResult;
        }
    }
}
