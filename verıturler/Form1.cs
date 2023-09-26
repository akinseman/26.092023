using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verıturler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(txtsayı.Text);
            int sonnuc =sayı *sayı;

            lblsonuc.Text = ToString();

        }
    }
}
