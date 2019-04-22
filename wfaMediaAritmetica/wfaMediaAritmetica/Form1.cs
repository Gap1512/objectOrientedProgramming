using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMediaAritmetica
{
    public partial class formMedia : Form
    {
        public formMedia()
        {
            InitializeComponent();
        }

        private void btOk_MouseClick(object sender, MouseEventArgs e)
        {
            double n1, n2;

            n1 = Convert.ToDouble(tbNumero1.Text);
            n2 = Convert.ToDouble(tbNumero2.Text);

            tbMedia.Text = Convert.ToString(((n1 + n2) / 2));
        }
    }
}
