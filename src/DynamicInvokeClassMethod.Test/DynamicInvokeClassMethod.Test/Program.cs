using DynamicInvokeMethod;
using System;

namespace DynamicInvokeClassMethod.Test
{
    internal class Program
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            //FirstClass f = new FirstClass();
            //f.Invoke("Apply", null);
            //Console.ReadLine();
            //适用的方法
            string result = TypeUitity.InvokeMethod("TestLib", "TestLib", "FirstClass", "Apply");
            Console.WriteLine(result);
            //result = TypeUitity.InvokeMethod("JinYinMao.Test.Invoke", "JinYinMao.Test.Invoke", "SecondClass", "Apply");
            //Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}