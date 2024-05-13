using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_FB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFatorial.Clear();
            txtNum.Clear();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double fat, num,i;
            num = Convert.ToDouble(txtNum.Text);
            i = num - 1;
            fat = num * i;
            txtFatorial.Text = string.Concat(txtFatorial.Text, "\r\n", fat.ToString());
            i--;

            for ( i = num - 2; i >0 ; i--){
                fat*=i ;
                txtFatorial.Text = string.Concat(txtFatorial.Text, "\r\n", fat.ToString());
                
            }
                

            
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double fat, num, i;
            num = Convert.ToDouble(txtNum.Text);
            i = num - 1;
            fat = num * i;
            txtFatorial.Text = string.Concat(txtFatorial.Text, "\r\n", fat.ToString());
            i--;

            while(i>0){
                i--;
                fat *= i;
                txtFatorial.Text = string.Concat(txtFatorial.Text, "\r\n", fat.ToString());

            }


        }
    }
}
