using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace StandardCalculator
{
  
   
    public partial class Form1 : Form
    {
      private double result;
      bool check;
        List<char> textExpression = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }

       public void standatdToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Width = 250;
           answerDisplay.Width = 198;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 354;
            answerDisplay.Width = 298;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 250;
            answerDisplay.Width = 198;
        }
        ArithmetiCalculation arithmeticObj = new ArithmetiCalculation();
        private void Equal_Click(object sender, EventArgs e)
        {
            
            try
            {
                result = arithmeticObj.AtithmeticCal(textExpression);
                answerDisplay.Text = Convert.ToString(result);
                check = true;
            }
            catch(Exception ex)
            {
                answerDisplay.Text = Convert.ToString(ex);
            }
        }

        private void PI_Click(object sender, EventArgs e)
        {
            answerDisplay.Text = "3.141592653589976323";
            check = true;
        }

        IScientificCalculation redioObj;
        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                result = redioObj.SinCal(Convert.ToDouble(answerDisplay.Text));
                answerDisplay.Text = Convert.ToString(result);
                check = true;
            }
            catch(Exception ex)
            {
                answerDisplay.Text = "Radio Button Must be Select First";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                result = redioObj.CosCal(Convert.ToDouble(answerDisplay.Text));
                answerDisplay.Text = Convert.ToString(result);
                check = true;
            }
            catch (Exception ex)
            {
                answerDisplay.Text = "Radio Button Must be Select First";
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {

            try
            {
                result = redioObj.TanCal(Convert.ToDouble(answerDisplay.Text));
                answerDisplay.Text = Convert.ToString(result);
                check = true;
            }
            catch (Exception ex)
            {
                answerDisplay.Text = "Radio Button Must be Select First";
            }
        }
       
        private void Degree_CheckedChanged(object sender, EventArgs e)
        {
           
            redioObj=new DegreeCal();
            answerDisplay.Clear();
            textExpression.Clear();
        }
        private void Redian_CheckedChanged(object sender, EventArgs e)
        {
            redioObj = new RedCal();
            answerDisplay.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            answerDisplay.Clear();
        }

        private void NumberSinClick(object sender, EventArgs e)
        {
            if(check==true)
            {
                answerDisplay.Clear();
                textExpression.Clear();
                check = false;
            }
            Button num = (Button)sender;
            answerDisplay.Text += num.Text;
            textExpression.Add(Convert.ToChar(num.Text));
        }
    }
}
