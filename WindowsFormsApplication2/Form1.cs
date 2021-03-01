using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //Declare All Variables required
        string matNum;
        char lastNum;

        //declare all required lists
        List<int> firstName_surName1 = new List<int>();
        List<int> firstName_surName2 = new List<int>();
        List<int> firstName_surName3 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            firstName_surName1.Clear();
            firstName_surName2.Clear();
            firstName_surName3.Clear();
            matNum = input.Text;
            lastNum = matNum.Last();
           //tring test = new string(lastNum);
            int lastDigit = lastNum - '0';

         // MessageBox.Show(Char.ToString(lastNum));


            for (int i = lastDigit; i < lastDigit + 10; i++) {
                firstName_surName1.Add(i);
            }

            string s = String.Join(",", firstName_surName1);

            MessageBox.Show(s, "FirstName_surname");

            for (int i = 0; i < firstName_surName1.Count; i++) {
                firstName_surName2.Add((firstName_surName1[i] * firstName_surName1[i]));
            }

            string s2 = String.Join(",", firstName_surName2);
            MessageBox.Show(s2,"FirstName_surname2");


            for (int i = 0; i < firstName_surName1.Count; i++){
                firstName_surName3.Add(firstName_surName1[i] + firstName_surName2[i]);
            
            }

            string s3 = String.Join(",", firstName_surName3);
            MessageBox.Show(s3,"FirstName_surname3");
        }
    }
}
