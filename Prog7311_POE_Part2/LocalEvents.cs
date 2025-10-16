using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prog7311_POE_Part2
{
    public partial class LocalEvents : Form
    {
        // Store events grouped by category
        
        private SortedDictionary<DateTime, List<LocalEvent>> eventsByDate;


        public LocalEvents()
        {
            InitializeComponent();
            LoadSampleData();
            DisplayAllEvents();
            DisplayInDataGridView(); // 🔹 NEW: show events in DataGridView
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
            AddEvent(new LocalEvent
            {
                Title = "Park Cleanup",
                Category = "Community",
                Date = DateTime.Now.AddDays(2),
                Description = "Join the community to clean up Greenfield Park. Gloves and bags provided."
            });
            AddEvent(new LocalEvent
            {
                Title = "Township Beautification Day",
                Category = "Community",
                Date = DateTime.Now.AddDays(5),
                Description = "Help paint, plant trees, and clean up your local area. Everyone welcome!"
            });

            // 🏫 Education & Youth
            AddEvent(new LocalEvent
            {
                Title = "Coding for Beginners Workshop",
                Category = "Education",
                Date = DateTime.Now.AddDays(4),
                Description = "Free coding class hosted by the local library. Learn basic programming concepts."
            });
            AddEvent(new LocalEvent
            {
                Title = "Matric Study Support Session",
                Category = "Education",
                Date = DateTime.Now.AddDays(7),
                Description = "Get help from tutors in maths and science before exams."
            });

            // ❤️ Health & Wellness
            AddEvent(new LocalEvent
            {
                Title = "Community Health Screening",
                Category = "Health",
                Date = DateTime.Now.AddDays(3),
                Description = "Free blood pressure, diabetes, and cholesterol screening at the civic centre."
            });
            AddEvent(new LocalEvent
            {
                Title = "Blood Donation Drive",
                Category = "Health",
                Date = DateTime.Now.AddDays(1),
                Description = "Donate blood and help save lives. Refreshments provided."
            });

            // 💼 Municipal Announcements
            AddEvent(new LocalEvent
            {
                Title = "Water Maintenance Notice",
                Category = "Municipal",
                Date = DateTime.Now.AddDays(6),
                Description = "Scheduled water maintenance in the northern suburbs. Expect low pressure."
            });
            AddEvent(new LocalEvent
            {
                Title = "Public Safety Awareness Day",
                Category = "Municipal",
                Date = DateTime.Now.AddDays(8),
                Description = "Meet your local SAPS and fire department teams. Learn about safety tips."
            });

            // 🎉 Cultural & Recreational
            AddEvent(new LocalEvent
            {
                Title = "Heritage Day Celebration",
                Category = "Cultural",
                Date = DateTime.Now.AddDays(10),
                Description = "Celebrate local culture, food, and music at Freedom Square."
            });
            AddEvent(new LocalEvent
            {
                Title = "Community Fun Run",
                Category = "Recreation",
                Date = DateTime.Now.AddDays(12),
                Description = "5km fun run/walk for all ages. Starts at the community hall."
            });
        }



        private void DisplayAllEvents()
        {
            listViewEvents.Items.Clear();

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
        }

        // 🔹 NEW: Display events in DataGridView
        private void DisplayInDataGridView()
        {
            var allEvents = eventsByDate.Values.SelectMany(list => list).ToList();

            dataGridView1.DataSource = null; // reset
            dataGridView1.DataSource = allEvents;

            // Optional: styling
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                .ToList();

            listViewEvents.Items.Clear();

            foreach (var ev in results)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.Date.ToShortDateString());
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
        private void btnSearch_Click_1(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
