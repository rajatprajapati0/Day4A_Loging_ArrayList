using DemoLog;
using System;

namespace Logging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogWatch logWatch = new LogWatch();
            logWatch.logDebug("************Start***********");

            Calculator calculator = new Calculator();
            Console.WriteLine("calculator");
            Console.WriteLine("Enter option \n'+'>Addition\n'-'Subtraction>\n'*'>multiplicaation\n'/'>division");
            string B = Console.ReadLine();
            char option = B[0];

            Console.WriteLine("enter first value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second value");
            int b = int.Parse(Console.ReadLine());


            switch (option)
            {

                case '+':
                    logWatch.logInfo("addition ");

                    Console.WriteLine(calculator.add(a, b));
                    logWatch.logDebug("opretion done");
                    break;
                case '-':
                    logWatch.logInfo("Subtraction");

                    Console.WriteLine(calculator.sub(a, b));
                    logWatch.logDebug("opretion done");

                    break;
                case '*':
                    logWatch.logInfo("multiplicaation");

                    Console.WriteLine(calculator.mult(a, b));
                    logWatch.logDebug("opretion done");

                    break;
                case '/':
                    logWatch.logInfo("division");
                    Console.WriteLine(calculator.div(a, b));
                    logWatch.logDebug("opretion done");

                    break;
                default:
                    logWatch.logWarn("wrong option");
                    Console.WriteLine("Enter right option");

                    break;

            }
            logWatch.logDebug("************Done***********\n");

        }
    }
}
