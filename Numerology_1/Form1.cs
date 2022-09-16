using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerology_1
{
    public partial class Form1 : Form
    {
        private string nameEntered="";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string toString = ""; //holds the sum of letters.

            //arrays for initial sum
            string[] sumThousand = new string[toString.Length];
            string[] sumHundred = new string[toString.Length];
            string[] sumTen = new string[toString.Length];

            //variables for validity check
            bool containsInt = false;
            bool containsSpecialChars = false;

            //variables-arrays for separate sum and control of data
            int nameNumbered = 0;
            int currentLetter = 0;
            int [] sumTempThousand = {0};
            int [] sumTempHundred = {0};
            int [] sumTempTen = {0};
            int [] greaterThanTenSum = {0};
            int[] greaterThanHundredSum = { 0 };
            int[] greaterThanThousandSum = { 0 };
            int totalTenNum = 0;
            int totalHundredNum = 0;
            int totalThousandNum = 0;


            //check if name is properly written
            containsInt = Total1.Text.Any(char.IsDigit);
            containsSpecialChars = HasSpecialChars(Total1.Text);

            if(!containsInt & !containsSpecialChars)
            {
                nameEntered = Total1.Text;

                //loop through characters of given name
                for (int i = 0; i < nameEntered.Length; i++)
                {
                    if(nameEntered[i] == 'a' | nameEntered[i] == 'A' | nameEntered[i] == 'α' | nameEntered[i] == 'Α' | nameEntered[i] == 'ά' | nameEntered[i] == 'Ά')
                    {
                        currentLetter = 1;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'b' | nameEntered[i] == 'B' | nameEntered[i] == 'β' | nameEntered[i] == 'Β')
                    {
                        currentLetter = 2;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'c' | nameEntered[i] == 'C' | nameEntered[i] == 'γ' | nameEntered[i] == 'Γ')
                    {
                        currentLetter = 3;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'd' | nameEntered[i] == 'D' | nameEntered[i] == 'δ' | nameEntered[i] == 'Δ')
                    {
                        currentLetter = 4;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'e' | nameEntered[i] == 'E' | nameEntered[i] == 'ε' | nameEntered[i] == 'Ε' | nameEntered[i] == 'έ' | nameEntered[i] == 'Έ')
                    {
                        currentLetter = 5;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'f' | nameEntered[i] == 'F' | nameEntered[i] == 'ζ' | nameEntered[i] == 'Ζ')
                    {
                        currentLetter = 6;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'g' | nameEntered[i] == 'G' | nameEntered[i] == 'η' | nameEntered[i] == 'Η' | nameEntered[i] == 'ή' | nameEntered[i] == 'Ή')
                    {
                        currentLetter = 7;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'h' | nameEntered[i] == 'H' | nameEntered[i] == 'θ' | nameEntered[i] == 'Θ')
                    {
                        currentLetter = 8;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'i' | nameEntered[i] == 'I' | nameEntered[i] == 'ι' | nameEntered[i] == 'Ι' | nameEntered[i] == 'ί' | nameEntered[i] == 'Ί')
                    {
                        currentLetter = 9;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'j' | nameEntered[i] == 'J' | nameEntered[i] == 'κ' | nameEntered[i] == 'Κ')
                    {
                        currentLetter = 10;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'k' | nameEntered[i] == 'K' | nameEntered[i] == 'λ' | nameEntered[i] == 'Λ')
                    {
                        currentLetter = 11;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'l' | nameEntered[i] == 'L' | nameEntered[i] == 'μ' | nameEntered[i] == 'Μ')
                    {
                        currentLetter = 12;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'm' | nameEntered[i] == 'M' | nameEntered[i] == 'ν' | nameEntered[i] == 'Ν')
                    {
                        currentLetter = 13;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'n' | nameEntered[i] == 'N' | nameEntered[i] == 'ξ' | nameEntered[i] == 'Ξ')
                    {
                        currentLetter = 14;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'o' | nameEntered[i] == 'O' | nameEntered[i] == 'ο' | nameEntered[i] == 'Ο' | nameEntered[i] == 'ό' | nameEntered[i] == 'Ό')
                    {
                        currentLetter = 15;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'p' | nameEntered[i] == 'P' | nameEntered[i] == 'π' | nameEntered[i] == 'Π')
                    {
                        currentLetter = 16;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'q' | nameEntered[i] == 'Q' | nameEntered[i] == 'ρ' | nameEntered[i] == 'Ρ')
                    {
                        currentLetter = 17;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'r' | nameEntered[i] == 'R' | nameEntered[i] == 'σ' | nameEntered[i] == 'Σ' | nameEntered[i] == 'ς')
                    {
                        currentLetter = 18;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 's' | nameEntered[i] == 'S' | nameEntered[i] == 'τ' | nameEntered[i] == 'Τ')
                    {
                        currentLetter = 19;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 't' | nameEntered[i] == 'T' | nameEntered[i] == 'υ' | nameEntered[i] == 'Υ' | nameEntered[i] == 'ύ' | nameEntered[i] == 'Ύ')
                    {
                        currentLetter = 20;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'u' | nameEntered[i] == 'U' | nameEntered[i] == 'φ' | nameEntered[i] == 'Φ')
                    {
                        currentLetter = 21;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'v' | nameEntered[i] == 'V' | nameEntered[i] == 'χ' | nameEntered[i] == 'Χ')
                    {
                        currentLetter = 22;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'w' | nameEntered[i] == 'W' | nameEntered[i] == 'ψ' | nameEntered[i] == 'Ψ')
                    {
                        currentLetter = 23;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'x' | nameEntered[i] == 'X' | nameEntered[i] == 'ω' | nameEntered[i] == 'Ω' | nameEntered[i] == 'ώ' | nameEntered[i] == 'Ώ')
                    {
                        currentLetter = 24;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'y' | nameEntered[i] == 'Y')
                    {
                        currentLetter = 25;
                        nameNumbered += currentLetter;
                    }
                    if (nameEntered[i] == 'z' | nameEntered[i] == 'Z')
                    {
                        currentLetter = 26;
                        nameNumbered += currentLetter;
                    }
                }
            }
            else
            {
                //retry and clear textbox
                if(containsInt)
                {
                    MessageBox.Show("Your name contains a number!");
                    Total1.Text = "";
                }
                if(containsSpecialChars)
                {
                    MessageBox.Show("Your name contains a special character or space!");
                    Total1.Text = "";
                }
            }

            Total3.Text = nameNumbered.ToString();

            toString = nameNumbered.ToString();

            sumTempTen = new int[toString.ToString().Length];

            sumTempHundred = new int[toString.ToString().Length];

            sumTempThousand = new int[toString.ToString().Length];

            //greater than 1000
            if (nameNumbered >= 1000)
            {
                for(int i = 0; i < sumTempThousand.Length; i++)
                {
                    sumTempThousand[i] = Convert.ToInt32(toString.Substring(i, 1));
                    totalThousandNum += sumTempThousand[i];
                }

                if(totalThousandNum == 1000)
                {
                    nameNumbered = 1;
                }
                else if(totalThousandNum > 1000)
                {
                    int tempThousandNum = 0;
                    string toGreaterThanThousand = totalThousandNum.ToString();
                    greaterThanThousandSum = new int[toGreaterThanThousand.ToString().Length];

                    for (int j = 0; j < greaterThanThousandSum.Length; j++)
                    {
                        greaterThanThousandSum[j] = Convert.ToInt32(toGreaterThanThousand.Substring(j, 1));
                        tempThousandNum += greaterThanThousandSum[j];
                    }
                    nameNumbered = tempThousandNum;
                }
                else
                {
                    nameNumbered = totalThousandNum;
                }
            }

            //greater than 100
            if (nameNumbered >= 100)
            {
                for (int k = 0; k < sumTempHundred.Length; k++)
                {
                    sumTempHundred[k] = Convert.ToInt32(toString.Substring(k, 1));
                    totalHundredNum += sumTempHundred[k];
                }

                if (totalHundredNum == 100)
                {
                    nameNumbered = 1;
                }
                else if (totalHundredNum > 100)
                {
                    int tempHundredNum = 0;
                    string toGreaterThanHundred = totalHundredNum.ToString();
                    greaterThanHundredSum = new int[toGreaterThanHundred.ToString().Length];

                    for (int l = 0; l < greaterThanHundredSum.Length; l++)
                    {
                        greaterThanHundredSum[l] = Convert.ToInt32(toGreaterThanHundred.Substring(l, 1));
                        tempHundredNum += greaterThanHundredSum[l];
                    }
                    nameNumbered = tempHundredNum;
                }
                else
                {
                    nameNumbered = totalHundredNum;
                }

            }

            //greater than 10
            if (nameNumbered >= 10)
            {
                for (int m = 0; m < sumTempTen.Length; m++)
                {
                    sumTempTen[m] = Convert.ToInt32(toString.Substring(m,1));
                    totalTenNum += sumTempTen[m];
                }

                if(totalTenNum == 10)
                {
                    nameNumbered = 1;
                }
                else if (totalTenNum > 10)
                {
                    int tempTenNum = 0;
                    string toGreaterThanTen = totalTenNum.ToString();
                    greaterThanTenSum = new int[toGreaterThanTen.ToString().Length];

                    for (int n = 0; n < greaterThanTenSum.Length; n++)
                    {
                        greaterThanTenSum[n] = Convert.ToInt32(toGreaterThanTen.Substring(n, 1));
                        tempTenNum += greaterThanTenSum[n];
                    }
                    nameNumbered = tempTenNum;
                }
                else
                {
                    nameNumbered = totalTenNum;
                }

            }

            Total2.Text = nameNumbered.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Total1.MaxLength = 50;
            Total2.Text = "0";
            Total3.Text = "0";
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Total1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public bool HasSpecialChars(string givenString)
        {
            return givenString.Any(ch => ! char.IsLetterOrDigit(ch));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Total1.Text = "";
            Total2.Text = "0";
            Total3.Text = "0";
        }
    }
}
