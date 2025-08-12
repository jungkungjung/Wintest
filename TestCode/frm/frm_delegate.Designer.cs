namespace TestCode.frm
{
    partial class frm_delegate
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
            this.btn_delegate = new System.Windows.Forms.Button();
            this.bnt_function = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_delegate
            // 
            this.btn_delegate.Location = new System.Drawing.Point(23, 41);
            this.btn_delegate.Name = "btn_delegate";
            this.btn_delegate.Size = new System.Drawing.Size(190, 23);
            this.btn_delegate.TabIndex = 0;
            this.btn_delegate.Text = "เรียกใช้ delegate แบบ sub";
            this.btn_delegate.UseVisualStyleBackColor = true;
            this.btn_delegate.Click += new System.EventHandler(this.btn_delegate_Click);
            // 
            // bnt_function
            // 
            this.bnt_function.Location = new System.Drawing.Point(23, 70);
            this.bnt_function.Name = "bnt_function";
            this.bnt_function.Size = new System.Drawing.Size(190, 23);
            this.bnt_function.TabIndex = 0;
            this.bnt_function.Text = "เรียกใช้ delegate แบบ function";
            this.bnt_function.UseVisualStyleBackColor = true;
            this.bnt_function.Click += new System.EventHandler(this.bnt_function_Click);
            // 
            // frm_delegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_function);
            this.Controls.Add(this.btn_delegate);
            this.Name = "frm_delegate";
            this.Text = "frm_delegate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delegate;
        private System.Windows.Forms.Button bnt_function;
    }
}