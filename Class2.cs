using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    public interface sScientificCalculation
    {
        double SinCal(double number);
        double CosCal(double number);
        double TanCal(double number);
        double LogCal(double number);
        double Degcal(double angle,string type);
        double RedCal(double angle,string type);
    }
   
    class Class2:sScientificCalculation
    {
        public double SinCal(double number)
        {
            //double qsin = Double.Parse(fr.answerDisplay.Text);
            double  qsin = (number * Math.PI) / 180;
            qsin = Math.Sin(qsin);
            return qsin;
        }
        public double CosCal(double number)
        {
            
            double qcos = (number * Math.PI) / 180;
            qcos = Math.Cos(qcos);
            return qcos;
        }
        public double TanCal(double number)
        {
            double qtan = (number * Math.PI) / 180;
            qtan = Math.Tan(qtan);
            return qtan;
        }
        public double LogCal(double number)
        {
             double qlog= Math.Log10(number);
            return qlog;
        }
        double qsin;
       public  double Degcal(double angle,string type)
        {
            if(type=="sin")
            {
                qsin = (angle * Math.PI) / 180;
                qsin = Math.Sin(qsin);
            }
            else if(type=="cos")
            {
                qsin = (angle * Math.PI) / 180;
                qsin = Math.Cos(qsin);
            }
            else if(type=="tan")
            {
                qsin = (angle * Math.PI) / 180;
                qsin = Math.Tan(qsin);
            }
            return qsin;
        }
       public double RedCal(double angle,string type)
        {
            if (type == "sin")
            {
                qsin = Math.Sin(angle);
            }
            else if (type == "cos")
            {
                qsin = Math.Cos(angle);
            }
            else if (type == "tan")
            {

                qsin = Math.Tan(angle);
            }

            return qsin;
        }
        double answser;
        public double AtithmeticCal(double firstNumber,double secondNumber,string opt)
        {
           
            if(opt=="+")
            {
                answser = firstNumber + secondNumber;
            }
            else if(opt=="-")
            {
                answser = firstNumber + secondNumber;
            }
            else if(opt=="*")
            {
                answser = firstNumber * secondNumber;
            }
            else if(opt=="/")
            {
                answser = firstNumber / secondNumber;
            }
            return answser;
        }
    }
}
