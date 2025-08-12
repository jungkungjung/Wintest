namespace TestCode
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mn_passingform = new System.Windows.Forms.Button();
            this.mn_delegate = new System.Windows.Forms.Button();
            this.mn_interface = new System.Windows.Forms.Button();
            this.mn_structure = new System.Windows.Forms.Button();
            this.ts_test = new System.Windows.Forms.ToolStripButton();
            this.ts_barcode = new System.Windows.Forms.ToolStripButton();
            this.ts_list = new System.Windows.Forms.ToolStripButton();
            this.btn_CrystalConstructure = new System.Windows.Forms.Button();
            this.btn_generic = new System.Windows.Forms.Button();
            this.ts_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_test,
            this.ts_barcode,
            this.ts_list});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(806, 38);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_generic);
            this.panel1.Controls.Add(this.btn_CrystalConstructure);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mn_passingform);
            this.panel1.Controls.Add(this.mn_delegate);
            this.panel1.Controls.Add(this.mn_interface);
            this.panel1.Controls.Add(this.mn_structure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 450);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crystal Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mn_passingform
            // 
            this.mn_passingform.Dock = System.Windows.Forms.DockStyle.Top;
            this.mn_passingform.Location = new System.Drawing.Point(0, 69);
            this.mn_passingform.Name = "mn_passingform";
            this.mn_passingform.Size = new System.Drawing.Size(122, 23);
            this.mn_passingform.TabIndex = 3;
            this.mn_passingform.Text = "passing form";
            this.mn_passingform.UseVisualStyleBackColor = true;
            this.mn_passingform.Click += new System.EventHandler(this.mn_passingform_Click);
            // 
            // mn_delegate
            // 
            this.mn_delegate.Dock = System.Windows.Forms.DockStyle.Top;
            this.mn_delegate.Location = new System.Drawing.Point(0, 46);
            this.mn_delegate.Name = "mn_delegate";
            this.mn_delegate.Size = new System.Drawing.Size(122, 23);
            this.mn_delegate.TabIndex = 2;
            this.mn_delegate.Text = "delegate";
            this.mn_delegate.UseVisualStyleBackColor = true;
            this.mn_delegate.Click += new System.EventHandler(this.mn_delegate_Click);
            // 
            // mn_interface
            // 
            this.mn_interface.Dock = System.Windows.Forms.DockStyle.Top;
            this.mn_interface.Location = new System.Drawing.Point(0, 23);
            this.mn_interface.Name = "mn_interface";
            this.mn_interface.Size = new System.Drawing.Size(122, 23);
            this.mn_interface.TabIndex = 1;
            this.mn_interface.Text = "interface";
            this.mn_interface.UseVisualStyleBackColor = true;
            this.mn_interface.Click += new System.EventHandler(this.mn_interface_Click);
            // 
            // mn_structure
            // 
            this.mn_structure.Dock = System.Windows.Forms.DockStyle.Top;
            this.mn_structure.Location = new System.Drawing.Point(0, 0);
            this.mn_structure.Name = "mn_structure";
            this.mn_structure.Size = new System.Drawing.Size(122, 23);
            this.mn_structure.TabIndex = 0;
            this.mn_structure.Text = "structure";
            this.mn_structure.UseVisualStyleBackColor = true;
            this.mn_structure.Click += new System.EventHandler(this.mn_structure_Click);
            // 
            // ts_test
            // 
            this.ts_test.Image = ((System.Drawing.Image)(resources.GetObject("ts_test.Image")));
            this.ts_test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_test.Name = "ts_test";
            this.ts_test.Size = new System.Drawing.Size(30, 35);
            this.ts_test.Text = "test";
            this.ts_test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_test.Click += new System.EventHandler(this.ts_test_Click);
            // 
            // ts_barcode
            // 
            this.ts_barcode.Image = ((System.Drawing.Image)(resources.GetObject("ts_barcode.Image")));
            this.ts_barcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_barcode.Name = "ts_barcode";
            this.ts_barcode.Size = new System.Drawing.Size(81, 35);
            this.ts_barcode.Text = "scan barcode";
            this.ts_barcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_barcode.Click += new System.EventHandler(this.ts_barcode_Click);
            // 
            // ts_list
            // 
            this.ts_list.Image = ((System.Drawing.Image)(resources.GetObject("ts_list.Image")));
            this.ts_list.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_list.Name = "ts_list";
            this.ts_list.Size = new System.Drawing.Size(59, 35);
            this.ts_list.Text = "List Class";
            this.ts_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_list.Click += new System.EventHandler(this.ts_list_Click);
            // 
            // btn_CrystalConstructure
            // 
            this.btn_CrystalConstructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CrystalConstructure.Location = new System.Drawing.Point(0, 115);
            this.btn_CrystalConstructure.Name = "btn_CrystalConstructure";
            this.btn_CrystalConstructure.Size = new System.Drawing.Size(122, 23);
            this.btn_CrystalConstructure.TabIndex = 5;
            this.btn_CrystalConstructure.Text = "Crystal report Passing";
            this.btn_CrystalConstructure.UseVisualStyleBackColor = true;
            this.btn_CrystalConstructure.Click += new System.EventHandler(this.btn_CrystalConstructure_Click);
            // 
            // btn_generic
            // 
            this.btn_generic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_generic.Location = new System.Drawing.Point(0, 138);
            this.btn_generic.Name = "btn_generic";
            this.btn_generic.Size = new System.Drawing.Size(122, 23);
            this.btn_generic.TabIndex = 6;
            this.btn_generic.Text = "Generic";
            this.btn_generic.UseVisualStyleBackColor = true;
            this.btn_generic.Click += new System.EventHandler(this.btn_generic_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ts_main);
            this.IsMdiContainer = true;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.Text = "mainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton ts_barcode;
        private System.Windows.Forms.ToolStripButton ts_test;
        private System.Windows.Forms.ToolStripButton ts_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mn_structure;
        private System.Windows.Forms.Button mn_interface;
        private System.Windows.Forms.Button mn_delegate;
        private System.Windows.Forms.Button mn_passingform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CrystalConstructure;
        private System.Windows.Forms.Button btn_generic;
    }
}