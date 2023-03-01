using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsNCowsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        string hiddenNumber = "";
        const int numberLength = 4;
        int stepCount = 0;

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

            if (!isValidNumber(userNumber))
            {
                return;
            }
            stepCount++;    
            int bullsCount = CalculateBullsCount(userNumber);
            int cowsCount = CalculateCowsCount(userNumber);

            bullsCountLabel.Text = "Быков = " + bullsCount;
            cowsCountLabel.Text = "Коров = " + cowsCount;

            mainHistoryTable.Rows.Add(stepCount, userNumber, bullsCount, cowsCount);

            if (bullsCount == numberLength)
            {
                MessageBox.Show("Поздравляем. Вы победили за " + stepCount + " шагов ");
                confirmButton.Enabled = false;
                userNumberTextBox.Enabled = false;
            }
                
        }

        private bool isValidNumber(string userNumber)
        {
            if (userNumber.Length != numberLength)
            {
                MessageBox.Show("Число должно состоять из 4 цифр!");
                return false;
            }
            
            for (int i = 0; i < userNumber.Length; i++)
            {
                if (!char.IsDigit(userNumber[i]))
                {
                    MessageBox.Show("Строка должно содержать только цифры!");
                    return false;
                }
            }

            for (int i = 0; i < userNumber.Length; i++)
            {
                for (int j = i + 1; j < userNumber.Length; j++)
                {
                    if (userNumber[i] == userNumber[j])
                    {
                        MessageBox.Show("Число должно состоять из уникальных цифр!");
                        return false;
                    }
                }
            }
            return true;
        }

        private int CalculateCowsCount(string userNumber)
        {
            int cowsCount = 0;

            for (int i = 0; i < numberLength; i++)
            {
                for (int j = 0; j < numberLength; j++)
                {
                    if (i == j)
                        continue;
                    if (hiddenNumber[i] == userNumber[j])
                        cowsCount++;
                }
            }
            return cowsCount;
        }

        private int CalculateBullsCount(string userNumber)
        {
            int bullsCount = 0;

            for (int i = 0; i < numberLength; i++)
            {
                if (hiddenNumber[i] == userNumber[i])
                    bullsCount++;
            }
            return bullsCount;
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
