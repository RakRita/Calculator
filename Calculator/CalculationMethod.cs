using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculationMethod
    {
        double nummer1 { get; set; }
        double nummer2 { get; set; }
        string counter { get; set; }

        double result;

        int test = 0;



        public CalculationMethod(double nummer1, double nummer2, string counter)
        {
            this.nummer1 = nummer1;
            this.nummer2 = nummer2;
            this.counter = counter;
        

            switch (counter)
            {
                case "+":
                    Add();
                    break;

                case "-":
                    Subtract();
                    break;
                case "/":
                    Divide();
                    break;
                case "*":
                    Multiply();
                    break;

            }
            Console.WriteLine("\n{0}\t{1}\t{2}\t= {3}", this.nummer1, this.counter, this.nummer2, result);
        }
        public double Add()
        {
            result = nummer1 + nummer2;
            return result;
        }

        public double Subtract()
        {
            result = nummer1 - nummer2;
            return result;
        }
        public double Multiply()
        {
            result = nummer1 * nummer2;
            return result;
        }
        public double Divide()
        {
            while (nummer1 == 0 || nummer2 == 0)
            {
                Console.WriteLine("Du försöker dividera med noll");

                if (nummer1 == 0)
                {
                    Console.WriteLine("Ange ett nytt första tal");
                    nummer1 = Convert.ToDouble(Console.ReadLine());
                }


                else if (nummer2 == 0)
                {
                    Console.WriteLine("Ange ett nytt andra tal");


                    nummer2 = Convert.ToDouble(Console.ReadLine());
                }


            }

            result = nummer1 / nummer2;


            return result;
        }


    }



}
