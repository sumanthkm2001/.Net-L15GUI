using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L15GUI
{
    public partial class pizzaShop : Form
    {
        public pizzaShop()
        {
            InitializeComponent();
        }

        private void cmdLauchCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void cmdLaunchOderForm_Click(object sender, EventArgs e)
        {
            OrderForm frmOrderForm = new OrderForm();
            frmOrderForm.Show();
        }
    }
}
