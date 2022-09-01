using System;
using System.Globalization;
using System.Linq;

namespace Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool variableBool = true;
            Console.WriteLine(variableBool);
            byte variableByte = 255;
            Console.WriteLine(variableByte);
            sbyte variableSbyte = -128;
            Console.WriteLine(variableSbyte);
            char variableChar = 'f';
            Console.WriteLine(variableChar);
            decimal variableDecimal = 0.00000000001m;
            Console.WriteLine(variableDecimal);
            double variableDouble = 121245.023195242;
            Console.WriteLine(variableDouble);
            float variableFloat = 1302.1252453245f;
            Console.WriteLine(variableFloat);
            int variableInt = 124;
            Console.WriteLine(variableInt);
            uint variableUint = 4294967295u;
            Console.WriteLine(variableUint);
            long variableLong = -1242346253453242314;
            Console.WriteLine(variableLong);
            ulong variableUlong = 12412352346345753566;
            Console.WriteLine(variableUlong);
            short variableShort = 12235;
            Console.WriteLine(variableShort);
            ushort variableUshort = 12234;
            Console.WriteLine(variableUshort);
            
            Console.ReadLine();
            Console.Clear();

            int converted = 0;
            bool convertion = Convert.ToBoolean(converted);
            Console.WriteLine(convertion);
            Console.WriteLine(Convert.ToString(converted));
            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            int var1, var2 = 5, result;
            int.TryParse(str, out var1);
            result = var1 + var2;
            Console.WriteLine(result);

            int first = 123;
            double second = first;
            double third = (double)first;

            Console.ReadLine();
            Console.Clear();

            int v = 12;
            object o = v;
            int v1 = (int)o;
            var sadf = 123;
            //sadf = "safd";
            Console.WriteLine(sadf.GetType());
            int? nullable = null;
            Console.WriteLine(nullable);
        }
    }
}
