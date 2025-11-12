namespace Prog7311_POE_Part2
{
    partial class reportIssues1
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
            rtbDescription = new RichTextBox();
            lblAttachment = new Label();
            lblCategory = new Label();
            lblLocation = new Label();
            progressBar = new ProgressBar();
            btnBack = new Button();
            btnSubmit = new Button();
            btnAttach = new Button();
            cmbCategory = new ComboBox();
            txtLocation = new TextBox();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(643, 91);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(321, 271);
            rtbDescription.TabIndex = 19;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged_1;
            // 
            // lblAttachment
            // 
            lblAttachment.AutoSize = true;
            lblAttachment.Location = new Point(28, 240);
            lblAttachment.Name = "lblAttachment";
            lblAttachment.Size = new Size(137, 25);
            lblAttachment.TabIndex = 18;
            lblAttachment.Text = "No file attached";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 171);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Category";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(28, 97);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 25);
            lblLocation.TabIndex = 16;
            lblLocation.Text = "Location";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(28, 432);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(291, 46);
            progressBar.TabIndex = 15;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Location = new Point(760, 432);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(204, 51);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Green;
            btnSubmit.Location = new Point(449, 432);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(204, 51);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit ";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnAttach
            // 
            btnAttach.BackColor = Color.Azure;
            btnAttach.Location = new Point(258, 240);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(307, 43);
            btnAttach.TabIndex = 12;
            btnAttach.Text = "Attach File ";
            btnAttach.UseVisualStyleBackColor = false;
            btnAttach.Click += btnAttach_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(192, 192, 255);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(258, 163);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(307, 33);
            cmbCategory.TabIndex = 11;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(258, 91);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(307, 31);
            txtLocation.TabIndex = 10;
            txtLocation.TextChanged += txtLocation_TextChanged_1;
            // 
            // reportIssues1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(993, 574);
            Controls.Add(rtbDescription);
            Controls.Add(lblAttachment);
            Controls.Add(lblCategory);
            Controls.Add(lblLocation);
            Controls.Add(progressBar);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnAttach);
            Controls.Add(cmbCategory);
            Controls.Add(txtLocation);
            Name = "reportIssues1";
            Text = "Report Isssue";
            Load += reportIssues1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private RichTextBox rtbDescription;
        private Label lblAttachment;
        private Label lblCategory;
        private Label lblLocation;
        private ProgressBar progressBar;
        private Button btnBack;
        private Button btnSubmit;
        private Button btnAttach;
        private ComboBox cmbCategory;
        private TextBox txtLocation;
    }
}