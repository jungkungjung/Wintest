namespace TestCode.frm
{
    partial class frm_Barscanned
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
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.grw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dt = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grw)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(127, 21);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(62, 23);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "แสกนลบ";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(12, 23);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(100, 20);
            this.tb_barcode.TabIndex = 1;
            // 
            // grw
            // 
            this.grw.AllowUserToAddRows = false;
            this.grw.AllowUserToDeleteRows = false;
            this.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw.Location = new System.Drawing.Point(11, 49);
            this.grw.Name = "grw";
            this.grw.Size = new System.Drawing.Size(872, 442);
            this.grw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(777, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "สแกนออก";
            // 
            // btn_dt
            // 
            this.btn_dt.Location = new System.Drawing.Point(195, 21);
            this.btn_dt.Name = "btn_dt";
            this.btn_dt.Size = new System.Drawing.Size(133, 23);
            this.btn_dt.TabIndex = 4;
            this.btn_dt.Text = "return DT";
            this.btn_dt.UseVisualStyleBackColor = true;
            this.btn_dt.Click += new System.EventHandler(this.btn_dt_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(334, 21);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 23);
            this.bt_refresh.TabIndex = 11;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // frm_Barscanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 506);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.btn_dt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.grw);
            this.Name = "frm_Barscanned";
            this.Text = "frm_Barscanned";
            this.Load += new System.EventHandler(this.frm_Barscanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.DataGridView grw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dt;
        private System.Windows.Forms.Button bt_refresh;
    }
}