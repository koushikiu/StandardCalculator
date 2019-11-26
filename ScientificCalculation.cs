using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    public interface IScientificCalculation
    {
        double SinCal(double number);
        double CosCal(double number);
        double TanCal(double number);
       
    }

    class DegreeCal:IScientificCalculation
    {
        double answer;
       public double SinCal(double number)
        {
             answer = (number * Math.PI) / 180;
             answer = Math.Sin(answer);
            return answer;
           
        }
       public double CosCal(double number)
        {
            answer = (number * Math.PI) / 180;
            answer = Math.Cos(answer);
            return answer;
        }
       public double TanCal(double number)
        {
            answer = (number * Math.PI) / 180;
            answer = Math.Tan(answer);
            return answer;
        }
        
    }
    class RedCal : IScientificCalculation
    {
        public double SinCal(double number)
        {
           double qsin = Math.Sin(number);
            return qsin;
        }
        public double CosCal(double number)
        {
            double qsin = Math.Cos(number);
            return qsin;
        }
        public double TanCal(double number)
        {
            double qsin = Math.Tan(number);
            return qsin;
        }
    }
}
