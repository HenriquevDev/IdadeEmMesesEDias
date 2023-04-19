using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdadeEmMesesEDias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int anos, totalMeses, totalDias;

            if (int.TryParse(txtAnos.Text, out anos))
            {
                totalMeses = anos * 12;
                totalDias = anos * 365;

                txtMeses.Text = totalMeses.ToString();
                txtDias.Text = totalDias.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, digite apenas números inteiros no campo de idade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
