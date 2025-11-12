namespace Prog7311_POE_Part2
{
    partial class ServiceRequestStatus : Form 
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnSearchById = new Button();
            btnRefresh = new Button();
            cmbNewStatus = new ComboBox();
            btnUpdateStatus = new Button();
            lblSelected = new Label();
            txtSelectedId = new TextBox();
            btnShowByPriority = new Button();
            btnBack = new Button();
            Dependencies = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(357, 531);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Search By Id";
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(632, 85);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(182, 31);
            btnSearchById.TabIndex = 2;
            btnSearchById.Text = "Search By Id";
            btnSearchById.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(632, 138);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(182, 42);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Location = new Point(404, 195);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(182, 33);
            cmbNewStatus.TabIndex = 4;
            cmbNewStatus.Text = "New Status";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(632, 195);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(182, 33);
            btnUpdateStatus.TabIndex = 5;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(422, 311);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(87, 25);
            lblSelected.TabIndex = 6;
            lblSelected.Text = "Selected :";
            // 
            // txtSelectedId
            // 
            txtSelectedId.Location = new Point(632, 308);
            txtSelectedId.Name = "txtSelectedId";
            txtSelectedId.Size = new Size(182, 31);
            txtSelectedId.TabIndex = 7;
            txtSelectedId.Text = "Selected ID";
            // 
            // btnShowByPriority
            // 
            btnShowByPriority.Location = new Point(632, 455);
            btnShowByPriority.Name = "btnShowByPriority";
            btnShowByPriority.Size = new Size(182, 34);
            btnShowByPriority.TabIndex = 9;
            btnShowByPriority.Text = "Show By Priority";
            btnShowByPriority.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1072, 531);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(199, 66);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Dependencies
            // 
            Dependencies.FormattingEnabled = true;
            Dependencies.Location = new Point(959, 323);
            Dependencies.Name = "Dependencies";
            Dependencies.Size = new Size(256, 154);
            Dependencies.TabIndex = 11;
            // 
            // ServicesRequestStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 622);
            Controls.Add(Dependencies);
            Controls.Add(btnBack);
            Controls.Add(btnShowByPriority);
            Controls.Add(txtSelectedId);
            Controls.Add(lblSelected);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbNewStatus);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchById);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "ServicesRequestStatus";
            Text = "ServicesRequestStatus";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnSearchById;
        private Button btnRefresh;
        private ComboBox cmbNewStatus;
        private Button btnUpdateStatus;
        private Label lblSelected;
        private TextBox txtSelectedId;
        private Button btnShowByPriority;
        private Button btnBack;
        private ListBox Dependencies;
    }
}