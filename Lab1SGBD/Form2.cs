using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1SGBD
{
	public partial class Form2 : Form
	{
		Form1 originalForm;
		public Form2(Form1 incomingForm)
		{
			originalForm = incomingForm;
			InitializeComponent();
		}
        public TextBox TextBox1
        {
            get
            {
                return textBox1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void UpDate_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            originalForm.text = textBox1.Text;
            this.Close();
        }

		private void label2_Click(object sender, EventArgs e)
		{
		}
	}
}


