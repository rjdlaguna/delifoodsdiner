using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto_Bar
{
    public partial class formMAIN : Form
    {
        public formMAIN()
        {
            InitializeComponent();
            
           
        }

        private void chkSpag_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            int tom = 0;
                      
                if (chkSpag.Checked == true)
                {
                    if (Int32.Parse(lblSpag.Text) > 0 && txtState.Text =="0")
                    {
                        amount = amount + 50;
                        txtTotalAmount.Text = Convert.ToString(amount + ".00");
                        count = (Int32.Parse(lblSpag.Text) - 1);
                        lblSpag.Text = Convert.ToString(count);
                        lstOrder.Items.Add(chkSpag.Text);
                        
                       
                    }
                    else
                    {
                        tom = tom + 1;
                        MessageBox.Show("No item available.");
                        chkSpag.Checked = false;
                        lblSpag.Text = "0";
                       
                        
                    }
                }
                else
                {
                    if (count >= 0 && txtState.Text =="0")
                    {
                        if (amount != 0)
                        {
                            amount = amount - 50;
                        }
                        txtTotalAmount.Text = Convert.ToString(amount + ".00");
                        count = (Int32.Parse(lblSpag.Text) + 1);
                        lblSpag.Text = Convert.ToString(count);
                        lstOrder.Items.Remove(chkSpag.Text);
                    }


                }
               
            
        }

        private void chkBurger_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0, tom = 0;
            if (chkBurger.Checked == true)
            {
                if (Int32.Parse(lblBurger.Text) > 0 && txtState.Text == "0")
                {


                    amount = amount + 45;
                    txtTotalAmount.Text = Convert.ToString(amount + ".00");
                    count = (Int32.Parse(lblBurger.Text) - 1);
                    lblBurger.Text = Convert.ToString(count);
                    lstOrder.Items.Add(chkBurger.Text);
                }
                else
                {
                    tom = tom + 1;
                    MessageBox.Show("No item available.");
                    chkBurger.Checked = false;
                    lblBurger.Text = "0";
                }

            }
            else
            {
                if (count >= 0 && txtState.Text == "0")
                {
                    if (amount != 0)
                    {
                        amount = amount - 45;
                    }
                    amount = amount - 45;
                    txtTotalAmount.Text = Convert.ToString(amount + ".00");
                    count = (Int32.Parse(lblBurger.Text) + 1);
                    lblBurger.Text = Convert.ToString(count);
                    txtCheck.Text = "1";
                    lstOrder.Items.Remove(chkBurger.Text);
                }
            }
        }

        private void chkFrench_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (chkFrench.Checked == true)
            {
                amount = amount + 45;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblFrench.Text) - 1);
                lblFrench.Text = Convert.ToString(count);
                lstOrder.Items.Add(chkFrench.Text);
            }
            else
            {
                amount = amount - 45;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblFrench.Text) + 1);
                lblFrench.Text = Convert.ToString(count);
                lstOrder.Items.Remove(chkFrench.Text);

            }

        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (chkChicken.Checked == true)
            {
                amount = amount + 60;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblFried.Text) - 1);
                lblFried.Text = Convert.ToString(count);
                lstOrder.Items.Add(chkChicken.Text);
            }
            else
            {
                amount = amount - 60;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblFried.Text) + 1);
                lblFried.Text = Convert.ToString(count);
                lstOrder.Items.Remove(chkChicken.Text);

            }
        }

        private void radSoftdrinks_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (radSoftdrinks.Checked == true)
            {

                amount = amount + 30;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblSoft.Text) - 1);
                lblSoft.Text = Convert.ToString(count);
                lstOrder.Items.Add(radSoftdrinks.Text);
            }
            else
            {
                amount = amount - 30;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblSoft.Text) + 1);
                lblSoft.Text = Convert.ToString(count);
                lstOrder.Items.Remove(radSoftdrinks.Text);

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //radSoftdrinks.Checked = false;
        }

        private void radIcetea_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (radIcetea.Checked == true)
            {

                amount = amount + 25;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblIced.Text) - 1);
                lblIced.Text = Convert.ToString(count);
                lstOrder.Items.Add(radIcetea.Text);
            }
            else
            {
                amount = amount - 25;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblIced.Text) + 1);
                lblIced.Text = Convert.ToString(count);
                lstOrder.Items.Remove(radIcetea.Text);
            }
        }

        private void radWater_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (radWater.Checked == true)
            {

                amount = amount + 15;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblWater.Text) - 1);
                lblWater.Text = Convert.ToString(count);
                lstOrder.Items.Add(radWater.Text);
            }
            else
            {
                amount = amount - 15;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblWater.Text) + 1);
                lblWater.Text = Convert.ToString(count);
                lstOrder.Items.Remove(radWater.Text);

            }
        }

        private void radCoffeee_CheckedChanged(object sender, EventArgs e)
        {
            double amount = Double.Parse(txtTotalAmount.Text);
            int count = 0;
            if (radCoffeee.Checked == true)
            {

                amount = amount + 20;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblCoffee.Text) - 1);
                lblCoffee.Text = Convert.ToString(count);
                lstOrder.Items.Add(radCoffeee.Text);
            }
            else
            {
                amount = amount - 20;
                txtTotalAmount.Text = Convert.ToString(amount + ".00");
                count = (Int32.Parse(lblCoffee.Text) + 1);
                lblCoffee.Text = Convert.ToString(count);
                lstOrder.Items.Remove(radCoffeee.Text);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtState.Text = "1";
            txtCheck.Text = "1";
            double change = 0;
            double totalamt = Double.Parse(txtTotalAmount.Text);
            double cashAmt = Double.Parse(txtCash.Text);
            int count = 0;

            if (totalamt > cashAmt)
            {
                MessageBox.Show("Insufficient cash amount.");
                txtCash.Focus();
            }
            else
            {
                change = cashAmt - totalamt;
                txtChange.Text = Convert.ToString(change + ".00");
                txtCheck.Text = "1";
               
                
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtState.Text != "0")
            {
                if (chkSpag.Checked == true && Int32.Parse(lblSpag.Text)>0)
                {
                    //lblSpag.Text = Convert.ToString(Int32.Parse(lblSpag.Text) - 1);
                    txtTotalAmount.Text = "0.00";
                }
                if (chkBurger.Checked == true && Int32.Parse(lblBurger.Text)>0)
                {
                    //lblBurger.Text = Convert.ToString(Int32.Parse(lblBurger.Text) - 1);
                    txtTotalAmount.Text = "0.00";
                }
                if (chkFrench.Checked == true)
                {
                    lblFrench.Text = Convert.ToString(Int32.Parse(lblFrench.Text) - 1);
                }
                if (chkChicken.Checked == true)
                {
                    lblFried.Text = Convert.ToString(Int32.Parse(lblFried.Text) - 1);
                }
                if (radSoftdrinks.Checked == true)
                {
                    lblSoft.Text = Convert.ToString(Int32.Parse(lblSoft.Text) - 1);
                }
                if (radIcetea.Checked == true)
                {
                    lblIced.Text = Convert.ToString(Int32.Parse(lblIced.Text) - 1);
                }
                if (radWater.Checked == true)
                {
                    lblWater.Text = Convert.ToString(Int32.Parse(lblWater.Text) - 1);
                }
                if (radCoffeee.Checked == true)
                {
                    lblCoffee.Text = Convert.ToString(Int32.Parse(lblCoffee.Text) - 1);
                }
            }
            chkSpag.Checked = false;
            chkBurger.Checked = false;
            chkFrench.Checked = false;
            chkChicken.Checked = false;
            radCoffeee.Checked = false;
            radIcetea.Checked = false;
            radWater.Checked = false;
            radSoftdrinks.Checked = false;
            txtCash.Text = "0.00";
            txtChange.Text = "0.00";
            txtTotalAmount.Text = "0.00";
            txtState.Text = "0";
            txtDisc.Text = "0.00";
            chkDisc.Checked = false;
            lstOrder.Items.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
          
            
           
            
            
        }

        private void chkDisc_CheckedChanged(object sender, EventArgs e)
        {
            double disc, total;
            total = Convert.ToDouble(txttempTotal.Text);
            if (chkDisc.Checked)
            {
                txtDisc.Enabled = true;
                txtDisc.Focus();
            }
            else
            {
                txtDisc.Enabled = false;
                disc = Convert.ToDouble(txtDisc.Text);
                disc = disc / 100;
                disc = total * disc;
                total = disc + Convert.ToDouble(txtTotalAmount.Text);
                txtTotalAmount.Text = Convert.ToString(total);
                txtDisc.Text = "0";

            }
        }

        private void txtDisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double disc, total;
                total = Convert.ToDouble(txtTotalAmount.Text);
                if (chkDisc.Checked)
                {
                    disc = Convert.ToDouble(txtDisc.Text);
                    disc = disc / 100;
                    txttempTotal.Text = Convert.ToString(total);
                    disc = total * disc;
                    total = total - disc;
                    txtTotalAmount.Text = Convert.ToString(total);
                }
            }
        }

        private void txttempTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }
    }
}
