using System;

namespace EX1.b
{
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    class Complex
    {
       public double re;
       public double im;
       public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im - this.im;
            y.re = x.re - this.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im * this.im;
            y.re = x.re * this.re;
            return y;
        }
        public string Print() 
        {
            return re + "+(" + im + ")i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex();
            x.re = 1;
            x.im = 1;
            Complex y = new Complex();
            y.re = 2;
            y.im = 2;
            Complex result1 = y.Minus(x);
            Console.WriteLine(result1.Print());
            Complex result2 = y.Multi(x);
            Console.WriteLine(result2.Print());
            

        }
    }
}
