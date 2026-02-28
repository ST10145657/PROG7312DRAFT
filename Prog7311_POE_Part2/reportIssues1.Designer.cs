namespace Prog7312_POE_Part2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportIssues1));
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
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            resources.ApplyResources(rtbDescription, "rtbDescription");
            rtbDescription.Name = "rtbDescription";
            rtbDescription.TextChanged += rtbDescription_TextChanged_1;
            // 
            // lblAttachment
            // 
            resources.ApplyResources(lblAttachment, "lblAttachment");
            lblAttachment.Name = "lblAttachment";
            // 
            // lblCategory
            // 
            resources.ApplyResources(lblCategory, "lblCategory");
            lblCategory.Name = "lblCategory";
            // 
            // lblLocation
            // 
            resources.ApplyResources(lblLocation, "lblLocation");
            lblLocation.Name = "lblLocation";
            // 
            // progressBar
            // 
            resources.ApplyResources(progressBar, "progressBar");
            progressBar.Name = "progressBar";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Green;
            resources.ApplyResources(btnSubmit, "btnSubmit");
            btnSubmit.Name = "btnSubmit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnAttach
            // 
            btnAttach.BackColor = Color.Azure;
            resources.ApplyResources(btnAttach, "btnAttach");
            btnAttach.Name = "btnAttach";
            btnAttach.UseVisualStyleBackColor = false;
            btnAttach.Click += btnAttach_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(192, 192, 255);
            cmbCategory.FormattingEnabled = true;
            resources.ApplyResources(cmbCategory, "cmbCategory");
            cmbCategory.Name = "cmbCategory";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
            // 
            // txtLocation
            // 
            resources.ApplyResources(txtLocation, "txtLocation");
            txtLocation.Name = "txtLocation";
            txtLocation.TextChanged += txtLocation_TextChanged_1;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // reportIssues1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Teal;
            resources.ApplyResources(this, "$this");
            Controls.Add(label1);
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
        private Label label1;
    }
}