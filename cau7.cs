using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        int choice;
        do
        {
            Console.WriteLine("Chọn tính năng:");
            Console.WriteLine("1. Tính tổng hai số nguyên không dấu");
            Console.WriteLine("2. Tính diện tích và chu vi hình chữ nhật (int)");
            Console.WriteLine("3. Kiểm tra số chẵn/lẻ (int)");
            Console.WriteLine("4. Tính tổng hai số nguyên có dấu (sbyte)");
            Console.WriteLine("5. Tính tổng số từ 1 đến n (uint)");
            Console.WriteLine("6. Tính diện tích và chu vi hình chữ nhật (double)");
            Console.WriteLine("7. Tìm số lớn nhất trong 3 số nguyên");
            Console.WriteLine("8. Tính giai thừa của một số nguyên không âm");
            Console.WriteLine("9. Kiểm tra số nguyên tố");
            Console.WriteLine("10. Kiểm tra số hoàn hảo");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SumTwoUnsignedInts();
                    break;
                case 2:
                    RectangleAreaPerimeter_int();
                    break;
                case 3:
                    CheckEvenOdd();
                    break;
                case 4:
                    SumTwoSignedBytes();
                    break;
                case 5:
                    SumFromOneToN();
                    break;
                case 6:
                    RectangleAreaPerimeter_double();
                    break;
                case 7:
                    FindMaxOfThree();
                    break;
                case 8:
                    Factorial();
                    break;
                case 9:
                    CheckPrime();
                    break;
                case 10:
                    CheckPerfectNumber();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void SumTwoUnsignedInts()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số thứ nhất: ");
        uint num1 = uint.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        uint num2 = uint.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng của {num1} và {num2} là: {num1 + num2}");
    }

    static void RectangleAreaPerimeter_int()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập chiều dài: ");
        ushort length = ushort.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        ushort width = ushort.Parse(Console.ReadLine());
        Console.WriteLine($"Diện tích hình chữ nhật là: {length * width}");
        Console.WriteLine($"Chu vi hình chữ nhật là: {2 * (length + width)}");
    }

    static void CheckEvenOdd()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số: ");
        uint num = uint.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine($"{num} là số chẵn.");
        else
            Console.WriteLine($"{num} là số lẻ.");
    }

    static void SumTwoSignedBytes()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số thứ nhất: ");
        sbyte num1 = sbyte.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        sbyte num2 = sbyte.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng của {num1} và {num2} là: {num1 + num2}");
    }

    static void SumFromOneToN()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số n: ");
        uint n = uint.Parse(Console.ReadLine());
        uint sum = (n * (n + 1)) / 2;
        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
    }

    static void RectangleAreaPerimeter_double()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập chiều dài: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine($"Diện tích hình chữ nhật là: {length * width}");
        Console.WriteLine($"Chu vi hình chữ nhật là: {2 * (length + width)}");
    }

    static void FindMaxOfThree()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());
        int max = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
    }

    static void Factorial()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số n: ");
        uint n = uint.Parse(Console.ReadLine());
        uint factorial = 1;
        for (uint i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Giai thừa của {n} là: {factorial}");
    }

    static void CheckPrime()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 2)
        {
            Console.WriteLine($"{num} không phải là số nguyên tố.");
            return;
        }
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine($"{num} là số nguyên tố.");
        else
            Console.WriteLine($"{num} không phải là số nguyên tố.");
    }

    static void CheckPerfectNumber()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        if (sum == num)
            Console.WriteLine($"{num} là số hoàn hảo.");
        else
            Console.WriteLine($"{num} không phải là số hoàn hảo.");
    }
}