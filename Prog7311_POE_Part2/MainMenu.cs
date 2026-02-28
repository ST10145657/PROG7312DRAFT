using Prog7312_POE_Part2.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Prog7312_POE_Part2
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

        public event Action<string>? LanguageChanged;
        private string currentCultureCode = "en-US";

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
            // 
            // Languages
            // 
            Languages.BackColor = Color.White;
            Languages.BorderStyle = BorderStyle.FixedSingle;
            Languages.FormattingEnabled = true;
            Languages.Items.AddRange(new object[] { "English", "isiZulu", "Afrikaans" });
            Languages.Location = new Point(12, 25);
            Languages.Name = "Languages";
            Languages.Size = new Size(120, 77);
            Languages.TabIndex = 3;
            Languages.SelectedIndexChanged += Languages_SelectedIndexChanged;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(128, 128, 255);
            btnReport.Location = new Point(86, 237);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(200, 50);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report Issues";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = Color.FromArgb(0, 192, 0);
            btnEvents.Location = new Point(437, 237);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(200, 50);
            btnEvents.TabIndex = 5;
            btnEvents.Text = "Local Events & Announcements";
            btnEvents.UseVisualStyleBackColor = false;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(0, 192, 192);
            btnServices.Location = new Point(786, 237);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(200, 50);
            btnServices.TabIndex = 6;
            btnServices.Text = "Services Request Status";
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(418, 386);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 50);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // writing
            // 
            writing.Image = Prog7312_POE_Part2.Properties.Resources.writing;
            writing.Location = new Point(119, 119);
            writing.Name = "writing";
            writing.Size = new Size(136, 112);
            writing.SizeMode = PictureBoxSizeMode.StretchImage;
            writing.TabIndex = 0;
            writing.TabStop = false;
            writing.Click += writing_Click;
            // 
            // Calendar
            // 
            Calendar.Image = Prog7312_POE_Part2.Properties.Resources.calendar;
            Calendar.Location = new Point(470, 119);
            Calendar.Name = "Calendar";
            Calendar.Size = new Size(135, 112);
            Calendar.SizeMode = PictureBoxSizeMode.StretchImage;
            Calendar.TabIndex = 1;
            Calendar.TabStop = false;
            Calendar.Click += Calendar_Click;
            // 
            // support
            // 
            support.Image = Prog7312_POE_Part2.Properties.Resources.support;
            support.Location = new Point(820, 119);
            support.Name = "support";
            support.Size = new Size(135, 112);
            support.SizeMode = PictureBoxSizeMode.StretchImage;
            support.TabIndex = 2;
            support.TabStop = false;
            support.Click += support_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1024, 473);
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
            TransparencyKey = Color.FromArgb(255, 224, 192);
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)writing).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)support).EndInit();
            ResumeLayout(false);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (Languages.Items.Count > 0)
                Languages.SelectedIndex = 0;
        }

        private void ChangeLanguage(string langCode)
        {
            if (DesignMode) return;

            currentCultureCode = langCode;

            btnReport.Text = langCode == "zu-ZA" ? "Bika Izinkinga" : langCode == "af-ZA" ? "Rapporteer Probleme" : "Report Issues";
            btnEvents.Text = langCode == "zu-ZA" ? "Imicimbi" : langCode == "af-ZA" ? "Gebeurtenisse" : "Local Events";
            btnServices.Text = langCode == "zu-ZA" ? "Izinsizakalo" : langCode == "af-ZA" ? "Dienste" : "Services";
            btnExit.Text = langCode == "zu-ZA" ? "Phuma" : langCode == "af-ZA" ? "Afsluit" : "Exit";

            // Notify all child forms
            LanguageChanged?.Invoke(langCode);
        }

        private void Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesignMode || Languages.SelectedItem == null) return;

            string cultureCode = Languages.SelectedItem.ToString() switch
            {
                "isiZulu" => "zu-ZA",
                "Afrikaans" => "af-ZA",
                _ => "en-US"
            };
            ChangeLanguage(cultureCode);
        }

        // Button Handlers
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var reportForm = new reportIssues1();
            reportForm.CurrentCultureCode = currentCultureCode;
            reportForm.ChangeLanguage(currentCultureCode);

            LanguageChanged += reportForm.ChangeLanguage;

            reportForm.Show();
            Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var eventsForm = new LocalEvents();
            eventsForm.CurrentCultureCode = currentCultureCode;
            eventsForm.ChangeLanguage(currentCultureCode);

            LanguageChanged += eventsForm.ChangeLanguage;

            eventsForm.Show();
            Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var servicesForm = new ServicesRequestStatus();
            servicesForm.CurrentCultureCode = currentCultureCode;
            servicesForm.ChangeLanguage(currentCultureCode);

            LanguageChanged += servicesForm.ChangeLanguage;

            servicesForm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) { if (DesignMode) return; Application.Exit(); }

        private void support_Click(object sender, EventArgs e) { if (DesignMode) return; }
        private void writing_Click(object sender, EventArgs e) { if (DesignMode) return; }
        private void Calendar_Click(object sender, EventArgs e) { if (DesignMode) return; }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!DesignMode) Application.Exit();
        }


    }
}
