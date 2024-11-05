using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_LABA_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int GetHashCodeDivisionMethod(int n)
        {
            return n / 1000;
        }

        public static int GetHashCode(int key, int tableSize)
        {
            // Вычисление квадрата ключа
            long squareKey = (long)key * key;

            // Получение среднего числа из квадрата
            int hashValue = (int)((squareKey / Math.Pow(10, (Math.Log10(squareKey) - 1))) % tableSize);

            return hashValue;
        }



        private void ButtonExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            int result = GetHashCode(234583, 100);
            textBoxMiddleOfSquare.Text = result.ToString();
            textBoxDivisionMethod.Text = GetHashCodeDivisionMethod(45678).ToString();
        }
    }
}
