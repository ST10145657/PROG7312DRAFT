using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prog7312_POE_Part2.SharedData;

namespace Prog7312_POE_Part2
{
    public partial class ServicesRequestStatus : Form
    {
        public ServicesRequestStatus()
        {
            InitializeComponent();
            InitializeCustomLogic();
            LoadRequestsToGrid();
            LoadRequestsToGrid();
            
        }


        


        private void InitializeCustomLogic()
        {
            LoadRequestsToGrid();

            // Attach event handlers
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            btnSearchById.Click += btnSearchById_Click;
            btnRefresh.Click += (s, e) => LoadRequestsToGrid();
            btnShowByPriority.Click += btnShowByPriority_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnBack.Click += (s, e) => { new MainMenu().Show(); this.Close(); };

            cmbNewStatus.Items.AddRange(new string[] { "Submitted", "In Progress", "Completed" });
            cmbNewStatus.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ServicesRequestStatus));
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
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1011, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "ID Number ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(404, 121);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(202, 50);
            btnSearchById.TabIndex = 2;
            btnSearchById.Text = "Search By Id:";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(636, 121);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(202, 50);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Location = new Point(404, 213);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(282, 33);
            cmbNewStatus.TabIndex = 4;
            cmbNewStatus.Text = "New Status";
            cmbNewStatus.SelectedIndexChanged += cmbNewStatus_SelectedIndexChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(920, 203);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(208, 50);
            btnUpdateStatus.TabIndex = 5;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(404, 287);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(169, 25);
            lblSelected.TabIndex = 6;
            lblSelected.Text = "Selected Request ID";
            lblSelected.Click += lblSelected_Click;
            // 
            // txtSelectedId
            // 
            txtSelectedId.Location = new Point(636, 281);
            txtSelectedId.Name = "txtSelectedId";
            txtSelectedId.Size = new Size(282, 31);
            txtSelectedId.TabIndex = 7;
            txtSelectedId.Text = "Selected Id";
            txtSelectedId.TextChanged += txtSelectedId_TextChanged;
            // 
            // btnShowByPriority
            // 
            btnShowByPriority.Location = new Point(914, 121);
            btnShowByPriority.Name = "btnShowByPriority";
            btnShowByPriority.Size = new Size(214, 52);
            btnShowByPriority.TabIndex = 8;
            btnShowByPriority.Text = "Show By Priority";
            btnShowByPriority.UseVisualStyleBackColor = true;
            btnShowByPriority.Click += btnShowByPriority_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Location = new Point(1034, 469);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 64);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Dependencies
            // 
            Dependencies.FormattingEnabled = true;
            Dependencies.Location = new Point(17, 51);
            Dependencies.Name = "Dependencies";
            Dependencies.Size = new Size(329, 279);
            Dependencies.TabIndex = 10;
            Dependencies.SelectedIndexChanged += Dependencies_SelectedIndexChanged;
            // 
            // ServicesRequestStatus
            // 
            BackColor = Color.Teal;
            ClientSize = new Size(1236, 545);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServicesRequestStatus";
            Text = "Services Request";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
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

        public string CurrentCultureCode { get; internal set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["ID"].Value == null) return;

            int id = Convert.ToInt32(row.Cells["ID"].Value);
            txtSelectedId.Text = id.ToString();

            // Show dependencies
            Dependencies.Items.Clear();
            var deps = SharedServiceRequests.RequestGraph.GetDependencies(id);
            if (deps.Count == 0)
                Dependencies.Items.Add("(no dependencies)");
            else
                foreach (var dep in deps)
                    Dependencies.Items.Add($"Depends on Request {dep}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int id))
            {
                MessageBox.Show("Enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var req = SharedServiceRequests.RequestBST.Search(id);
            if (req == null)
            {
                MessageBox.Show($"No service request found with ID {id}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Show single record
            var single = new[]
            {
                new
                {
                    ID = req.ID,
                    Location = req.Location,
                    Category = req.Category,
                    Description = req.Description,
                    Status = req.Status,
                    Priority = req.Priority,
                    CreatedAt = req.CreatedAt
                }
            }.ToList();

            dataGridView1.DataSource = single;
            txtSelectedId.Text = req.ID.ToString();

            // Show dependencies
            Dependencies.Items.Clear();
            var deps = SharedServiceRequests.RequestGraph.GetDependencies(req.ID);
            if (deps.Count == 0) Dependencies.Items.Add("(no dependencies)");
            else deps.ForEach(d => Dependencies.Items.Add(d));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cmbNewStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSelectedId.Text, out int id))
            {
                MessageBox.Show("Select a request first (click a row or search by ID).", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var req = SharedServiceRequests.RequestBST.Search(id);
            if (req == null)
            {
                MessageBox.Show("Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newStatus = cmbNewStatus.SelectedItem.ToString();
            req.Status = newStatus;
            SharedServiceRequests.RequestHeap.Rebuild();

            MessageBox.Show($"Updated request {id} status to {newStatus}.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadRequestsToGrid();
        }

        private void Dependencies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void txtSelectedId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSelected_Click(object sender, EventArgs e)
        {

        }

        private void LoadRequestsToGrid()
        {
            var list = SharedServiceRequests.GetAllRequests();

            // Build an anonymous object list for the grid
            var gridList = list.Select(r => new
            {
                ID = r.ID,
                Location = r.Location,
                Category = r.Category,
                Description = r.Description,
                Status = r.Status,
                Priority = r.Priority,
                CreatedAt = r.CreatedAt
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gridList;
            dataGridView1.ClearSelection();

            // Clear selection UI
            txtSelectedId.Text = "";
            Dependencies.Items.Clear();
        }


        private void btnShowByPriority_Click(object sender, EventArgs e)
        {
            var list = SharedServiceRequests.RequestHeap.GetAllRequests();

            var gridList = list.Select(r => new
            {
                ID = r.ID,
                Location = r.Location,
                Category = r.Category,
                Description = r.Description,
                Status = r.Status,
                Priority = r.Priority,
                CreatedAt = r.CreatedAt
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gridList;
            dataGridView1.ClearSelection();
        }
        public void ChangeLanguage(string langCode)
        {
            CurrentCultureCode = langCode;
            // Update all button/label texts based on langCode
        }

    }
}
 
