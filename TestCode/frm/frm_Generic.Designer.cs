namespace TestCode.frm
{
    partial class frm_Generic
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
            this.grw = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_generic1 = new System.Windows.Forms.Button();
            this.btn_listGeneric = new System.Windows.Forms.Button();
            this.btn_generic2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grw)).BeginInit();
            this.SuspendLayout();
            // 
            // grw
            // 
            this.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw.Location = new System.Drawing.Point(12, 12);
            this.grw.Name = "grw";
            this.grw.Size = new System.Drawing.Size(776, 370);
            this.grw.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 388);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_generic1
            // 
            this.btn_generic1.Location = new System.Drawing.Point(111, 387);
            this.btn_generic1.Name = "btn_generic1";
            this.btn_generic1.Size = new System.Drawing.Size(75, 23);
            this.btn_generic1.TabIndex = 2;
            this.btn_generic1.Text = "Generic 1";
            this.btn_generic1.UseVisualStyleBackColor = true;
            this.btn_generic1.Click += new System.EventHandler(this.btn_generic1_Click);
            // 
            // btn_listGeneric
            // 
            this.btn_listGeneric.Location = new System.Drawing.Point(306, 387);
            this.btn_listGeneric.Name = "btn_listGeneric";
            this.btn_listGeneric.Size = new System.Drawing.Size(81, 23);
            this.btn_listGeneric.TabIndex = 3;
            this.btn_listGeneric.Text = "List Generic";
            this.btn_listGeneric.UseVisualStyleBackColor = true;
            this.btn_listGeneric.Click += new System.EventHandler(this.btn_listGeneric_Click);
            // 
            // btn_generic2
            // 
            this.btn_generic2.Location = new System.Drawing.Point(192, 387);
            this.btn_generic2.Name = "btn_generic2";
            this.btn_generic2.Size = new System.Drawing.Size(75, 23);
            this.btn_generic2.TabIndex = 4;
            this.btn_generic2.Text = "Generic 2";
            this.btn_generic2.UseVisualStyleBackColor = true;
            this.btn_generic2.Click += new System.EventHandler(this.btn_generic2_Click);
            // 
            // frm_Generic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generic2);
            this.Controls.Add(this.btn_listGeneric);
            this.Controls.Add(this.btn_generic1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grw);
            this.Name = "frm_Generic";
            this.Text = "frm_Generic";
            ((System.ComponentModel.ISupportInitialize)(this.grw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grw;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_generic1;
        private System.Windows.Forms.Button btn_listGeneric;
        private System.Windows.Forms.Button btn_generic2;
    }
}