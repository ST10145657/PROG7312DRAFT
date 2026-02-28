using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace Prog7312_POE_Part2
{
    public partial class LocalEvents : Form
    {
        // Store events grouped by category

        private SortedDictionary<DateTime, List<LocalEvent>> eventsByDate;


        public LocalEvents()
        {
            InitializeComponent();

            listViewEvents.View = View.Details;
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;

            // Clear existing columns and add new ones
            listViewEvents.Columns.Clear();
            listViewEvents.Columns.Add("Title", 180);
            listViewEvents.Columns.Add("Category", 100);
            listViewEvents.Columns.Add("Date", 100);
            listViewEvents.Columns.Add("Description", 250);

            LoadSampleData();
            DisplayAllEvents();
            DisplayInDataGridView();


        }

        private void LoadSampleData()
        {
            eventsByDate = new SortedDictionary<DateTime, List<LocalEvent>>();

            void AddEvent(LocalEvent ev)
            {
                if (!eventsByDate.ContainsKey(ev.Date.Date))
                    eventsByDate[ev.Date.Date] = new List<LocalEvent>();

                eventsByDate[ev.Date.Date].Add(ev);
            }

            // 🧹 Community Events
            AddEvent(new LocalEvent { Title = "Park Cleanup", Category = "Public Safety", Date = DateTime.Now.AddDays(2), Description = "Join the community to clean up Greenfield Park. Gloves and bags provided." });
            AddEvent(new LocalEvent { Title = "Public Transportation", Category = "Utilities", Date = DateTime.Now.AddDays(4), Description = "Workers are on Striking." });
            AddEvent(new LocalEvent { Title = "Burst pipe", Category = "Water", Date = DateTime.Now.AddDays(1), Description = "Due to old pipes the pipe burst near town." });

        }

        

        private void DisplayAllEvents()
        {
            listViewEvents.Items.Clear();

            // 🟢 Show default local events
            foreach (var category in eventsByDate.Values)
            {
                foreach (var ev in category)
                {
                    var item = new ListViewItem(ev.Title);
                    item.SubItems.Add(ev.Category);
                    item.SubItems.Add(ev.Date.ToShortDateString());
                    item.SubItems.Add(ev.Description);
                    listViewEvents.Items.Add(item);
                }
            }

            // 🟡 Show reported issues from ReportIssue form
            if (SharedData.ReportedIssues.Count > 0)
            {
                var header = new ListViewItem("—— Reported Issues ——");
                header.ForeColor = System.Drawing.Color.DarkBlue;
                listViewEvents.Items.Add(header);

                foreach (var issue in SharedData.ReportedIssues)
                {
                    var item = new ListViewItem($"Issue at: {issue.Location}");
                    item.SubItems.Add(issue.Category);
                    item.SubItems.Add(DateTime.Now.ToShortDateString());
                    item.SubItems.Add(issue.Description);
                    listViewEvents.Items.Add(item);
                }
            }
        }



        // 🔹 NEW: Display events in DataGridView
        private void DisplayInDataGridView()
        {
            // Combine sample events + reported issues into one list for DataGridView
            var allEvents = eventsByDate.Values.SelectMany(list => list)
                .Select(ev => new
                {
                    Title = ev.Title,
                    Category = ev.Category,
                    Date = ev.Date.ToShortDateString(),
                    Description = ev.Description
                })
                .ToList();

            // Add reported issues
            allEvents.AddRange(SharedData.ReportedIssues.Select(issue => new
            {
                Title = $"Issue at: {issue.Location}",
                Category = issue.Category,
                Date = DateTime.Now.ToShortDateString(),
                Description = issue.Description
            }));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allEvents;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            DateTime selectedDate = dateTimePicker1.Value.Date;

            var results = eventsByDate.Values
                .SelectMany(e => e)
                .Where(ev =>
                    ev.Title.ToLower().Contains(searchText) ||
                    ev.Category.ToLower().Contains(searchText) ||
                    ev.Description.ToLower().Contains(searchText) ||
                    ev.Date.Date == selectedDate)
               .Select(ev => new
               {
                   ev.Title,
                   ev.Category,
                   Date = ev.Date.ToShortDateString(),
                   ev.Description
               })
                .ToList();

            // Include Reported Issues in search results
            results.AddRange(SharedData.ReportedIssues
                .Where(issue =>
                    issue.Location.ToLower().Contains(searchText) ||
                    issue.Category.ToLower().Contains(searchText) ||
                    issue.Description.ToLower().Contains(searchText))
                .Select(issue => new
                {
                    Title = $"Issue at: {issue.Location}",
                    Category = issue.Category,
                    Date = DateTime.Now.ToShortDateString(),
                    Description = issue.Description
                }));


            listViewEvents.Items.Clear();

            foreach (var ev in results)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.Date);
                item.SubItems.Add(ev.Description);

                listViewEvents.Items.Add(item);
            }

            // 🔹 NEW: update DataGridView with search results
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No events found for the given search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            Close();
        }

        // Keep all other empty event handlers as-is
        //private void btnSearch_Click_1(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0)
                return; // nothing selected

            var selectedItem = listViewEvents.SelectedItems[0];

            string title = selectedItem.SubItems[0].Text;
            string category = selectedItem.SubItems[1].Text;
            string date = selectedItem.SubItems[2].Text;
            string description = selectedItem.SubItems[3].Text;

            string message = $"Title: {title}\nCategory: {category}\nDate: {date}\nDescription: {description}";

            MessageBox.Show(message, "Event / Issue Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LocalEvents_Load(object sender, EventArgs e)
        {

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CurrentCultureCode { get; set; } = "en-US";

        public void ChangeLanguage(string langCode)
        {
            CurrentCultureCode = langCode;
            // Update all button/label texts based on langCode
        }

    }
}
