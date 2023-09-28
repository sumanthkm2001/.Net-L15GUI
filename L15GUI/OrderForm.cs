using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L15GUI
{
    public partial class OrderForm : Form
    {
        string strPizzaSize;
        double dblTotalPrice = 0.00;
        int intTimmer = 0;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            const double SALES_TAX_PRICE = 0.06;

            double dblBasePrice = 0.00;
            double dblToppingPrice = 0.00;
            double dblDeliveryCharge = 0.00;
            double dblTip = 0.00;
            double dblSalesTax = 0.00;
            double dblSubTotal = 0.00;

            if (rbSmall.Checked == true)
            {
                dblBasePrice = 8.00;
                strPizzaSize = "Small";
            }
                
            else if (rbMedium.Checked == true)
            {
                dblBasePrice = 10.00;
                strPizzaSize = "Medium";
            }
                
            else if (rbLarge.Checked == true)
            {
                dblBasePrice = 14.00;
                strPizzaSize = "Large";
            }
                
            else if (rbXLarge.Checked == true)
            {
                dblBasePrice = 18.00;
                strPizzaSize = "XLarge";
            }
                

            if (chkExtraChesse.Checked == true)
                dblToppingPrice += 1.00;
            if (chkOnion.Checked == true)
                dblToppingPrice += 1.00;
            if (chkSausage.Checked == true)
                dblToppingPrice += 1.00;
            if (chkTomato.Checked == true)
                dblToppingPrice += 1.00;

            if (rbDeliveryYes.Checked == true)
                dblDeliveryCharge = 5.00;
            else if (rbDeliveryNo.Checked == true)
                dblDeliveryCharge = 0.00;

            dblTip = Convert.ToDouble(tbxTip.Text);

            dblSubTotal = dblBasePrice + dblToppingPrice + dblDeliveryCharge + dblTip;

            dblSalesTax = dblSubTotal * SALES_TAX_PRICE;
            dblTotalPrice = dblSubTotal + dblSalesTax;

            lblTotal.Text = "Total: " +dblTotalPrice.ToString("C");
        }

        private void cmdSaveOrder_Click(object sender, EventArgs e)
        {
            string strSourceFile = "C:\\Users\\User\\Downloads\\Orders.txt";
            StringBuilder stringBuilder = new StringBuilder(); 
            string strTextToWrite = Convert.ToString(stringBuilder
                .Append(tbxName.Text).Append(", ")
                .Append(tbxAddress.Text).Append(", ")
                .Append(tbxCity.Text).Append(", ")
                .Append(tbxState.Text).Append(", ")
                .Append(tbxZIP.Text).Append(", ")
                .Append(tbxMobile.Text).Append(", ")
                .Append(strPizzaSize).Append(", ")
                .Append(dblTotalPrice.ToString("C")).AppendLine()
                );
            File.AppendAllText(strSourceFile, strTextToWrite);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++intTimmer;
            lblTimer.Text= intTimmer.ToString();

            if (intTimmer >= 30) 
                lblTimer.ForeColor = System.Drawing.Color.Red;
        }
    }
}
