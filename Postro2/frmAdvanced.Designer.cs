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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbInclude = new System.Windows.Forms.GroupBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkHolds = new System.Windows.Forms.CheckBox();
            this.chkCondition = new System.Windows.Forms.CheckBox();
            this.chkCount = new System.Windows.Forms.CheckBox();
            this.chkTitle = new System.Windows.Forms.CheckBox();
            this.optAboveZero = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.optFullList = new System.Windows.Forms.RadioButton();
            this.lnkConsole = new System.Windows.Forms.LinkLabel();
            this.chkPrice = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbInclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkDelete);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDelete.Location = new System.Drawing.Point(218, 94);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(94, 21);
            this.lnkDelete.TabIndex = 3;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "What\'s this?";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Database";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbInclude);
            this.groupBox2.Controls.Add(this.optAboveZero);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.optFullList);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // gbInclude
            // 
            this.gbInclude.Controls.Add(this.chkPrice);
            this.gbInclude.Controls.Add(this.chkID);
            this.gbInclude.Controls.Add(this.chkHolds);
            this.gbInclude.Controls.Add(this.chkCondition);
            this.gbInclude.Controls.Add(this.chkCount);
            this.gbInclude.Controls.Add(this.chkTitle);
            this.gbInclude.Location = new System.Drawing.Point(20, 32);
            this.gbInclude.Name = "gbInclude";
            this.gbInclude.Size = new System.Drawing.Size(487, 129);
            this.gbInclude.TabIndex = 3;
            this.gbInclude.TabStop = false;
            this.gbInclude.Text = "Include";
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(397, 44);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(49, 29);
            this.chkID.TabIndex = 2;
            this.chkID.Text = "ID";
            this.chkID.UseVisualStyleBackColor = true;
            // 
            // chkHolds
            // 
            this.chkHolds.AutoSize = true;
            this.chkHolds.Checked = true;
            this.chkHolds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHolds.Location = new System.Drawing.Point(209, 75);
            this.chkHolds.Name = "chkHolds";
            this.chkHolds.Size = new System.Drawing.Size(79, 29);
            this.chkHolds.TabIndex = 2;
            this.chkHolds.Text = "Holds";
            this.chkHolds.UseVisualStyleBackColor = true;
            // 
            // chkCondition
            // 
            this.chkCondition.AutoSize = true;
            this.chkCondition.Checked = true;
            this.chkCondition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCondition.Location = new System.Drawing.Point(209, 44);
            this.chkCondition.Name = "chkCondition";
            this.chkCondition.Size = new System.Drawing.Size(114, 29);
            this.chkCondition.TabIndex = 2;
            this.chkCondition.Text = "Condition";
            this.chkCondition.UseVisualStyleBackColor = true;
            // 
            // chkCount
            // 
            this.chkCount.AutoSize = true;
            this.chkCount.Checked = true;
            this.chkCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCount.Location = new System.Drawing.Point(37, 75);
            this.chkCount.Name = "chkCount";
            this.chkCount.Size = new System.Drawing.Size(82, 29);
            this.chkCount.TabIndex = 1;
            this.chkCount.Text = "Count";
            this.chkCount.UseVisualStyleBackColor = true;
            // 
            // chkTitle
            // 
            this.chkTitle.AutoSize = true;
            this.chkTitle.Checked = true;
            this.chkTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTitle.Location = new System.Drawing.Point(37, 44);
            this.chkTitle.Name = "chkTitle";
            this.chkTitle.Size = new System.Drawing.Size(107, 29);
            this.chkTitle.TabIndex = 0;
            this.chkTitle.Text = "Film Title";
            this.chkTitle.UseVisualStyleBackColor = true;
            // 
            // optAboveZero
            // 
            this.optAboveZero.AutoSize = true;
            this.optAboveZero.Checked = true;
            this.optAboveZero.Location = new System.Drawing.Point(268, 201);
            this.optAboveZero.Name = "optAboveZero";
            this.optAboveZero.Size = new System.Drawing.Size(239, 29);
            this.optAboveZero.TabIndex = 2;
            this.optAboveZero.TabStop = true;
            this.optAboveZero.Text = "List of counts above zero";
            this.optAboveZero.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 177);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(225, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate List";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // optFullList
            // 
            this.optFullList.AutoSize = true;
            this.optFullList.Location = new System.Drawing.Point(268, 170);
            this.optFullList.Name = "optFullList";
            this.optFullList.Size = new System.Drawing.Size(93, 29);
            this.optFullList.TabIndex = 1;
            this.optFullList.Text = "Full List";
            this.optFullList.UseVisualStyleBackColor = true;
            // 
            // lnkConsole
            // 
            this.lnkConsole.AutoSize = true;
            this.lnkConsole.Location = new System.Drawing.Point(359, 417);
            this.lnkConsole.Name = "lnkConsole";
            this.lnkConsole.Size = new System.Drawing.Size(171, 25);
            this.lnkConsole.TabIndex = 2;
            this.lnkConsole.TabStop = true;
            this.lnkConsole.Text = "Developer Console";
            this.lnkConsole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsole_LinkClicked);
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSize = true;
            this.chkPrice.Checked = true;
            this.chkPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrice.Location = new System.Drawing.Point(397, 75);
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.Size = new System.Drawing.Size(73, 29);
            this.chkPrice.TabIndex = 3;
            this.chkPrice.Text = "Price";
            this.chkPrice.UseVisualStyleBackColor = true;
            // 
            // frmAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 451);
            this.Controls.Add(this.lnkConsole);
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
            this.gbInclude.ResumeLayout(false);
            this.gbInclude.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optAboveZero;
        private System.Windows.Forms.RadioButton optFullList;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.GroupBox gbInclude;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.CheckBox chkHolds;
        private System.Windows.Forms.CheckBox chkCondition;
        private System.Windows.Forms.CheckBox chkCount;
        private System.Windows.Forms.CheckBox chkTitle;
        private System.Windows.Forms.LinkLabel lnkConsole;
        private System.Windows.Forms.CheckBox chkPrice;
    }
}