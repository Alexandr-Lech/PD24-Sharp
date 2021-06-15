
namespace Lab9_Sem2
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox2.Location = new System.Drawing.Point(438, 54);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(305, 219);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox1.Location = new System.Drawing.Point(23, 54);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(305, 219);
            this.TextBox1.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(23, 296);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(106, 36);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Вибрати";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(151, 296);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(123, 36);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Зашифрувати";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(151, 338);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(123, 38);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Розшифрувати";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

