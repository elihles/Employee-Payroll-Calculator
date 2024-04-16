using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prac7_Methods
{
    internal class Program
    {
        const double Tax = 0.10;
        static void Main(string[] args)
        {
            string name;
            double hours, basePayRate, nettoWage, tax;
            GetUserInput(out  name, out hours, out basePayRate);
            Console.WriteLine();
            double Gross = GrossWage(hours, basePayRate);
            FinalAmountTax(out tax, out nettoWage,Gross);
            Display(name, hours, basePayRate,Gross,Tax,nettoWage);
        }
    
    
        private static void GetUserInput(out string name,out double hours, out double basePayRate)
        {
            Console.Write("Enter your Name :");
            name = Console.ReadLine();
            Console.Write("Enter the number of hours :");
            hours = double.Parse(Console.ReadLine());
            Console.Write("Enter the base pay rate :");
            basePayRate = double.Parse(Console.ReadLine());
            
        }
        private static double GrossWage(double hours, double basePayRate)
        {
            double Gross;
            if (hours <= 40)
            {
                Gross = hours * basePayRate;
            }
            else
            {
                double regularHoursPay = 40 * basePayRate;
                double overtimePay = (hours - 40) * 1.5 * basePayRate;
                Gross = regularHoursPay + overtimePay;
            }
            return Gross;
        }
        private static void FinalAmountTax(out  double tax, out double nettoWage,double Gross)
        {
           
            tax = Tax * Gross;
            nettoWage=Gross-tax;
        }
        private static void Display(string name,double hours,double basePayrate,double Gross,double tax,double nettowage)
        {
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine("Hours Worked :{0}", hours);
            Console.WriteLine("Base Pay Rate {0} ",basePayrate);
            Console.WriteLine("Gross Wage:{0}",Gross);
            Console.WriteLine("Tax      :{0}",tax);
            Console.WriteLine("Net Wage :{0}",nettowage);
            Console.WriteLine();
            Console.ReadLine();
        }
}
}
   
