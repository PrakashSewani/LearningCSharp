using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class TestProgram
    {
        public static void Main(string[] args)
        {
            TestProgram tp = new TestProgram();
            Console.WriteLine(tp.EMICalculator(100000));
        }

        public double Discount(int principal)
        {
            double Discount=0;
            if (principal <= 1000)
            {
                Discount = 0;
                return principal - Discount;
            }
            else if (principal >1000 && principal <= 2000)
            {
                Discount = principal * 0.05;
                return principal - Discount;
            }
            else if (principal >2000 && principal <= 3000)
            {
                Discount = principal * 0.1;
                return principal - Discount;
            }
            else
            {
                Discount=principal*0.15;
                return principal - Discount;
            }
        }
        public double EMIFormula(double principal, double ROI)
        {
            ROI = ROI/12;
            //double EMI = principal * ROI * (Math.Pow((1 + ROI), 12) / Math.Pow((1 + ROI), 12) - 1);
            double num = Math.Pow(1 + ROI, 12);
            double frac = (num / (num - 1));
            double EMI = (principal * ROI * num)/(num - 1);
            return EMI;
        }
        public double SIFormula(double principal, double ROI)
        {
            double SI = (principal * ROI * 1) / 100;
            return (principal + SI);
        }
        public double CIformula(double principal, double ROI)
        {
            double c1 = (1 + (ROI / 12));
            double c2 = Math.Pow(c1, 12);
            return (principal * c2);
        }
        public double EMICalculator(double principal)
        {
            if (principal<=100000)
            {
                return EMIFormula(principal, 0.1);
            }
            else if (principal>100000 && principal <= 200000)
            {
                return EMIFormula(principal, 0.23);
            }
            else
            {
                return EMIFormula(principal, 0.29);
            }
            return 0;
        }
        public double SICalculator(double principal)
        {
            if (principal <= 10000)
            {
                return (SIFormula(principal, 2));
            }
            if (principal>10000 && principal < 20000)
            {
                return (SIFormula(principal, 5));
            }
            else
            {
                return (SIFormula(principal, 9));
            }
        }
        public double CICalculator(double principal)
        {
            if (principal <= 10000)
            {
                return (CIformula(principal, 0.05));
            }
            if (principal > 10000 && principal < 20000)
            {
                return (CIformula(principal, 0.07));
            }
            else
            {
                return (CIformula(principal, 0.11));
            }
        }
       
    }
}
