namespace LibrarySolution.PresentationLayer.Forms
{
    partial class LoanBookForm
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
            this.grpLoanItem = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLoanItem = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.cmbUserId = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.cbIsAvailable = new System.Windows.Forms.CheckBox();
            this.nmrPageNumber = new System.Windows.Forms.NumericUpDown();
            this.txtLibaryCode = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpLoanItem.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoanItem
            // 
            this.grpLoanItem.Controls.Add(this.dtpEndDate);
            this.grpLoanItem.Controls.Add(this.dtpBeginDate);
            this.grpLoanItem.Controls.Add(this.label1);
            this.grpLoanItem.Controls.Add(this.label11);
            this.grpLoanItem.Controls.Add(this.btnLoanItem);
            this.grpLoanItem.Location = new System.Drawing.Point(12, 378);
            this.grpLoanItem.Name = "grpLoanItem";
            this.grpLoanItem.Size = new System.Drawing.Size(580, 308);
            this.grpLoanItem.TabIndex = 46;
            this.grpLoanItem.TabStop = false;
            this.grpLoanItem.Text = "Loan Item";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(187, 131);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(341, 28);
            this.dtpEndDate.TabIndex = 51;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginDate.Location = new System.Drawing.Point(187, 70);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(341, 28);
            this.dtpBeginDate.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "End Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Begin Date";
            // 
            // btnLoanItem
            // 
            this.btnLoanItem.Location = new System.Drawing.Point(394, 205);
            this.btnLoanItem.Name = "btnLoanItem";
            this.btnLoanItem.Size = new System.Drawing.Size(134, 53);
            this.btnLoanItem.TabIndex = 47;
            this.btnLoanItem.Text = "Loan Item";
            this.btnLoanItem.UseVisualStyleBackColor = true;
            this.btnLoanItem.Click += new System.EventHandler(this.btnLoanItem_Click);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.cmbUserId);
            this.grpUserInfo.Controls.Add(this.txtLastName);
            this.grpUserInfo.Controls.Add(this.txtFirstName);
            this.grpUserInfo.Controls.Add(this.label13);
            this.grpUserInfo.Controls.Add(this.txtUserName);
            this.grpUserInfo.Controls.Add(this.label14);
            this.grpUserInfo.Controls.Add(this.label16);
            this.grpUserInfo.Controls.Add(this.label17);
            this.grpUserInfo.Location = new System.Drawing.Point(12, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(580, 322);
            this.grpUserInfo.TabIndex = 47;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Info";
            // 
            // cmbUserId
            // 
            this.cmbUserId.FormattingEnabled = true;
            this.cmbUserId.Location = new System.Drawing.Point(187, 78);
            this.cmbUserId.Name = "cmbUserId";
            this.cmbUserId.Size = new System.Drawing.Size(341, 30);
            this.cmbUserId.TabIndex = 58;
            this.cmbUserId.SelectedIndexChanged += new System.EventHandler(this.cmbUserId_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(187, 246);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(341, 28);
            this.txtLastName.TabIndex = 56;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(187, 185);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(341, 28);
            this.txtFirstName.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 48;
            this.label13.Text = "Last Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(187, 131);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(341, 28);
            this.txtUserName.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 49;
            this.label14.Text = "First Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 24);
            this.label16.TabIndex = 51;
            this.label16.Text = "User Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 78);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 24);
            this.label17.TabIndex = 52;
            this.label17.Text = "Select User";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.txtPublisher);
            this.grpBookInfo.Controls.Add(this.txtCategory);
            this.grpBookInfo.Controls.Add(this.dtpPublishDate);
            this.grpBookInfo.Controls.Add(this.cbIsAvailable);
            this.grpBookInfo.Controls.Add(this.nmrPageNumber);
            this.grpBookInfo.Controls.Add(this.txtLibaryCode);
            this.grpBookInfo.Controls.Add(this.txtAuthorName);
            this.grpBookInfo.Controls.Add(this.label6);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.label5);
            this.grpBookInfo.Controls.Add(this.label9);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Controls.Add(this.label4);
            this.grpBookInfo.Controls.Add(this.label8);
            this.grpBookInfo.Controls.Add(this.txtId);
            this.grpBookInfo.Controls.Add(this.label7);
            this.grpBookInfo.Controls.Add(this.label3);
            this.grpBookInfo.Controls.Add(this.label2);
            this.grpBookInfo.Controls.Add(this.label10);
            this.grpBookInfo.Location = new System.Drawing.Point(598, 12);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(586, 674);
            this.grpBookInfo.TabIndex = 48;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Info";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(191, 499);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(334, 28);
            this.txtPublisher.TabIndex = 62;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(191, 436);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(334, 28);
            this.txtCategory.TabIndex = 61;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(191, 232);
            this.dtpPublishDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(334, 28);
            this.dtpPublishDate.TabIndex = 55;
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.AutoSize = true;
            this.cbIsAvailable.Enabled = false;
            this.cbIsAvailable.Location = new System.Drawing.Point(191, 624);
            this.cbIsAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(126, 28);
            this.cbIsAvailable.TabIndex = 60;
            this.cbIsAvailable.Text = "Is Available";
            this.cbIsAvailable.UseVisualStyleBackColor = true;
            // 
            // nmrPageNumber
            // 
            this.nmrPageNumber.Location = new System.Drawing.Point(191, 367);
            this.nmrPageNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nmrPageNumber.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrPageNumber.Name = "nmrPageNumber";
            this.nmrPageNumber.ReadOnly = true;
            this.nmrPageNumber.Size = new System.Drawing.Size(150, 28);
            this.nmrPageNumber.TabIndex = 57;
            // 
            // txtLibaryCode
            // 
            this.txtLibaryCode.Location = new System.Drawing.Point(191, 48);
            this.txtLibaryCode.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtLibaryCode.Name = "txtLibaryCode";
            this.txtLibaryCode.ReadOnly = true;
            this.txtLibaryCode.Size = new System.Drawing.Size(334, 28);
            this.txtLibaryCode.TabIndex = 59;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(191, 294);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(334, 28);
            this.txtAuthorName.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Category";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(191, 568);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(334, 28);
            this.txtISBN.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Page Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Library Code";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(191, 168);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(334, 28);
            this.txtTitle.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Author Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 571);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "ISBN";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(191, 106);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(334, 28);
            this.txtId.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 503);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Publisher Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 52;
            this.label10.Text = "Id";
            // 
            // LoanBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 702);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.grpLoanItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanBookForm_FormClosed);
            this.Load += new System.EventHandler(this.LoanBookForm_Load);
            this.grpLoanItem.ResumeLayout(false);
            this.grpLoanItem.PerformLayout();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPageNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLoanItem;
        private System.Windows.Forms.Button btnLoanItem;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.ComboBox cmbUserId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.CheckBox cbIsAvailable;
        private System.Windows.Forms.NumericUpDown nmrPageNumber;
        private System.Windows.Forms.TextBox txtLibaryCode;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}