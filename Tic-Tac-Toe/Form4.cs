using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO implement P vs CPU mode

            MessageBox.Show("yet not implemented");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
