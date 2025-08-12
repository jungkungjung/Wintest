namespace TestCode.frm
{
    partial class frm_List
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
            this.btn_addList1 = new System.Windows.Forms.Button();
            this.btn_addList2 = new System.Windows.Forms.Button();
            this.btn_addRang = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_listString = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_nestedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addList1
            // 
            this.btn_addList1.Location = new System.Drawing.Point(12, 12);
            this.btn_addList1.Name = "btn_addList1";
            this.btn_addList1.Size = new System.Drawing.Size(121, 23);
            this.btn_addList1.TabIndex = 1;
            this.btn_addList1.Text = "addList1";
            this.btn_addList1.UseVisualStyleBackColor = true;
            this.btn_addList1.Click += new System.EventHandler(this.btn_addList1_Click);
            // 
            // btn_addList2
            // 
            this.btn_addList2.Location = new System.Drawing.Point(12, 42);
            this.btn_addList2.Name = "btn_addList2";
            this.btn_addList2.Size = new System.Drawing.Size(121, 23);
            this.btn_addList2.TabIndex = 2;
            this.btn_addList2.Text = "addList2";
            this.btn_addList2.UseVisualStyleBackColor = true;
            this.btn_addList2.Click += new System.EventHandler(this.btn_addList2_Click);
            // 
            // btn_addRang
            // 
            this.btn_addRang.Location = new System.Drawing.Point(12, 72);
            this.btn_addRang.Name = "btn_addRang";
            this.btn_addRang.Size = new System.Drawing.Size(121, 23);
            this.btn_addRang.TabIndex = 3;
            this.btn_addRang.Text = "addRang";
            this.btn_addRang.UseVisualStyleBackColor = true;
            this.btn_addRang.Click += new System.EventHandler(this.btn_addRang_Click_1);
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(12, 102);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(121, 23);
            this.btn_assign.TabIndex = 4;
            this.btn_assign.Text = "asign";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // btn_listString
            // 
            this.btn_listString.Location = new System.Drawing.Point(171, 11);
            this.btn_listString.Name = "btn_listString";
            this.btn_listString.Size = new System.Drawing.Size(75, 23);
            this.btn_listString.TabIndex = 5;
            this.btn_listString.Text = "List string";
            this.btn_listString.UseVisualStyleBackColor = true;
            this.btn_listString.Click += new System.EventHandler(this.btn_listString_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(274, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_nestedList
            // 
            this.btn_nestedList.Location = new System.Drawing.Point(13, 132);
            this.btn_nestedList.Name = "btn_nestedList";
            this.btn_nestedList.Size = new System.Drawing.Size(120, 23);
            this.btn_nestedList.TabIndex = 12;
            this.btn_nestedList.Text = "Nested List Models";
            this.btn_nestedList.UseVisualStyleBackColor = true;
            this.btn_nestedList.Click += new System.EventHandler(this.btn_nestedList_Click);
            // 
            // frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nestedList);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_listString);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.btn_addRang);
            this.Controls.Add(this.btn_addList2);
            this.Controls.Add(this.btn_addList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_List";
            this.Text = "frm_List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addList1;
        private System.Windows.Forms.Button btn_addList2;
        private System.Windows.Forms.Button btn_addRang;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_listString;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_nestedList;
    }
}