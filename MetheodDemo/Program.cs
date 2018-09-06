using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetheodDemo
{
    class Program
    {

        static double GetRectangleArea(ref double width, ref double height)
        {
            double area = width * height;
            width = width * 2;
            return area;
        }


        static double GetRectangleArea(int width, int height)
        {
            double area = width * height;
            return area;
        }

        static int SumArray(int[] data2)
        {
            data2 = new int[10];
            data2[0] = 123455;

            return 0;
        }
    
        static void MockString(ref string aString)
        {
            // aString[0] = 'f'; --- Does not work. Strings are immutable.
            Console.WriteLine(aString);
            aString = "Test";
            Console.WriteLine(aString);

        }


        static void Main(string[] args)
        {   
            //Reference Type Demo
            int[] data = new[] { 1, 2, 3 };
            SumArray(data);

            // String (Reference Type Demo
            string str1 = "Fredrik";
            MockString(ref str1);

            double width;
            double height;
            bool ok;

            GetDoubleValue("Width? ", out width);
            GetDoubleValue("Height? ", out height);

            Console.WriteLine(GetRectangleArea(ref width, ref height));
            Console.WriteLine(GetRectangleArea(ref width, ref height));

        }

        private static void GetDoubleValue(string prompt, out double value)
        {
            bool ok;
            Console.Write(prompt);
            do
            {
                string text = Console.ReadLine();
                ok = double.TryParse(text, out value);

            } while (!ok);
        }
    }
}
