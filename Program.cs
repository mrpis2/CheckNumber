using System;
class Program
{
    private static void Main(string[] args)
    {
        uint number;
        Console.WriteLine("Nhap so tu ban phim");
        number = uint.Parse(Console.ReadLine());

        if (number < 2)
        {
            Console.WriteLine(number + " Khong phai so nguyen to");
        }
        else
        {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
            {
                Console.WriteLine(number + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(number + " khong phai la so nguyen to");
            }
        }
        
    }
}



