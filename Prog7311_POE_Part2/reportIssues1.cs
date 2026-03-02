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
    public partial class reportIssues1 : Form
    {

        public reportIssues1()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[]
            {
                "Sanitation",
                "Road",
                "Utilities",
                "Electricity",
                "Water",
                "Public Safety"
            });
        }

        private void UpdateProgress()
        {
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(txtTitle.Text)) progress += 20;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 25;
            if (cmbCategory.SelectedIndex != -1) progress += 25;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) progress += 25;
            if (!string.IsNullOrWhiteSpace(lblAttachment.Text) && lblAttachment.Text != "No file attached") progress += 25;

            if (progress > progressBar.Maximum)
                progress = progressBar.Maximum;

            progressBar.Value = progress;
        }


        private void txtLocation_TextChanged_1(object sender, EventArgs e) => UpdateProgress();
        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e) => UpdateProgress();
        private void rtbDescription_TextChanged_1(object sender, EventArgs e) => UpdateProgress();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please complete all fields before submitting.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new issue object
            IssueReport issue = new IssueReport
            {
                Title = txtTitle.Text,
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem?.ToString(),
                Description = rtbDescription.Text,
                AttachmentPath = lblAttachment.Text
            };

            // ✅ Save issue into shared list so LocalEvents can access it
           ReportedIssues.Add(issue);

            int newId = SharedServiceRequests.GetNextId();
            var request = new ServiceRequest(
                id: newId,
                       Title: txtTitle.Text,
            location: txtLocation.Text,
            category: cmbCategory.SelectedItem?.ToString(),
            description: rtbDescription.Text,
            status: "Submitted",
            priority: 1 // can change later (1 = low, 5 = high)
            );

            SharedServiceRequests.AddRequest(request);

            MessageBox.Show("Issue submitted successfully!\n\n" +
                    $"Service Request ID: {request.ID}\n" +
                    $"Title: {request.Title}\n" +
                    $"Location: {request.Location}\n" +
                    $"Category: {request.Category}\n" +
                    $"Status: {request.Status}\n\n" +
                    "You can track this request in the Service Request Status screen.",
                    "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachment.Text = "No file attached";
            progressBar.Value = 0;
        }

        private void btnAttach_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png|Documents|*.pdf;*.docx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblAttachment.Text = ofd.FileName;
                    UpdateProgress();
                }
            }
        }

        private void btnAttach_Click(object sender, EventArgs e) => btnAttach_Click_1(sender, e);

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void reportIssues1_Load(object sender, EventArgs e)
        {

        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CurrentCultureCode { get; set; } = "en-US";

        public void ChangeLanguage(string langCode)
        {
            CurrentCultureCode = langCode;
            // Update all button/label texts based on langCode
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }
        
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}