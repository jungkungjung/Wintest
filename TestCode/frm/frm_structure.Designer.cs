namespace TestCode.frm
{
    partial class frm_structure
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
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_method = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(51, 40);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(137, 23);
            this.btn_result.TabIndex = 0;
            this.btn_result.Text = "ตัวอย่างการใช้ structure";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_method
            // 
            this.btn_method.Location = new System.Drawing.Point(51, 70);
            this.btn_method.Name = "btn_method";
            this.btn_method.Size = new System.Drawing.Size(137, 23);
            this.btn_method.TabIndex = 1;
            this.btn_method.Text = "ใช้ Method ใน structure";
            this.btn_method.UseVisualStyleBackColor = true;
            this.btn_method.Click += new System.EventHandler(this.btn_method_Click);
            // 
            // frm_structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_method);
            this.Controls.Add(this.btn_result);
            this.Name = "frm_structure";
            this.Text = "frm_structure";
            this.Load += new System.EventHandler(this.frm_structure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_method;
    }
}