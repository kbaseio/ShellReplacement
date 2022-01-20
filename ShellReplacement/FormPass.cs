using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShellReplacement
{
    public partial class FormPass : Form
    {
        public String pass = "";
        public FormPass()
        {
            InitializeComponent();
        }

        private void FormPass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pass = this.textBox1.Text;
            this.Close();
        }
    }
}