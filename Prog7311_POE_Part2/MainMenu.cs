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
        private Label label1;

        public event Action<string>? LanguageChanged;
        private string currentCultureCode = "en-US";

        public MainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //ListBox Languages;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            btnReport = new Button();
            btnEvents = new Button();
            btnServices = new Button();
            btnExit = new Button();
            writing = new PictureBox();
            Calendar = new PictureBox();
            support = new PictureBox();
            label1 = new Label();
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
            Languages.Items.AddRange(new object[] { resources.GetString("Languages.Items"), resources.GetString("Languages.Items1"), resources.GetString("Languages.Items2") });
            resources.ApplyResources(Languages, "Languages");
            Languages.Name = "Languages";
            Languages.SelectedIndexChanged += Languages_SelectedIndexChanged;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(128, 128, 255);
            resources.ApplyResources(btnReport, "btnReport");
            btnReport.Name = "btnReport";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = Color.FromArgb(0, 192, 0);
            resources.ApplyResources(btnEvents, "btnEvents");
            btnEvents.Name = "btnEvents";
            btnEvents.UseVisualStyleBackColor = false;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(btnServices, "btnServices");
            btnServices.Name = "btnServices";
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // writing
            // 
            resources.ApplyResources(writing, "writing");
            writing.Name = "writing";
            writing.TabStop = false;
            writing.Click += writing_Click;
            // 
            // Calendar
            // 
            resources.ApplyResources(Calendar, "Calendar");
            Calendar.Name = "Calendar";
            Calendar.TabStop = false;
            Calendar.Click += Calendar_Click;
            // 
            // support
            // 
            resources.ApplyResources(support, "support");
            support.Name = "support";
            support.TabStop = false;
            support.Click += support_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Gray;
            label1.Name = "label1";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(label1);
            Controls.Add(writing);
            Controls.Add(Calendar);
            Controls.Add(support);
            Controls.Add(Languages);
            Controls.Add(btnReport);
            Controls.Add(btnEvents);
            Controls.Add(btnServices);
            Controls.Add(btnExit);
            Name = "MainMenu";
            TransparencyKey = Color.FromArgb(255, 224, 192);
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)writing).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)support).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (Languages != null && Languages.Items.Count > 0)
                Languages.SelectedIndex = 0;
            SharedData.SharedServiceRequests.InitializeSampleData();
        }

        private void ChangeLanguage(string cultureCode)
        {
            if (DesignMode) return;

            currentCultureCode = cultureCode;

            // 🔹 THIS IS WHAT YOU WERE MISSING
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureCode);



            Controls.Clear();
            InitializeComponent();
        }

        private void Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Languages.SelectedIndex == -1)
                return;

            if (Languages.SelectedIndex == -1)
                return;

            string culture = "en-ZA"; // default

            switch (Languages.SelectedIndex)
            {
                case 0:
                    culture = "en-ZA";
                    break;
                case 1:
                    culture = "zu-ZA";
                    break;
                case 2:
                    culture = "af-ZA";
                    break;
            }

            ChangeLanguage(culture);
        }

        // Button Handlers
        private void btnReport_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentCultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(currentCultureCode);

            var reportForm = new reportIssues1();
            

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
