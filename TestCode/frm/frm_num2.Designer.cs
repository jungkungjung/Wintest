namespace TestCode.frm
{
    partial class frm_num2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.tb_execute = new System.Windows.Forms.Button();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grw = new System.Windows.Forms.DataGridView();
            this.bt_showList = new System.Windows.Forms.Button();
            this.btn_returnList = new System.Windows.Forms.Button();
            this.btn_returnOnly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(28, 25);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(178, 20);
            this.tb_send.TabIndex = 1;
            this.tb_send.TextChanged += new System.EventHandler(this.tb_send_TextChanged);
            // 
            // tb_execute
            // 
            this.tb_execute.Location = new System.Drawing.Point(445, 23);
            this.tb_execute.Name = "tb_execute";
            this.tb_execute.Size = new System.Drawing.Size(76, 23);
            this.tb_execute.TabIndex = 2;
            this.tb_execute.Text = "execute";
            this.tb_execute.UseVisualStyleBackColor = true;
            this.tb_execute.Click += new System.EventHandler(this.tb_execute_Click);
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(261, 25);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(178, 20);
            this.tb_test.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "By Constructure";
            // 
            // grw
            // 
            this.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw.Location = new System.Drawing.Point(28, 94);
            this.grw.Name = "grw";
            this.grw.Size = new System.Drawing.Size(463, 289);
            this.grw.TabIndex = 5;
            // 
            // bt_showList
            // 
            this.bt_showList.Location = new System.Drawing.Point(28, 65);
            this.bt_showList.Name = "bt_showList";
            this.bt_showList.Size = new System.Drawing.Size(75, 23);
            this.bt_showList.TabIndex = 6;
            this.bt_showList.Text = "show List";
            this.bt_showList.UseVisualStyleBackColor = true;
            this.bt_showList.Click += new System.EventHandler(this.bt_showList_Click);
            // 
            // btn_returnList
            // 
            this.btn_returnList.Location = new System.Drawing.Point(125, 65);
            this.btn_returnList.Name = "btn_returnList";
            this.btn_returnList.Size = new System.Drawing.Size(75, 23);
            this.btn_returnList.TabIndex = 7;
            this.btn_returnList.Text = "return List";
            this.btn_returnList.UseVisualStyleBackColor = true;
            this.btn_returnList.Click += new System.EventHandler(this.btn_returnList_Click);
            // 
            // btn_returnOnly
            // 
            this.btn_returnOnly.Location = new System.Drawing.Point(220, 65);
            this.btn_returnOnly.Name = "btn_returnOnly";
            this.btn_returnOnly.Size = new System.Drawing.Size(153, 23);
            this.btn_returnOnly.TabIndex = 8;
            this.btn_returnOnly.Text = "return list only form2";
            this.btn_returnOnly.UseVisualStyleBackColor = true;
            this.btn_returnOnly.Click += new System.EventHandler(this.btn_returnOnly_Click);
            // 
            // frm_num2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_returnOnly);
            this.Controls.Add(this.btn_returnList);
            this.Controls.Add(this.bt_showList);
            this.Controls.Add(this.grw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.tb_execute);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.label1);
            this.Name = "frm_num2";
            this.Text = "frm_num2";
            this.Load += new System.EventHandler(this.frm_num2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button tb_execute;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grw;
        private System.Windows.Forms.Button bt_showList;
        private System.Windows.Forms.Button btn_returnList;
        private System.Windows.Forms.Button btn_returnOnly;
    }
}