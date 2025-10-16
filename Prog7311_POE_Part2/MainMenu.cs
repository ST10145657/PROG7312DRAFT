using Prog7311_POE_Part2.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Prog7311_POE_Part2
{
    public partial class MainMenu : Form
    {
        private Button btnReport;
        private Button btnEvents;
        private Button btnServices;
        private Button btnExit;
        private ListBox Languages;
        private PictureBox writing;
        private PictureBox Calendar;
        private PictureBox support;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnReport = new Button();
            btnEvents = new Button();
            btnServices = new Button();
            btnExit = new Button();
            writing = new PictureBox();
            Calendar = new PictureBox();
            support = new PictureBox();
            Languages = new ListBox();

            ((System.ComponentModel.ISupportInitialize)writing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)support).BeginInit();
            SuspendLayout();

            // 🗣️ Languages
            Languages.BackColor = Color.White;
            Languages.BorderStyle = BorderStyle.FixedSingle;
            Languages.FormattingEnabled = true;
            Languages.Items.AddRange(new object[] { "English", "isiZulu", "Afrikaans" });
            Languages.Location = new Point(22, 25);
            Languages.Size = new Size(149, 86);
            Languages.Name = "Languages";
            Languages.SelectedIndexChanged += Languages_SelectedIndexChanged;

            // ✍️ Writing Picture
            writing.Image = Resources.writing;
            writing.Location = new Point(111, 160);
            writing.Size = new Size(140, 115);
            writing.SizeMode = PictureBoxSizeMode.StretchImage;
            writing.Name = "writing";
            writing.TabStop = false;
            writing.Click += writing_Click;

            // 📅 Calendar Picture
            Calendar.Image = Resources.calendar;
            Calendar.Location = new Point(387, 160);
            Calendar.Size = new Size(151, 125);
            Calendar.SizeMode = PictureBoxSizeMode.StretchImage;
            Calendar.Name = "Calendar";
            Calendar.TabStop = false;
            Calendar.Click += Calendar_Click;

            // 💬 Support Picture
            support.Image = Resources.support;
            support.Location = new Point(652, 160);
            support.Size = new Size(156, 125);
            support.SizeMode = PictureBoxSizeMode.StretchImage;
            support.Name = "support";
            support.TabStop = false;
            support.Click += support_Click;

            // 🧾 Report Button
            btnReport.BackColor = Color.FromArgb(128, 128, 255);
            btnReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReport.Text = "Report Issues";
            btnReport.Location = new Point(111, 300);
            btnReport.Size = new Size(140, 50);
            btnReport.Name = "btnReport";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;

            // 📅 Events Button
            btnEvents.BackColor = Color.FromArgb(0, 192, 0);
            btnEvents.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEvents.Text = "Local Events and Announcements";
            btnEvents.Location = new Point(387, 300);
            btnEvents.Size = new Size(151, 50);
            btnEvents.Name = "btnEvents";
            btnEvents.UseVisualStyleBackColor = false;
            btnEvents.Click += btnEvents_Click;

            // 🧩 Services Button
            btnServices.BackColor = Color.FromArgb(0, 192, 192);
            btnServices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnServices.Text = "Services Request Status";
            btnServices.Location = new Point(652, 300);
            btnServices.Size = new Size(156, 50);
            btnServices.Name = "btnServices";
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;

            // ❌ Exit Button
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Text = "Exit";
            btnExit.Location = new Point(367, 438);
            btnExit.Size = new Size(200, 75);
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;

            // 🌿 MainMenu Form
            AutoScaleMode = AutoScaleMode.None; // prevent scaling issues
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(900, 600);
            Controls.Add(writing);
            Controls.Add(Calendar);
            Controls.Add(support);
            Controls.Add(Languages);
            Controls.Add(btnReport);
            Controls.Add(btnEvents);
            Controls.Add(btnServices);
            Controls.Add(btnExit);
            Name = "MainMenu";
            Text = "Main Menu";

            ((System.ComponentModel.ISupportInitialize)writing).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)support).EndInit();
            ResumeLayout(false);
        }

        // 🧾 Opens Report Issues Form
        private void btnReport_Click(object sender, EventArgs e)
        {
            reportIssues1 reportForm = new reportIssues1();
            reportForm.Show();
            this.Hide();
        }

        // 📅 Opens Local Events Form
        private void btnEvents_Click(object sender, EventArgs e)
        {
            LocalEvents eventsForm = new LocalEvents();
            eventsForm.Show();
            this.Hide();
        }

        // ❌ Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 🌍 Language Switcher
        private void ChangeLanguage(string langCode)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(langCode);
                Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing language: {ex.Message}");
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            // Add service logic later
        }

        private void support_Click(object sender, EventArgs e)
        {
            // Add support logic later
        }

        private void writing_Click(object sender, EventArgs e)
        {
            // Add writing logic later
        }

        private void Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Languages.SelectedItem != null)
            {
                string selectedLanguage = Languages.SelectedItem.ToString()!;
                string cultureCode = selectedLanguage switch
                {
                    "isiZulu" => "zu-ZA",
                    "Afrikaans" => "af-ZA",
                    _ => "en-US"
                };
                ChangeLanguage(cultureCode);
            }
            else
            {
                MessageBox.Show("Please select a valid language.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            // Add calendar click logic
        }
    }
}
