namespace TestCode
{
    partial class frm_test
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
            this.bt_paraOut = new System.Windows.Forms.Button();
            this.bt_paramRef = new System.Windows.Forms.Button();
            this.bt_dictionary = new System.Windows.Forms.Button();
            this.bt_interface = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.grw = new System.Windows.Forms.DataGridView();
            this.btn_cal = new System.Windows.Forms.Button();
            this.grw2 = new System.Windows.Forms.DataGridView();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_stream = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_datetime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grw2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_paraOut
            // 
            this.bt_paraOut.Location = new System.Drawing.Point(24, 24);
            this.bt_paraOut.Name = "bt_paraOut";
            this.bt_paraOut.Size = new System.Drawing.Size(123, 23);
            this.bt_paraOut.TabIndex = 0;
            this.bt_paraOut.Text = "parameter out";
            this.bt_paraOut.UseVisualStyleBackColor = true;
            this.bt_paraOut.Click += new System.EventHandler(this.bt_paraOut_Click);
            // 
            // bt_paramRef
            // 
            this.bt_paramRef.Location = new System.Drawing.Point(24, 53);
            this.bt_paramRef.Name = "bt_paramRef";
            this.bt_paramRef.Size = new System.Drawing.Size(123, 23);
            this.bt_paramRef.TabIndex = 0;
            this.bt_paramRef.Text = "parameter ref";
            this.bt_paramRef.UseVisualStyleBackColor = true;
            this.bt_paramRef.Click += new System.EventHandler(this.bt_paramRef_Click);
            // 
            // bt_dictionary
            // 
            this.bt_dictionary.Location = new System.Drawing.Point(24, 81);
            this.bt_dictionary.Name = "bt_dictionary";
            this.bt_dictionary.Size = new System.Drawing.Size(123, 23);
            this.bt_dictionary.TabIndex = 1;
            this.bt_dictionary.Text = "Dictionary";
            this.bt_dictionary.UseVisualStyleBackColor = true;
            this.bt_dictionary.Click += new System.EventHandler(this.bt_dictionary_Click);
            // 
            // bt_interface
            // 
            this.bt_interface.Location = new System.Drawing.Point(24, 109);
            this.bt_interface.Name = "bt_interface";
            this.bt_interface.Size = new System.Drawing.Size(123, 23);
            this.bt_interface.TabIndex = 2;
            this.bt_interface.Text = "Interface";
            this.bt_interface.UseVisualStyleBackColor = true;
            this.bt_interface.Click += new System.EventHandler(this.bt_interface_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Location = new System.Drawing.Point(892, 223);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(75, 23);
            this.btn_invoice.TabIndex = 3;
            this.btn_invoice.Text = "get Invoice";
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // grw
            // 
            this.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw.Location = new System.Drawing.Point(159, 24);
            this.grw.Name = "grw";
            this.grw.Size = new System.Drawing.Size(808, 193);
            this.grw.TabIndex = 4;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(892, 451);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 3;
            this.btn_cal.Text = "calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // grw2
            // 
            this.grw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw2.Location = new System.Drawing.Point(159, 252);
            this.grw2.Name = "grw2";
            this.grw2.Size = new System.Drawing.Size(808, 193);
            this.grw2.TabIndex = 4;
            // 
            // btn_decimal
            // 
            this.btn_decimal.Location = new System.Drawing.Point(159, 450);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(75, 23);
            this.btn_decimal.TabIndex = 5;
            this.btn_decimal.Text = "sum Decimal";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(149, 489);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(104, 20);
            this.tb_barcode.TabIndex = 6;
            this.tb_barcode.TabStop = false;
            this.tb_barcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_barcode_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "กด tab เพื่อเก็บข้อมูลไว้ใน list";
            // 
            // btn_stream
            // 
            this.btn_stream.Location = new System.Drawing.Point(259, 487);
            this.btn_stream.Name = "btn_stream";
            this.btn_stream.Size = new System.Drawing.Size(104, 23);
            this.btn_stream.TabIndex = 9;
            this.btn_stream.Text = "streamwriter";
            this.btn_stream.UseVisualStyleBackColor = true;
            this.btn_stream.Click += new System.EventHandler(this.btn_stream_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(973, 24);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // btn_datetime
            // 
            this.btn_datetime.Location = new System.Drawing.Point(24, 139);
            this.btn_datetime.Name = "btn_datetime";
            this.btn_datetime.Size = new System.Drawing.Size(123, 23);
            this.btn_datetime.TabIndex = 11;
            this.btn_datetime.Text = "datetime";
            this.btn_datetime.UseVisualStyleBackColor = true;
            this.btn_datetime.Click += new System.EventHandler(this.btn_datetime_Click);
            // 
            // frm_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 599);
            this.Controls.Add(this.btn_datetime);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_stream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.btn_decimal);
            this.Controls.Add(this.grw2);
            this.Controls.Add(this.grw);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.bt_interface);
            this.Controls.Add(this.bt_dictionary);
            this.Controls.Add(this.bt_paramRef);
            this.Controls.Add(this.bt_paraOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_test";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grw2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_paraOut;
        private System.Windows.Forms.Button bt_paramRef;
        private System.Windows.Forms.Button bt_dictionary;
        private System.Windows.Forms.Button bt_interface;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.DataGridView grw;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.DataGridView grw2;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_stream;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_datetime;
    }
}

