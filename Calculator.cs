using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLog
{
    internal class Calculator
    {
      public  LogWatch logWatch=new LogWatch();   
        public int add(int a, int b) 
        {
            int c = a + b;
            logWatch.logInfo(@$"user intput {a} and {b} output : {c}");

            return c;
        }
        public int sub(int a, int b)
        {
            int c = a-b;
            logWatch.logInfo(@$"user intput {a} and {b} output : {c}");

            return c;
        }
        public int mult(int a, int b)
        {
            int c = a*b;
            logWatch.logInfo(@$"user intput {a} and {b} output : {c}");

            return c;
        }
        public string div(int a, int b)
        {
            if(a == 0) 
            {
                logWatch.logWarn("user enterd 0 as first value");
                Console.WriteLine("0/n is not possible");
                logWatch.logInfo("user get output :0/n is not possible ");
               
                return "0/n is not possible";
            }
            else 
            {
                int c = a / b;
                logWatch.logInfo(@$"user intput {a} and {b} output : {c}");

                return $"{c}";
            }

         
        }
       
    }
}
