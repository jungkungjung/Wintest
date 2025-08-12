namespace TestCode.frm
{
    partial class frm_barcode
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
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_dt = new System.Windows.Forms.Button();
            this.btn_getData = new System.Windows.Forms.Button();
            this.lnk_dt = new System.Windows.Forms.LinkLabel();
            this.btn_chkSuccess = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grw)).BeginInit();
            this.SuspendLayout();
            // 
            // grw
            // 
            this.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw.Location = new System.Drawing.Point(12, 87);
            this.grw.Name = "grw";
            this.grw.Size = new System.Drawing.Size(872, 442);
            this.grw.TabIndex = 0;
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(13, 61);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(100, 20);
            this.tb_barcode.TabIndex = 1;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(809, 7);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 2;
            this.btn_execute.Text = "execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(783, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "scar barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "scanbar แล้วหา itemcode ใส่จำนวนลดทีละ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ถ้าจำนวนเหลือ 0 ให้ remove row";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(128, 59);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(62, 23);
            this.btn_find.TabIndex = 6;
            this.btn_find.Text = "แสกนลบ";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_dt
            // 
            this.btn_dt.Location = new System.Drawing.Point(196, 59);
            this.btn_dt.Name = "btn_dt";
            this.btn_dt.Size = new System.Drawing.Size(133, 23);
            this.btn_dt.TabIndex = 7;
            this.btn_dt.Text = "สร้าง datatable เปิดหน้าต่างใหม่";
            this.btn_dt.UseVisualStyleBackColor = true;
            this.btn_dt.Click += new System.EventHandler(this.btn_dt_Click);
            // 
            // btn_getData
            // 
            this.btn_getData.Location = new System.Drawing.Point(12, 33);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(101, 23);
            this.btn_getData.TabIndex = 8;
            this.btn_getData.Text = "Getdata";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // lnk_dt
            // 
            this.lnk_dt.AutoSize = true;
            this.lnk_dt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnk_dt.LinkColor = System.Drawing.Color.Navy;
            this.lnk_dt.Location = new System.Drawing.Point(349, 64);
            this.lnk_dt.Name = "lnk_dt";
            this.lnk_dt.Size = new System.Drawing.Size(56, 13);
            this.lnk_dt.TabIndex = 9;
            this.lnk_dt.TabStop = true;
            this.lnk_dt.Text = "Check DT";
            this.lnk_dt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_dt_LinkClicked);
            // 
            // btn_chkSuccess
            // 
            this.btn_chkSuccess.Location = new System.Drawing.Point(425, 58);
            this.btn_chkSuccess.Name = "btn_chkSuccess";
            this.btn_chkSuccess.Size = new System.Drawing.Size(115, 23);
            this.btn_chkSuccess.TabIndex = 10;
            this.btn_chkSuccess.Text = "check success";
            this.btn_chkSuccess.UseVisualStyleBackColor = true;
            this.btn_chkSuccess.Click += new System.EventHandler(this.btn_chkSuccess_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(809, 35);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 541);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_chkSuccess);
            this.Controls.Add(this.lnk_dt);
            this.Controls.Add(this.btn_getData);
            this.Controls.Add(this.btn_dt);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.grw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_barcode";
            this.Text = "frm_barcode";
            this.Load += new System.EventHandler(this.frm_barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grw;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_dt;
        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.LinkLabel lnk_dt;
        private System.Windows.Forms.Button btn_chkSuccess;
        private System.Windows.Forms.Button btn_close;
    }
}