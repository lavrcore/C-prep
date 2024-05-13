using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C_prep
{
    internal class Program
    {
        //public class Fraction
        //{
        //    private int _denominator;
        //    public int Numerator { get; set; }
        //    public int Denominator
        //    {
        //        get { return _denominator; }
        //        set
        //        {
        //            try
        //            {
        //                if (value != 0)
        //                {
        //                    _denominator = value;
        //                }
        //                else
        //                {
        //                    throw new DivideByZeroException();
        //                }
        //            }
        //            catch (DivideByZeroException ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }
        //    public Fraction(int num, int den)
        //    {
        //        Numerator = num;
        //        Denominator = den;
        //    }
        //    public static Fraction Divide(Fraction frac1, Fraction frac2)
        //    {
        //        int numerator = frac1.Numerator * frac2.Denominator;
        //        int denominator = frac1.Denominator * frac2.Numerator;
        //        Fraction result = new Fraction(numerator, denominator);
        //        return result;
        //    }
        //    static void Main(string[] args)
        //    {
        //        Fraction fraction1 = new Fraction(3,4);
        //        Fraction fraction2 = new Fraction(5,6);

        //        Fraction result = Fraction.Divide(fraction1, fraction2);
        //        Console.WriteLine($"Числитель новой дроби { result.Numerator}");
        //        Console.WriteLine($"Знаменатель новой дроби {result.Denominator}");

        //        Fraction result2 = Fraction.Divide(fraction1, fraction2);
        //        Console.WriteLine($"Числитель новой дроби {result.Numerator}");
        //        Console.WriteLine($"Знаменатель новой дроби {result.Denominator}");
        //    }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("На вашем счету: ");
            account.AddMoney(10000);
            Console.WriteLine(account.Money);
            Console.WriteLine("Вы сняли:" + -2000);
            account.GiveMoney(-2000);
            Console.WriteLine("Остаток: " + account.Money);
        }

            public class BankAccount
        {
            public double Money { get; set; }

            public int Code { get; set; }

            public string NumberOfCard { get; set; }

            public string NameAccount { get; set; }

            public void AddMoney(double money)
            {
                try
                {
                    if (money < 0)
                    {
                        throw new ArgumentException("Попытка зачислить отрицательную сумму");
                    }
                    else
                    {
                        Money += money;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Сумма {money}");
                }

            }
            public void GiveMoney(double money)
            {
                try
                {
                    if (money < 0)
                    {
                        throw new ArgumentException("Попытка снять отрицательную сумму.");
                    }
                    else if(Money < 0)
                    {
                        throw new ArgumentException("Недостаточно средств.");
                    }
                    else
                    {
                        Money -= money;
                    }
                }
                catch (ArgumentException ex)
                {
                    double result = Money - money;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Сумма {money}");
                 


                }
                

            }
        }
    }
}
