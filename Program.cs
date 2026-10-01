using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập tham số a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Giá trị a không hợp lệ!");
            return;
        }

        Console.Write("Nhập tham số b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Giá trị b không hợp lệ!");
            return;
        }

        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình có vô số nghiệm");
            else
                Console.WriteLine("Phương trình vô nghiệm");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Phương trình có nghiệm x = " + x);
        }
    }
}
