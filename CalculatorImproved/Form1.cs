using System.Drawing.Text;

namespace CalculatorImproved
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        decimal operandOne;
        decimal operandTwo;
        char op = 'n';
        decimal result;
        bool typing = true;

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (typing) 
                txtCalc.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (typing)
                txtCalc.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForOperator(txtCalc.Text))
            {
                txtCalc.Text += "+";
                op = '+';
                
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (CheckForOperator(txtCalc.Text))
            {
                txtCalc.Text += "-";
                op = '-';
                
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (CheckForOperator(txtCalc.Text))
            {
                txtCalc.Text += "x";
                op = 'x';
                
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (CheckForOperator(txtCalc.Text))
            {
                txtCalc.Text += "/";
                op = '/';
                
            }

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            
            txtCalc.Clear();
            txtCalc.Text += "Sin(";
            op = 's';

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            
            txtCalc.Text += "+";
            op = 'c';
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            
            if (txtCalc.Text == "")
            {
                txtCalc.Text += "tan";
                op = 't';
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "^";
            op = '^';
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            
            if (txtCalc.Text == "")
            {
                txtCalc.Text += "√";
                op = 'r';
            }
        }

        private bool CheckForOperator(string s)
        {
            foreach (char c in s)
                if (c == '+' || c == '-' || c == 'x' || c == '/' || c == 'n' || c == '√')
                    return false;

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            typing = true;
            if(op != 'n')
                lstHistory.Items.Add(txtCalc.Text);
            txtCalc.Clear();
            operandOne = 0;
            operandTwo = 0;
            op = 'n';
            

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            switch (op)
            {
                case ('+'):
                    operandOne = Decimal.Parse(SplitOperands(txtCalc.Text, op)[0]);
                    operandTwo = Decimal.Parse(SplitOperands(txtCalc.Text, op)[1]);
                    result = operandOne + operandTwo;
                    txtCalc.Text += " = " + result;
                    break;

                case ('-'):
                    operandOne = Decimal.Parse(SplitOperands(txtCalc.Text, op)[0]);
                    operandTwo = Decimal.Parse(SplitOperands(txtCalc.Text, op)[1]);
                    result = operandOne - operandTwo;
                    txtCalc.Text += " = " + result;
                    break;

                case ('x'):
                    operandOne = Decimal.Parse(SplitOperands(txtCalc.Text, op)[0]);
                    operandTwo = Decimal.Parse(SplitOperands(txtCalc.Text, op)[1]);
                    result = operandOne * operandTwo;
                    txtCalc.Text += " = " + result;
                    break;

                case ('/'):
                    operandOne = Decimal.Parse(SplitOperands(txtCalc.Text, op)[0]);
                    operandTwo = Decimal.Parse(SplitOperands(txtCalc.Text, op)[1]);
                    result = operandOne / operandTwo;
                    txtCalc.Text += " = " + result;
                    break;

                case ('s'):
                    operandOne = Decimal.Parse(txtCalc.Text.Substring(4));
                    if(radioButton1.Checked)
                        result = (decimal)Math.Sin((double) operandOne);
                    else
                        result = (decimal)Math.Sin(((double)operandOne)/(180 / Math.PI));
                    txtCalc.Text += " = " + result;
                    break;

                case ('c'):
                    operandOne = Decimal.Parse(txtCalc.Text.Substring(4));
                    if (radioButton1.Checked)
                        result = (decimal)Math.Cos((double)operandOne);
                    else
                        result = (decimal)Math.Cos(((double)operandOne)/(180 / Math.PI));
                    txtCalc.Text += " = " + result;
                    break;

                case ('t'):
                    operandOne = Decimal.Parse(txtCalc.Text.Substring(4));
                    if (radioButton1.Checked)
                        result = (decimal)Math.Tan((double)operandOne);
                    else
                        result = (decimal)Math.Tan(((double)operandOne) / (180 / Math.PI));
                    txtCalc.Text += " = " + result;
                    break;
                    
                case ('^'):
                    operandOne = Decimal.Parse(SplitOperands(txtCalc.Text, op)[0]);
                    operandTwo = Decimal.Parse(SplitOperands(txtCalc.Text, op)[1]);
                    result = (decimal)Math.Pow((double) operandOne, (double) operandTwo);
                    txtCalc.Text += " = " + result;
                    break;

                case ('r'):
                    operandOne = Decimal.Parse(txtCalc.Text.Substring(1));
                    result = (decimal)Math.Sqrt((double) operandOne);
                    txtCalc.Text += " = " + result;
                    break;
            }
            typing = false;
            
        }

        private string[] SplitOperands(string s, char charOp)
        {
            string[] operOne = s.Split(charOp, 2);
            return operOne;
        }

        
        
    }
}
