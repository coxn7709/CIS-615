using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        bool clear_once = false;
        int remaining;

        public Form1()
        {
            InitializeComponent();
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txtbx_search.Clear();
            txtbx_search.Text = "Course Search...";

            Form2 popup = new Form2();

            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            popup.Dispose();
        }

        private void txtbx_search_TextChanged(object sender, EventArgs e)
        {
            if (clear_once == false)
            {
                BeginInvoke((Action)delegate
                {
                    txtbx_search.SelectAll();
                    clear_once = true;
                });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_total_completed_TextChanged(object sender, EventArgs e)
        {
            int outParse;

            // Check if the point entered is numeric or not
            if (Int32.TryParse(txtbx_total_completed.Text, out outParse))
            {
                Console.WriteLine("Only numbers");
                txtbx_total_completed.BackColor = Color.White;
                remaining = 34 - outParse;
                txtbx_finished_degree.Text = remaining.ToString();
                if (remaining <= 0)
                {
                    txtbx_finished_degree.Text = "0";
                    txtbx_finished_degree.BackColor = Color.Green;
                }
                else
                {
                    txtbx_finished_degree.Text = remaining.ToString();
                    txtbx_finished_degree.BackColor = Color.Yellow;
                }
            }
            else
            {
                Console.WriteLine("not all numbers");
                txtbx_total_completed.BackColor = Color.Red;
            }
        }

        private void txtbx_finished_degree_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
