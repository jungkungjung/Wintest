namespace TestCode.frm
{
    partial class frm_CrystalReport
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
            this.btn_printdialog = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_printEmpty = new System.Windows.Forms.Button();
            this.btn_printXsd = new System.Windows.Forms.Button();
            this.btn_passingReportDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_printdialog
            // 
            this.btn_printdialog.Location = new System.Drawing.Point(39, 31);
            this.btn_printdialog.Name = "btn_printdialog";
            this.btn_printdialog.Size = new System.Drawing.Size(190, 23);
            this.btn_printdialog.TabIndex = 0;
            this.btn_printdialog.Text = "Printer Dialog";
            this.btn_printdialog.UseVisualStyleBackColor = true;
            this.btn_printdialog.Click += new System.EventHandler(this.btn_printdialog_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(39, 61);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(190, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print Rpt";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_printEmpty
            // 
            this.btn_printEmpty.Location = new System.Drawing.Point(280, 31);
            this.btn_printEmpty.Name = "btn_printEmpty";
            this.btn_printEmpty.Size = new System.Drawing.Size(135, 23);
            this.btn_printEmpty.TabIndex = 2;
            this.btn_printEmpty.Text = "Print empty Rpt";
            this.btn_printEmpty.UseVisualStyleBackColor = true;
            this.btn_printEmpty.Click += new System.EventHandler(this.btn_printEmpty_Click);
            // 
            // btn_printXsd
            // 
            this.btn_printXsd.Location = new System.Drawing.Point(39, 91);
            this.btn_printXsd.Name = "btn_printXsd";
            this.btn_printXsd.Size = new System.Drawing.Size(190, 23);
            this.btn_printXsd.TabIndex = 3;
            this.btn_printXsd.Text = "Print from xsd";
            this.btn_printXsd.UseVisualStyleBackColor = true;
            this.btn_printXsd.Click += new System.EventHandler(this.btn_printXsd_Click);
            // 
            // btn_passingReportDocument
            // 
            this.btn_passingReportDocument.Location = new System.Drawing.Point(39, 121);
            this.btn_passingReportDocument.Name = "btn_passingReportDocument";
            this.btn_passingReportDocument.Size = new System.Drawing.Size(190, 23);
            this.btn_passingReportDocument.TabIndex = 4;
            this.btn_passingReportDocument.Text = "Print passing reportDocument";
            this.btn_passingReportDocument.UseVisualStyleBackColor = true;
            this.btn_passingReportDocument.Click += new System.EventHandler(this.btn_passingReportDocument_Click);
            // 
            // frm_CrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_passingReportDocument);
            this.Controls.Add(this.btn_printXsd);
            this.Controls.Add(this.btn_printEmpty);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_printdialog);
            this.Name = "frm_CrystalReport";
            this.Text = "frm_CrystalReport";
            this.Load += new System.EventHandler(this.frm_CrystalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_printdialog;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_printEmpty;
        private System.Windows.Forms.Button btn_printXsd;
        private System.Windows.Forms.Button btn_passingReportDocument;
    }
}