namespace Postro2
{
    partial class frmAdvanced
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.lnkDump = new System.Windows.Forms.LinkLabel();
            this.btnDump = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optAboveZero = new System.Windows.Forms.RadioButton();
            this.optFullList = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkDelete);
            this.groupBox1.Controls.Add(this.lnkDump);
            this.groupBox1.Controls.Add(this.btnDump);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDelete.Location = new System.Drawing.Point(102, 190);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(94, 21);
            this.lnkDelete.TabIndex = 3;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "What\'s this?";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // lnkDump
            // 
            this.lnkDump.AutoSize = true;
            this.lnkDump.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDump.Location = new System.Drawing.Point(102, 98);
            this.lnkDump.Name = "lnkDump";
            this.lnkDump.Size = new System.Drawing.Size(94, 21);
            this.lnkDump.TabIndex = 2;
            this.lnkDump.TabStop = true;
            this.lnkDump.Text = "What\'s this?";
            this.lnkDump.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDump_LinkClicked);
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(51, 49);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(194, 46);
            this.btnDump.TabIndex = 1;
            this.btnDump.Text = "Dump Database";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(51, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Database";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optAboveZero);
            this.groupBox2.Controls.Add(this.optFullList);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // optAboveZero
            // 
            this.optAboveZero.AutoSize = true;
            this.optAboveZero.Checked = true;
            this.optAboveZero.Location = new System.Drawing.Point(20, 67);
            this.optAboveZero.Name = "optAboveZero";
            this.optAboveZero.Size = new System.Drawing.Size(239, 29);
            this.optAboveZero.TabIndex = 2;
            this.optAboveZero.TabStop = true;
            this.optAboveZero.Text = "List of counts above zero";
            this.optAboveZero.UseVisualStyleBackColor = true;
            // 
            // optFullList
            // 
            this.optFullList.AutoSize = true;
            this.optFullList.Location = new System.Drawing.Point(20, 32);
            this.optFullList.Name = "optFullList";
            this.optFullList.Size = new System.Drawing.Size(93, 29);
            this.optFullList.TabIndex = 1;
            this.optFullList.Text = "Full List";
            this.optFullList.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(51, 113);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(194, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate List";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmAdvanced";
            this.Text = "Advanced";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optAboveZero;
        private System.Windows.Forms.RadioButton optFullList;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.LinkLabel lnkDump;
        private System.Windows.Forms.Button btnDump;
    }
}