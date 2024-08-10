using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1_
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btcacu_Click(object sender, EventArgs e)
        {
            string lvname = txtname.Text;
            string lvphone = txtphone.Text;
            string lvtyper = cbbtyper.Text;
            string lvthis = txtthis.Text;
            string lvlast = txtlast.Text;
            double lvsum;
            double tiennuoc;
            double tienthue;


            if (string.IsNullOrWhiteSpace(lvname))
            {
                MessageBox.Show("Please Enter Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(lvphone))
            {
                MessageBox.Show("Please Enter Phone", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbtyper.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(lvlast))
            {
                MessageBox.Show("Please enter the last month's reading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(lvthis))
            {
                MessageBox.Show("Please enter this month's reading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double last = double.Parse(lvlast);
            double thisMonth = double.Parse(lvthis);

            lvsum = thisMonth - last;

            double lvmoney = 0;


            if (cbbtyper.SelectedIndex == 0)
            {
                if (lvsum < 10)
                {
                    tiennuoc = lvsum * 5.973;
                }
                else if (lvsum <= 20)
                {
                    tiennuoc = 10 * 5.973 + (lvsum - 10) * 7.052;
                }
                else if (lvsum <= 30)
                {
                    tiennuoc = 10 * 5.973 + 10 * 7.052 + (lvsum - 20) * 8.699;
                }
                else
                {
                    tiennuoc = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (lvsum - 30) * 15.929;
                }
            }
            else if (cbbtyper.SelectedIndex == 1)
            {
                tiennuoc = lvsum * 9.955;
            }
            else if (cbbtyper.SelectedIndex == 2)
            {
                tiennuoc = lvsum * 11.615;
            }
            else
            {
                tiennuoc = lvsum * 22.068;
            }


            tienthue = tiennuoc * 0.10;
            lvmoney = tiennuoc + tienthue;


            ListViewItem item = new ListViewItem(lvname);
            item.SubItems.Add(lvphone);
            item.SubItems.Add(lvtyper);
            item.SubItems.Add(lvlast + "/m3");
            item.SubItems.Add(lvthis + "/m3");
            item.SubItems.Add(lvsum.ToString() + "/m3");
            item.SubItems.Add(lvmoney.ToString("N3") + " VND");
            lv.Items.Add(item);


            txtname.Text = "";
            txtphone.Text = "";
            cbbtyper.SelectedIndex = -1;
            txtlast.Text = "";
            txtthis.Text = "";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbbtyper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtyper.SelectedIndex == 0)
            {
                lblhienthi.Text = "The first 10 cubic meters are charged at the price: 5.973 VND/m3,\n" +
                    "10 to 20 cubic meters are charged at the price: 7.052 VND/m3\n" +
                    "20 to 30 cubic meters are calculated at the price: 8.699 VND/m3\n" +
                    "From 30 cubic meters onwards: 15.929 VND/m3\n";
            }
            else if (cbbtyper.SelectedIndex == 1)
            {
                lblhienthi.Text = "Same price: 9,955 VND/m3";
            }
            else if (cbbtyper.SelectedIndex == 2)
            {
                lblhienthi.Text = "Same price: 11,615 VND/m3.";
            }
            else if (cbbtyper.SelectedIndex == 3)
            {
                lblhienthi.Text = "Same price: 22,068 VND/m3";
            }
            else
            {
                lblhienthi.Text = "Unit price and payment method";
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "You want to delete",
               "Confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)

            {
                if (lv.SelectedItems.Count > 0)
                {
                    lv.Items.Remove(lv.SelectedItems[0]);
                }
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count > 0)
            {
                var item = lv.SelectedItems[0];
                txtname.Text = item.SubItems[0].Text;
                txtphone.Text = item.SubItems[1].Text;

                if (item.SubItems[2].Text == "Household customer")
                {
                    cbbtyper.SelectedIndex = 0;
                }
                else if (item.SubItems[2].Text == "Administrative agency, public services")
                {
                    cbbtyper.SelectedIndex = 1;
                }
                else if (item.SubItems[2].Text == "Production units")
                {
                    cbbtyper.SelectedIndex = 2;
                }
                else
                {
                    cbbtyper.SelectedIndex = 3;
                }


                txtlast.Text = item.SubItems[3].Text.Replace("/m3", "").Trim();
                txtthis.Text = item.SubItems[4].Text.Replace("/m3", "").Trim();


                lv.Items.Remove(lv.SelectedItems[0]);
            }
        }

        private void btesc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to ESC",
                "confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to Reset",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                txtphone.Text = "";
                txtname.Text = "";
                txtlast.Text = "";
                txtthis.Text = "";
                cbbtyper.SelectedIndex = -1;
                lv.Items.Clear();
            }
        }

        private void btprint_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count > 0)
            {
                var item = lv.SelectedItems[0];
                string name = item.SubItems[0].Text;
                string phone = item.SubItems[1].Text;
                string tep = item.SubItems[2].Text;
                string cu = item.SubItems[3].Text;
                string moi = item.SubItems[4].Text;
                string tong = item.SubItems[5].Text;
                string tien = item.SubItems[6].Text;

                BillWater billForm = new BillWater(name, phone, tep, cu, moi, tong, tien);
                billForm.Show();
                ;
            }
            else
            {
                MessageBox.Show("Please select an item to view the bill",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}