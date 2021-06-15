using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8_Sem2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.chkBoxOne = new System.Windows.Forms.CheckBox();
            this.chkBoxTwo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(202, 27);
            this.txtBox.TabIndex = 0;
            // 
            // chkBoxOne
            // 
            this.chkBoxOne.AutoSize = true;
            this.chkBoxOne.Location = new System.Drawing.Point(12, 40);
            this.chkBoxOne.Name = "chkBoxOne";
            this.chkBoxOne.Size = new System.Drawing.Size(98, 21);
            this.chkBoxOne.TabIndex = 1;
            this.chkBoxOne.Text = "checkBox1";
            this.chkBoxOne.UseVisualStyleBackColor = true;
            // 
            // chkBoxTwo
            // 
            this.chkBoxTwo.AutoSize = true;
            this.chkBoxTwo.Location = new System.Drawing.Point(116, 40);
            this.chkBoxTwo.Name = "chkBoxTwo";
            this.chkBoxTwo.Size = new System.Drawing.Size(98, 21);
            this.chkBoxTwo.TabIndex = 2;
            this.chkBoxTwo.Text = "checkBox2";
            this.chkBoxTwo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 137);
            this.Controls.Add(this.chkBoxTwo);
            this.Controls.Add(this.chkBoxOne);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.CheckBox chkBoxOne;
        private System.Windows.Forms.CheckBox chkBoxTwo;
    }
}

