using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Laivay1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxlai.Items.Clear();
            double tienlai;
            double tien = double.Parse(txttien.Text);
            double laisuat = double.Parse(txtlai.Text.Replace("%",""))/100;
            int sonam = int.Parse(txtnam.Text);
            for (int i = 1 ; i<= sonam;i++)
            {
                tienlai = tien * laisuat;
                lbxlai.Items.Add($"{i}\t {tienlai:F2}\t {tienlai:F2}");
                tien += tienlai;
                
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txttien.ResetText();
            txtlai.ResetText();
            txtnam.ResetText();
            lbxlai.Items.Clear();
        }
    }
}
