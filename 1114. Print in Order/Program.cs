using System;

namespace _1114._Print_in_Order
{
    class Program
    {
        private static int currentMethodNumber = 1;

        static void Main()
        {
            
        }

        public static void First(Action printFirst)
        {
            currentMethodNumber++;
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
        }

        public static void Second(Action printSecond)
        {
            WaitFor(2);
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            currentMethodNumber++;
        }

        public static void Third(Action printThird)
        {
            WaitFor(3);
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }

        private static void WaitFor(int number)
        {
            while (currentMethodNumber != number) { }
        }
    }
}