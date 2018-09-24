using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTUGAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtNilaiA.Text);
            int B = Convert.ToInt32(txtNilaiB.Text);

            switch (CO.SelectedIndex)
            {
                case 0:
                    txtHasil.Text = Convert.ToString(A + B);
                    break;
                case 1:
                    txtHasil.Text = Convert.ToString(A - B);
                    break;
                case 2:
                    txtHasil.Text = Convert.ToString(A * B);
                    break;
                case 3:
                    txtHasil.Text = Convert.ToString(A / B);
                    break;
            }
        }
    }
}
