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

namespace Lab9_Sem2
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files(*.txt)|*.txt|All(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            TextBox1.Text = sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string toProces = TextBox1.Text;
            char[] resultC = new char[toProces.Length];

            for(int i = 0; i < toProces.Length; i++)
            {
                char c = (char)((int)toProces[i] + 5);
                resultC[i] = c;
            }
            TextBox2.Text = new string(resultC);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using  ( SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files(*.txt)|*.txt|All(*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            sw.Write(TextBox2.Text);
                        }
                    }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string toProces = TextBox1.Text;
            char[] resultC = new char[toProces.Length];

            for (int i = 0; i < toProces.Length; i++)
            {
                char c = (char)((int)toProces[i] - 5);
                resultC[i] = c;
            }
            TextBox2.Text = new string(resultC);
        }
    }
}
