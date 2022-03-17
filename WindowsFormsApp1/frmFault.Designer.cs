namespace WindowsFormsApp1
{
    partial class frmFault
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
            this.grbFault = new System.Windows.Forms.GroupBox();
            this.cmbIntRes = new System.Windows.Forms.ComboBox();
            this.cmbStuReport = new System.Windows.Forms.ComboBox();
            this.cmbFaultType = new System.Windows.Forms.ComboBox();
            this.lstbFault = new System.Windows.Forms.ListBox();
            this.txtFaultDesc = new System.Windows.Forms.TextBox();
            this.txtFaultID = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIntRes = new System.Windows.Forms.Label();
            this.lblStReport = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grbFault.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFault
            // 
            this.grbFault.Controls.Add(this.cmbIntRes);
            this.grbFault.Controls.Add(this.cmbStuReport);
            this.grbFault.Controls.Add(this.cmbFaultType);
            this.grbFault.Controls.Add(this.lstbFault);
            this.grbFault.Controls.Add(this.txtFaultDesc);
            this.grbFault.Controls.Add(this.txtFaultID);
            this.grbFault.Controls.Add(this.btnGoBack);
            this.grbFault.Controls.Add(this.btnList);
            this.grbFault.Controls.Add(this.btnAdd);
            this.grbFault.Controls.Add(this.lblIntRes);
            this.grbFault.Controls.Add(this.lblStReport);
            this.grbFault.Controls.Add(this.lblType);
            this.grbFault.Controls.Add(this.lblDesc);
            this.grbFault.Controls.Add(this.lblId);
            this.grbFault.Location = new System.Drawing.Point(13, 13);
            this.grbFault.Name = "grbFault";
            this.grbFault.Size = new System.Drawing.Size(656, 484);
            this.grbFault.TabIndex = 0;
            this.grbFault.TabStop = false;
            this.grbFault.Text = "Fault Information";
            this.grbFault.Enter += new System.EventHandler(this.grbFault_Enter);
            // 
            // cmbIntRes
            // 
            this.cmbIntRes.FormattingEnabled = true;
            this.cmbIntRes.Location = new System.Drawing.Point(223, 186);
            this.cmbIntRes.Name = "cmbIntRes";
            this.cmbIntRes.Size = new System.Drawing.Size(308, 24);
            this.cmbIntRes.TabIndex = 14;
            // 
            // cmbStuReport
            // 
            this.cmbStuReport.FormattingEnabled = true;
            this.cmbStuReport.Location = new System.Drawing.Point(223, 153);
            this.cmbStuReport.Name = "cmbStuReport";
            this.cmbStuReport.Size = new System.Drawing.Size(308, 24);
            this.cmbStuReport.TabIndex = 13;
            // 
            // cmbFaultType
            // 
            this.cmbFaultType.FormattingEnabled = true;
            this.cmbFaultType.Location = new System.Drawing.Point(223, 114);
            this.cmbFaultType.Name = "cmbFaultType";
            this.cmbFaultType.Size = new System.Drawing.Size(308, 24);
            this.cmbFaultType.TabIndex = 12;
            this.cmbFaultType.SelectedIndexChanged += new System.EventHandler(this.cmbFaultType_SelectedIndexChanged);
            // 
            // lstbFault
            // 
            this.lstbFault.FormattingEnabled = true;
            this.lstbFault.ItemHeight = 16;
            this.lstbFault.Location = new System.Drawing.Point(6, 270);
            this.lstbFault.Name = "lstbFault";
            this.lstbFault.Size = new System.Drawing.Size(638, 196);
            this.lstbFault.TabIndex = 11;
            // 
            // txtFaultDesc
            // 
            this.txtFaultDesc.Location = new System.Drawing.Point(256, 72);
            this.txtFaultDesc.Name = "txtFaultDesc";
            this.txtFaultDesc.Size = new System.Drawing.Size(275, 22);
            this.txtFaultDesc.TabIndex = 10;
            // 
            // txtFaultID
            // 
            this.txtFaultID.Enabled = false;
            this.txtFaultID.Location = new System.Drawing.Point(256, 27);
            this.txtFaultID.Name = "txtFaultID";
            this.txtFaultID.Size = new System.Drawing.Size(275, 22);
            this.txtFaultID.TabIndex = 9;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(551, 105);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(551, 66);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(551, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIntRes
            // 
            this.lblIntRes.AutoSize = true;
            this.lblIntRes.Location = new System.Drawing.Point(6, 186);
            this.lblIntRes.Name = "lblIntRes";
            this.lblIntRes.Size = new System.Drawing.Size(130, 17);
            this.lblIntRes.TabIndex = 4;
            this.lblIntRes.Text = "Intern Responsible:";
            // 
            // lblStReport
            // 
            this.lblStReport.AutoSize = true;
            this.lblStReport.Location = new System.Drawing.Point(6, 153);
            this.lblStReport.Name = "lblStReport";
            this.lblStReport.Size = new System.Drawing.Size(127, 17);
            this.lblStReport.TabIndex = 3;
            this.lblStReport.Text = "Student Reporting:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 111);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(79, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Fault Type:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 72);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Fault Desc:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Fault ID:";
            // 
            // frmFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 496);
            this.Controls.Add(this.grbFault);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFault";
            this.Text = "frmFault";
            this.Load += new System.EventHandler(this.frmFualt_Load);
            this.grbFault.ResumeLayout(false);
            this.grbFault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFault;
        private System.Windows.Forms.ComboBox cmbIntRes;
        private System.Windows.Forms.ComboBox cmbStuReport;
        private System.Windows.Forms.ComboBox cmbFaultType;
        private System.Windows.Forms.ListBox lstbFault;
        private System.Windows.Forms.TextBox txtFaultDesc;
        private System.Windows.Forms.TextBox txtFaultID;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIntRes;
        private System.Windows.Forms.Label lblStReport;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblId;
    }
}