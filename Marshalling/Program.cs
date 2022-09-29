using System.Runtime.InteropServices;

namespace Marshalling
{
    public class Program
    {
        public struct MyStruct
        {
            public int a, b;
        }

        public const string DllPath = @"..\..\..\..\x64\Debug\CppDll.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Substract(int a, int b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int StructAdd(MyStruct myStr);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int StructSubstract(MyStruct myStr);

        static void Main()
        {
            int input1, input2;
            
            Console.Write("Введите первое число: ");

            if (!int.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Неверный ввод. Значение установлено на 10");
                input1 = 10;
            }

            Console.Write("Введите второе число: ");

            if (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Неверный ввод. Значение установлено на 7");
                input2 = 7;
            }

            MyStruct ms = new();
            ms.a = input1;
            ms.b = input2;

            int output1 = Add(input1, input2);
            int output2 = Substract(input1, input2);
            int output3 = StructAdd(ms);
            int output4 = StructSubstract(ms);


            Console.WriteLine($"Вывод суммы и разности для обычных методов: {output1}, {output2}" + "\n" 
                + $"Вывод суммы и разности для структур: {output3}, {output4}");

            Console.ReadLine();
        }
    }
}