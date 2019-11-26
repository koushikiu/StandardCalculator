using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace StandardCalculator
{
    class ArithmetiCalculation
    {
        string postFix = "";
        double answer=0.0;
        int inPutTextLength;
        int number = 0;
        Stack<double> numberStack = new Stack<double>();
        Stack<string> signStack = new Stack<string>();
       public int Priority(string ch)
        {
            if (ch == "*" || ch == "/")
                return 1;
            else
                return 0;
        }
       public double  AtithmeticCal(List<char> inputText)
        {
            postFix = "";
            ArithmetiCalculation arObj = new ArithmetiCalculation();
            inPutTextLength = inputText.Count;
            for (int i = 0; i < inPutTextLength; i++)
            {
                if (inputText[i]!= '+' && inputText[i]!='-' && inputText[i] != '*' && inputText[i]!='/')
                    postFix += inputText[i].ToString();
                else
                {
                    postFix += " ";
                    if (signStack.Count() == 0)
                    {
                        signStack.Push(inputText[i].ToString());
                    }
                    else
                    {
                         
                         while(arObj.Priority(inputText[i].ToString())<=arObj.Priority(signStack.Peek()))
                         {
                             postFix += signStack.Peek();
                             signStack.Pop();
                            if (signStack.Count == 0)
                                break;
                         }
                         signStack.Push(inputText[i].ToString());
                        postFix += " ";
                    }
                }
                
            }
            while(signStack.Count()>0)
            {
                postFix +=( " "+signStack.Peek());
                signStack.Pop();
            }
       for(int i=0;i<postFix.Length;i++)
            {
              if(postFix[i]>='0'&&postFix[i]<='9')
                {
                    number = number * 10 + postFix[i] - 48;
                }
             else if(postFix[i]==' ')
                {
                    if(number>0)
                    {
                        numberStack.Push(number);
                    }
                    number = 0;
                }
              else
                {
                    double num1, num2;
                    num1 = numberStack.Peek();
                    numberStack.Pop();
                    num2 = numberStack.Pop();
                    if (postFix[i] == '+')
                        answer = num1 + num2;
                   else if (postFix[i] == '-')
                        answer = num2-num1;
                   else if (postFix[i] == '*')
                        answer = num1 * num2;
                   else if (postFix[i] == '/')
                        answer = num2/num1;
                    numberStack.Push(answer);

                }
            }
            if (numberStack.Count() > 1)
                return -1;
            else
            return numberStack.Peek();

        }

        
    }
}
