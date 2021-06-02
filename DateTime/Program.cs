using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*
            DateTime dt = DateTime.Now; // Or whatever
            string s = dt.ToString("yyyyMMddHHmmss");
            Console.WriteLine(dt);
            */
            DateTime d = DateTime.Now;
string dateString = d.ToString("yyyyMMddHHmmss");

        }
    }
}
