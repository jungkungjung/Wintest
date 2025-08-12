namespace TestCode.frm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_byref = new System.Windows.Forms.Button();
            this.btn_delegate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "openForm2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_byref
            // 
            this.btn_byref.Location = new System.Drawing.Point(88, 136);
            this.btn_byref.Name = "btn_byref";
            this.btn_byref.Size = new System.Drawing.Size(100, 23);
            this.btn_byref.TabIndex = 2;
            this.btn_byref.Text = "by ref";
            this.btn_byref.UseVisualStyleBackColor = true;
            this.btn_byref.Click += new System.EventHandler(this.btn_byref_Click);
            // 
            // btn_delegate
            // 
            this.btn_delegate.Location = new System.Drawing.Point(88, 166);
            this.btn_delegate.Name = "btn_delegate";
            this.btn_delegate.Size = new System.Drawing.Size(100, 23);
            this.btn_delegate.TabIndex = 3;
            this.btn_delegate.Text = "by delegate";
            this.btn_delegate.UseVisualStyleBackColor = true;
            this.btn_delegate.Click += new System.EventHandler(this.btn_delegate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delegate);
            this.Controls.Add(this.btn_byref);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_byref;
        private System.Windows.Forms.Button btn_delegate;
    }
}