using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            // 10. b
            if (txt.Text.Length == 14)
            {
                cbCharAmount.Checked = false;
            }
            else
            {
                cbCharAmount.Checked = true;
            }
            cbCharAmount.Text = $"Nem megfelelő a karakterek száma ({txt.Text.Length})";
            string hibasKarakterek = "";
            foreach (var ch in txt.Text)
            {
                if (ch != '1' && ch != '2' && ch != 'X')
                {
                    hibasKarakterek += ch + ";";
                }
            }
            cbInvChar.Text = $"Helytelen karakterek az eredményekben ({hibasKarakterek})";
            if (hibasKarakterek.Length == 0)
            {
                cbInvChar.Checked = false;
            }
            else
            {
                cbInvChar.Checked = true;
            }
        }

        private void cbInvChar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCharAmount.AutoCheck = false;
            cbInvChar.AutoCheck = false;
        }
    }
}
