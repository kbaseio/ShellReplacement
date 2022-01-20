using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShellReplacement.Properties;
using System.Diagnostics;

namespace ShellReplacement
{
    public partial class FormMain : Form
    {
        String[] paths;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Settings.Default.WindowTitle;

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Font;


            if (!Settings.Default.Shutdown)
                button7.Visible = false;
            
            paths = new String[7];
            int i = 0;

            foreach (String s in Settings.Default.Applications)
            {
                paths[i] = s.Split('|')[1];

                if (s.Split('|')[2] == "true")
                    Execute(i);

                switch (i)
                {
                    case 0: button1.Text = s.Split('|')[0]; button1.Visible = true; break;
                    case 1: button2.Text = s.Split('|')[0]; button2.Visible = true; break;
                    case 2: button3.Text = s.Split('|')[0]; button3.Visible = true; break;
                    case 3: button4.Text = s.Split('|')[0]; button4.Visible = true; break;
                    case 4: button5.Text = s.Split('|')[0]; button5.Visible = true; break;
                }


                if(++i==5)
                    break;
            }
            paths[5] = "c:\\windows\\explorer.exe";
            paths[6] = "c:\\windows\\system32\\shutdown.exe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Execute(0);
        }

        private void Execute(int p)
        {
            try
            {
                if (p == 6)
                {
                    Process.Start(paths[p],"/s /f /t 0");
                }
                else
                Process.Start(paths[p]);
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Execute(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Execute(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Execute(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Execute(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Settings.Default.ExplorerPass.Length == 0)
            {
                Execute(5);
                Application.Exit();
            }
            else
            {
                FormPass z = new FormPass();
                z.ShowDialog();

                if (Settings.Default.ExplorerPass.CompareTo(z.pass) == 0)
                {
                    Execute(5);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Wrong password", Settings.Default.WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Execute(6);
        }
    }
}