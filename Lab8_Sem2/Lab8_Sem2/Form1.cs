using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Xml.Serialization;

namespace Lab8_Sem2
{
    public partial class Form1 : Form
    {

        public string Status { get; set; } = "Completed";

        public string AppName { get; set; } = "Lab_8";

        public Form1() => this.InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => this.LoadFromReg();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => this.SaveReg();

        private void SaveXml()
        {
            Save save = new Save(this.Location, this.Size, this.txtBox.Text, new bool[2]
            {
        this.chkBoxOne.Checked,
        this.chkBoxTwo.Checked
            });
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Save));
            if (!File.Exists("Save.xml"))
                File.Create("Save.xml");
            using (Stream stream = (Stream)File.Open("Save.xml", FileMode.Truncate, FileAccess.Write, FileShare.None))
                xmlSerializer.Serialize(stream, (object)save);
        }

        private void LoadFromXml()
        {
            using (Stream stream = (Stream)File.Open("Save.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Save save = (Save)new XmlSerializer(typeof(Save)).Deserialize(stream);
                this.Location = save.Position;
                this.Size = save.Size;
                this.txtBox.Text = save.TextBox;
                this.chkBoxOne.Checked = save.CheckBox[0];
                this.chkBoxTwo.Checked = save.CheckBox[1];
            }
        }

        private void SaveReg()
        {
            RegistryKey registryKey = (RegistryKey)null;
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(string.Format("Software\\{0}\\{1}\\", (object)this.Status, (object)this.AppName));
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            try
            {
                registryKey.SetValue("Pos_x", (object)this.Location.X, RegistryValueKind.DWord);
                registryKey.SetValue("Pos_y", (object)this.Location.Y, RegistryValueKind.DWord);
                registryKey.SetValue("Width", (object)this.Width, RegistryValueKind.DWord);
                registryKey.SetValue("Height", (object)this.Height, RegistryValueKind.DWord);
                registryKey.SetValue("Text", (object)this.txtBox.Text, RegistryValueKind.String);
                registryKey.SetValue("Check 1", (object)this.chkBoxOne.Checked.ToString(), RegistryValueKind.String);
                registryKey.SetValue("Check 2", (object)this.chkBoxTwo.Checked.ToString(), RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void LoadFromReg()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string.Format("Software\\{0}\\{1}\\", (object)this.Status, (object)this.AppName));
                this.Location = new Point((int)registryKey.GetValue("Pos_x"), (int)registryKey.GetValue("Pos_y"));
                this.Size = new Size((int)registryKey.GetValue("Width"), (int)registryKey.GetValue("Height"));
                this.txtBox.Text = (string)registryKey.GetValue("Text");
                this.chkBoxOne.Checked = bool.Parse((string)registryKey.GetValue("Check 1"));
                this.chkBoxTwo.Checked = bool.Parse((string)registryKey.GetValue("Check 2"));
            }
            catch (NullReferenceException ex)
            {
                int num = (int)MessageBox.Show("There is no saved data", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        
     

    }
}
