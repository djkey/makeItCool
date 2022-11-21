using System;

namespace ConsoleApp2
{
    class Program
    {
        static string makeitCool(string line)
        {
            line = line.Replace("A", "@");
            line = line.Replace("a", "@");
            line = line.Replace("I", "1");
            line = line.Replace("i", "1");
            line = line.Replace("S", "$");
            line = line.Replace("s", "$");
            line = line.Replace("O", "0");
            line = line.Replace("o", "0");
            line = line.Replace("T", "+");
            line = line.Replace("t", "+");
            return line;
        }
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Введите строку: ");
            line = Console.ReadLine();
            
            Console.WriteLine("Твоя крутая строка: " + makeitCool(line));
        }
    }
}
