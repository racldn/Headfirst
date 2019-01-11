using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3p1
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
