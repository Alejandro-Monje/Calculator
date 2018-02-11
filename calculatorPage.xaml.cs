using Xamarin.Forms;
using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

// must have one ore more digits on either side of an operator for it to work
// dividing by zero results in an error.
//ex. 24/8 will display 3
//     5/0 will display error
//    3+ (=) will not work you will have to clear.
// you cannot have more than one operator
//After equal is pressed once you can continue using the result as the first
//number or click clear to start over.

namespace calculator
{
    public partial class calculatorPage : ContentPage
    {
        //using doubles to get decimal values
        double temp1 = 0;
        double temp2 = 0;
        double result = 0;
        string op = "";
        bool er = false;

        public calculatorPage()
        {
            InitializeComponent();
        }
        //event handeler for each button (digits 1-9)
        //Clear, operators, and math is handled in equals


        void OneClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                //since temp1 starts at 0 the first time clicked will give us the original digit
                //the second time through it is multiplied 10 and added by the digit so that it shows the digit twice
                //ex. 1 , 1 * 10 + 1 = 11 so it will show 11  on the label
                temp1 = (temp1 * 10) + 1;
                displayLabel.Text = temp1.ToString();
            }
            else
            {   //since temp2 starts at 0 the first time clicked will give us the original digit
                //the second time through it is multiplied 10 and added by the digit so that it shows the digit twice
                //ex. 1 , 1 * 10 + 1 = 11 so it will show 11  on the label

                temp2 = (temp2 * 10) + 1;
                displayLabel.Text = (temp1 + op + temp2).ToString();


            }
        }
        void TwoClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 2;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 2;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void ThreeClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 3;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
               temp2 = (temp2 * 10) + 3;
               displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void FourClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 4;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                
                temp2 = (temp2 * 10) + 4;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void FiveClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 5;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 5;
                displayLabel.Text = (temp1 + op + temp2).ToString();
            }

        }
        void SixClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 6;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 6;
                displayLabel.Text = (temp1 + op + temp2).ToString();
            }


        }
        void SevenClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 7;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 7;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }

        }
        void EightClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 8;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 8;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
            void NineClicked(object sender, System.EventArgs digit)
            {
                if (op == "")
                {
                    temp1 = (temp1 * 10) + 9;
                    displayLabel.Text = temp1.ToString();
                }
                else
                {
                    temp2 = (temp2 * 10) + 9;
                    displayLabel.Text = (temp1 + op + temp2).ToString();
                }
            }
        void ZeroClicked(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 0;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 0;
                displayLabel.Text = (temp1 + op + temp2).ToString();


            }
        }
            //--------------------------------------------------------------
            // I just reset everything and displayed the defualt which is 0
            void OnClearClicked(object sender, System.EventArgs args)
            {
                temp1 = 0;
                temp2 = 0;
                result = 0;
                op = "";
                er = false;

                displayLabel.Text = result.ToString();
            }
            //---------------------------------------------------------------
            //will show the inputs followed by the correct operator then
            //it will be stored in a string temp3 and thatswhats displayed
            // ex. (11+) 
            void PlusClicked(object sender, System.EventArgs args)
            {
                op = "+";

            displayLabel.Text = (temp1 + op ).ToString();

                
            }
            void MinusClicked(object sender, System.EventArgs args)
            {
                op = "-";

            displayLabel.Text = (temp1 + op ).ToString();

            }
            void DivisionClicked(object sender, System.EventArgs args)
            {
                op = "/";

            displayLabel.Text = (temp1 + op ).ToString();


            }
            void MultClicked(object sender, System.EventArgs args)
            {
                op = "*";
           
            displayLabel.Text = (temp1 + op ).ToString();

            }


            //----------------------------------------------------------------------------
            //based on which operator is used  it will do the math and display the result.
            //dividing by zero will show an error
            //you can continue using the result as the first number or clear and start over.
            void EqualsClicked(object sender, System.EventArgs args)
            {



                if (op == "+")
                {
                displayLabel.Text = (temp1 + temp2).ToString();
                temp1 = temp1 + temp2;
                temp2 = 0;
                }
                if (op == "-")
                {
                displayLabel.Text = (temp1 - temp2).ToString();
                temp1 = temp1 - temp2;
                temp2 = 0;
                }
                if (op == "*")
                {
                displayLabel.Text = (temp1 * temp2).ToString();
                temp1 = temp1 * temp2;
                temp2 = 0;
                }
                if (op == "/")
                {

                    if (temp2 != 0)
                    {
                    displayLabel.Text = (temp1 / temp2).ToString();
                    temp1 = temp1 / temp2;
                    temp2 = 0;
                    }
                    else
                    {
                        er = true;
                    }
                }

                if (er == true)
                {
                    displayLabel.Text = "error";

                    temp1 = 0;
                    temp2 = 0;
                    result = 0;
                    op = "";
                    er = false;
                }


            }
        }
    }
