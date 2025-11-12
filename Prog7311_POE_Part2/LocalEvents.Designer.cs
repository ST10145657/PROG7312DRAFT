namespace Prog7311_POE_Part2
{
    partial class LocalEvents
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
            listViewEvents = new ListView();
            txtSearch = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSearch = new Button();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            lbllocation = new Label();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listViewEvents
            // 
            listViewEvents.Location = new Point(12, 313);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(629, 150);
            listViewEvents.TabIndex = 0;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.SelectedIndexChanged += listViewEvents_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(275, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 31);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.Location = new Point(647, 342);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(204, 51);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Location = new Point(647, 417);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(204, 46);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(839, 148);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbllocation
            // 
            lbllocation.AutoSize = true;
            lbllocation.Location = new Point(161, 39);
            lbllocation.Name = "lbllocation";
            lbllocation.Size = new Size(84, 25);
            lbllocation.TabIndex = 7;
            lbllocation.Text = "Location ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(196, 103);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            lblDate.Click += lblDate_Click;
            // 
            // LocalEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(877, 490);
            Controls.Add(lblDate);
            Controls.Add(lbllocation);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSearch);
            Controls.Add(listViewEvents);
            Name = "LocalEvents";
            Text = "Local Events";
            Load += LocalEvents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEvents;

        private TextBox txtSearch;
        private DateTimePicker dateTimePicker1;
        private Button btnSearch;
        private Button btnBack;
        private DataGridView dataGridView1;
        private Label lbllocation;
        private Label lblDate;
    }
}