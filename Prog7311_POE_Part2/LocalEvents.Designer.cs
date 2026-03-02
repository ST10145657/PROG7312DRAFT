namespace Prog7312_POE_Part2
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

        // Master list of events
        private List<LocalEvent> allEvents = new List<LocalEvent>();

        // Dictionary (Hash Table) – Fast lookup by Title
        private Dictionary<string, LocalEvent> eventDictionary =
            new Dictionary<string, LocalEvent>();

        // Queue – Registration processing (FIFO)
        private Queue<LocalEvent> registrationQueue =
            new Queue<LocalEvent>();

        // Stack – Recently viewed events (LIFO)
        private Stack<LocalEvent> recentlyViewed =
            new Stack<LocalEvent>();

        // Priority Queue – Upcoming events sorted by Date
        private PriorityQueue<LocalEvent, DateTime> upcomingEvents =
            new PriorityQueue<LocalEvent, DateTime>();

        // User search tracking
        private Dictionary<string, int> searchFrequency =
            new Dictionary<string, int>();


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modif
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEvents));
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
            resources.ApplyResources(listViewEvents, "listViewEvents");
            listViewEvents.Name = "listViewEvents";
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.SelectedIndexChanged += listViewEvents_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Name = "dateTimePicker1";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbllocation
            // 
            resources.ApplyResources(lbllocation, "lbllocation");
            lbllocation.Name = "lbllocation";
            // 
            // lblDate
            // 
            resources.ApplyResources(lblDate, "lblDate");
            lblDate.Name = "lblDate";
            lblDate.Click += lblDate_Click;
            // 
            // LocalEvents
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.DarkSlateGray;
            Controls.Add(lblDate);
            Controls.Add(lbllocation);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSearch);
            Controls.Add(listViewEvents);
            Name = "LocalEvents";
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