using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class frmCalculator : Form
    {

        char _process;
        bool _isClear;
        double _firstNumber;
        int counter = 0;
        public frmCalculator()
        {
            InitializeComponent();
        }



        private void btnOne_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }
            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "1";
          
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "2";
        
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "3";
          
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "4";
         
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "5";
        
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "6";
        
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "7";
      
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
               
                lbScreen.Text = "";
                lbShow.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "8";
       
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "9";
      
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbShow.Text = "";
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
            lbScreen.Text += "0";
      
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            /*
            _process = '+';
            _isClear = true;
            _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "+");
            */
            counter++;
            _process = '+';
            _isClear = true;
            if (counter <= 1)     _firstNumber = Convert.ToDouble(lbScreen.Text);
                lbShow.Text = Convert.ToString(_firstNumber + "+");

            if (counter > 1)
            {
                double secondNumber = Convert.ToDouble(lbScreen.Text);
                double result;
                _isClear = true;
                result = _firstNumber + secondNumber;
                lbScreen.Text = Convert.ToString(result);
                lbShow.Text = Convert.ToString(_firstNumber) + _process + secondNumber + "+";
                _firstNumber = Convert.ToDouble(lbScreen.Text);
            }

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {   /*
            _process = '-';
            _isClear = true;
            _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "-");
            */
            counter++;
            _process = '-';
            _isClear = true;
            if (counter <= 1) _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "-");

            if (counter > 1)
            {
                double secondNumber = Convert.ToDouble(lbScreen.Text);
                double result;
                _isClear = true;
                result = _firstNumber - secondNumber;
                lbScreen.Text = Convert.ToString(result);
                lbShow.Text = Convert.ToString(_firstNumber) + _process + secondNumber + "-";
                _firstNumber = Convert.ToDouble(lbScreen.Text);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {   /*
            _process = '*';
            _isClear = true;
            _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "*");
            */
            counter++;
            _process = '*';
            _isClear = true;
            if (counter <= 1) _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "*");

            if (counter > 1)
            {
                double secondNumber = Convert.ToDouble(lbScreen.Text);
                double result;
                _isClear = true;
                result = _firstNumber * secondNumber;
                lbScreen.Text = Convert.ToString(result);
                lbShow.Text = Convert.ToString(_firstNumber) + _process + secondNumber + "*";
                _firstNumber = Convert.ToDouble(lbScreen.Text);
            }
        }

        private void btnSlash_Click(object sender, EventArgs e)
        {
            /*
            _process = '/';
            _isClear = true;
            _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "/");
            */
            counter++;
            _process = '/';
            _isClear = true;
            if (counter <= 1) _firstNumber = Convert.ToDouble(lbScreen.Text);
            lbShow.Text = Convert.ToString(_firstNumber + "/");

            if (counter > 1)
            {
                double secondNumber = Convert.ToDouble(lbScreen.Text);
                double result;
                _isClear = true;
                result = _firstNumber / secondNumber;
                lbScreen.Text = Convert.ToString(result);
                lbShow.Text = Convert.ToString(_firstNumber) + _process + secondNumber + "/";
                _firstNumber = Convert.ToDouble(lbScreen.Text);
            }

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(lbScreen.Text);
            double result;
            _isClear = true;
            counter = 0;
           

            switch (_process)
            {
                case '+':
                    result = _firstNumber + secondNumber;
                    break;

                case '-':
                    result = _firstNumber - secondNumber;
                    break;

                case '*':
                    result = _firstNumber * secondNumber;
                    break;

                case '/':
                    result = _firstNumber / secondNumber;
                    break;
                default:
                    result = 0;
                    break;
            }

            lbScreen.Text = Convert.ToString(result);
            lbShow.Text = Convert.ToString(_firstNumber) + _process + secondNumber + "=";
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbScreen.Text = "0";
            lbShow.Text = "";
            _firstNumber = 0;
            counter = 0;

        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {
                case Keys.NumPad1:
                    btnOne.PerformClick();
                    break;
                case Keys.NumPad2:
                    btnTwo.PerformClick();
                    break;
                case Keys.NumPad3:
                    btnThree.PerformClick();
                    break;
                case Keys.NumPad4:
                    btnFour.PerformClick();
                    break;
                case Keys.NumPad5:
                    btnFive.PerformClick();
                    break;
                case Keys.NumPad6:
                    btnSix.PerformClick();
                    break;
                case Keys.NumPad7:
                    btnSeven.PerformClick();
                    break;
                case Keys.NumPad8:
                    btnEight.PerformClick();
                    break;
                case Keys.NumPad9:
                    btnNine.PerformClick();
                    break;
                case Keys.NumPad0:
                    btnZero.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSubtraction.PerformClick();
                    break;
                case Keys.Add:
                    btnAddition.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplication.PerformClick();
                    break;
                case Keys.Divide:
                    btnSlash.PerformClick();
                    break;
                case Keys.Enter:
                    btnEqual.PerformClick();
                    break;
                case Keys.Delete:
                    btnClear.PerformClick();
                    break;
                case Keys.Decimal:
                    btnDot.PerformClick();
                    break;
                  }
            }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (_isClear)
            {
                lbScreen.Text = "";
                _isClear = false;
            }

            if (lbScreen.Text == "0") lbScreen.Text = "";
          

            if (!lbScreen.Text.Contains("."))
            {
                lbScreen.Text += ".";
            }
        }
    }
}
