using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7311_POE_Part2
{
    public partial class reportIssues1 : Form
    {
        public reportIssues1() 
        {
            InitializeComponent();

        }


        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 25;
            if (cmbCategory.SelectedIndex != -1) progress += 25;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) progress += 25;
            if (!string.IsNullOrWhiteSpace(lblAttachment.Text) && lblAttachment.Text != "No file attached") progress += 25;

            progressBar.Value = progress;
        }

        private void txtLocation_TextChanged_1(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rtbDescription_TextChanged_1(object sender, EventArgs e)
        {
            UpdateProgress();
        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please complete all fields before submitting.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IssueReport issue = new IssueReport
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem?.ToString(),
                Description = rtbDescription.Text,
                AttachmentPath = lblAttachment.Text
            };

            MessageBox.Show("Issue submitted:\n" +
                            $"Location: {issue.Location}\n" +
                            $"Category: {issue.Category}\n" +
                            $"Description: {issue.Description}\n" +
                            $"Attachment: {issue.AttachmentPath}",
                            "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset after submission
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachment.Text = "No file attached";
            progressBar.Value = 0;
        }


        private void progressBar_Click(object sender, EventArgs e)
        {
            // Nothing needed here (progress updated automatically)
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




        private void btnAttach_Click(object sender, EventArgs e)
        {
            btnAttach_Click_1(sender, e);
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
