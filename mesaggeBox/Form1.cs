using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesaggeBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("tekst", "tekst", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(rez == DialogResult.Yes)
            {
                textBoxRezultat.AppendText("Stisnut je Yes" + Environment.NewLine);
            }
            if (rez == DialogResult.No)
            {
                textBoxRezultat.AppendText("Stisnut je No" + Environment.NewLine);
            }
            if (rez == DialogResult.Cancel)
            {
                textBoxRezultat.AppendText("Stisnut je Cancel" + Environment.NewLine);
            }
        }
    }
}
