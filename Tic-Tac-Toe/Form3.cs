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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        //polymorphic method for moving the form

        int turn = 1;

        public void victory(object sender, EventArgs e)
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show(button1.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show(button4.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    MessageBox.Show(button7.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show(button1.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    MessageBox.Show(button2.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show(button3.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show(button1.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
            if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show(button3.Text + " a castigat!");
                    Form3_Load(sender, e);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.BackColor = Control.DefaultBackColor;
            button2.Text = "";
            button2.BackColor = Control.DefaultBackColor;
            button3.Text = "";
            button3.BackColor = Control.DefaultBackColor;
            button4.Text = "";
            button4.BackColor = Control.DefaultBackColor;
            button5.Text = "";
            button5.BackColor = Control.DefaultBackColor;
            button6.Text = "";
            button6.BackColor = Control.DefaultBackColor;
            button7.Text = "";
            button7.BackColor = Control.DefaultBackColor;
            button8.Text = "";
            button8.BackColor = Control.DefaultBackColor;
            button9.Text = "";
            button9.BackColor = Control.DefaultBackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button1.Text = "O";
                    button1.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button1.Text = "X";
                    button1.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button2.Text = "O";
                    button2.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button2.Text = "X";
                    button2.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button3.Text = "O";
                    button3.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button3.Text = "X";
                    button3.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button4.Text = "O";
                    button4.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button4.Text = "X";
                    button4.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button5.Text = "O";
                    button5.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button5.Text = "X";
                    button5.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button6.Text = "O";
                    button6.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button6.Text = "X";
                    button6.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button7.Text = "O";
                    button7.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button7.Text = "X";
                    button7.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button8.Text = "O";
                    button8.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button8.Text = "X";
                    button8.BackColor = Color.Crimson;
                    turn++;
                }
            }
            victory(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (turn % 2 == 0) //PT 0
                {
                    button9.Text = "O";
                    button9.BackColor = Color.Cyan;
                    turn++;
                }
                else if (turn % 2 != 0) // PT X
                {
                    button9.Text = "X";
                    button9.BackColor = Color.Crimson;
                    turn++;
                }

            }
            victory(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
