using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*int num = 7;
            switch(num)
            {
                case 1:
                    Console.WriteLine("nej b");
                    break;

                case 7:
                    Console.WriteLine("nej bror");
                    break;

                case 8:
                    Console.WriteLine("yes my guy!!");
                    break;
            }*/

            var str = Console.ReadLine();
            double num = Convert.ToDouble(str);

            Console.WriteLine(num);
        }
    }
}
    