using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reverseNo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtBox.Text);
            string reversedNumber = new string(txtBox.Text.Reverse().ToArray());

           while (reversedNumber.Length < txtBox.Text.Length)
            {
                reversedNumber = '0' + reversedNumber;
            }
                 txtRich.Text = reversedNumber;
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            txtRich.Clear();
        }
    }
    }

