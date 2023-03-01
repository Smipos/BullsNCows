using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsNCowsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        string hiddenNumber = "";
        const int numberLength = 4;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            for (int i = 0; i < numberLength; i++)
            {
                int digitIndex = random.Next(0, digits.Count);
                hiddenNumber += digits[digitIndex].ToString();
                digits.RemoveAt(digitIndex);
            }
            hiddenNumberLabel.Text = hiddenNumber;  
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string userNumber = userNumberTextBox.Text;

            int bullsCount = CalculateBullsCount(userNumber);
            int cowsCount = CalculateCowsCount(userNumber);
        }

        private int CalculateCowsCount(string userNumber)
        {
            throw new NotImplementedException();
        }

        private int CalculateBullsCount(string userNumber)
        {
            throw new NotImplementedException();
        }
    }
}
