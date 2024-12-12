using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace المحاضرة_الرابعة
{
    public partial class Form4 : Form
    {
        int[] a;
        int m = 0,i=0;

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender == txtavg||sender==txtnumstd)
            {
                if ((e.KeyChar<48||e.KeyChar>57)&&(e.KeyChar!=8))
                    e.Handled = true;
            }
            if(sender==textname)
            {
                if ((e.KeyChar < 65 || e.KeyChar > 122) && (e.KeyChar != 8))
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textname.Text.Trim() != "" && txtavg.Text.Trim() != "")
            {
                if (i < m)
                {
                    listBox1.Items.Add(textname.Text + "\t" + txtavg.Text);
                    a[i++] = int.Parse(txtavg.Text);
                    textname.Text = txtavg.Text = "";
                    txtavg.Focus();
                    textname.Focus();
                }
                else
                    MessageBox.Show("لقد تجاوزت حد المصفوفة");

            }
            else
                MessageBox.Show("خطاء في مربع النص");
        }

        private void txtnumstd_TextChanged(object sender, EventArgs e)
        {
            txtavg.Enabled = textname.Enabled = button1.Enabled =
               listBox1.Enabled = button2.Enabled = txtnumstd.Text.Trim() != "";

        }

        private void txtnumstd_Leave(object sender, EventArgs e)
        {
            if (txtnumstd.Text.Trim() != "")
            {
                m = int.Parse(txtnumstd.Text);
                a = new int[m]; i = 0;

            }
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = listBox1.Items.Count, temp = a[0]; string st = "";
            if (b > 0)
            {
                for (int k = 0; k < i; k++)
                {
                    for (int j = k + 1; j < i; j++)
                    {
                        // if (a[k] < a[j])                        //ترتيب تنازلي 
                        if (a[k] > a[j])                        // ترتيب تصاعدي 

                        {
                            temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            st = listBox1.Items[k].ToString();
                            listBox1.Items[k] = listBox1.Items[j].ToString();
                            listBox1.Items[j] = st.ToString();
                        }
                    }

                }
            }
            else
                MessageBox.Show("  القائمة فارغة ");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtavg.Enabled = textname.Enabled = button1.Enabled =
            listBox1.Enabled = button2.Enabled = false;
            txtavg.KeyPress += textname_KeyPress;
            txtnumstd.KeyPress += textname_KeyPress;
        }
    }
}
