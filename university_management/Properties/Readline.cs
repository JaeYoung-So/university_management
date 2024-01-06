using System;
namespace university_management.Properties
{
    class Readline //입력예외함수
    {

        public Readline() { }
        public string readline(string str, string string1)
        {
            while (true)
            {
                try
                {
                    str = Console.ReadLine();
                    return str;
                }
                catch
                {
                    Console.WriteLine("잘못 입력하셨습니다 다시 입력해주세요");
                    Console.Write(string1);
                    continue;
                }
            }
        }
        public int readline(int num, string string1)
        {
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Console.WriteLine("잘못 입력하셨습니다 다시 입력해주세요");
                    Console.Write(string1);
                    continue;
                }
            }
        }
        public double readline(double num, string string1)
        {
            while (true)
            {
                try
                {
                    num = double.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Console.WriteLine("잘못 입력하셨습니다 다시 입력해주세요");
                    Console.Write(string1);
                    continue;
                }
            }
        }
    }
}
