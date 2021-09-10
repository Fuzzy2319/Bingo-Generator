﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibBingo;

namespace Bingo_Generator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            this.InitializeComponent();
            this.btnGenerate.BringToFront();
            this.lsbLogic.SelectedIndex = 0;
            this.sfdOutput.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            foreach (Category category in CategoryFactory.Categories)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Checked = category.IsActive;
                checkBox.CheckedChanged += CategoryFactory.ChangeCategoryState;
                checkBox.CheckedChanged += this.ChangeEnableState;
                checkBox.Enabled = category.Parent == null ? true : false;
                checkBox.Size = new Size((int)(this.Width / 3.27f), this.Height / 20);
                checkBox.Text = category.Name;

                this.flpMain.Controls.Add(checkBox);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.sfdOutput.FileName = DateTime.Now.ToString("yyMMdd-hhmmss") + "_bingo";
            List<Check> possibleChecks = CheckFactory.Checks.FindAll(check => check.Category.IsActive);

            if (possibleChecks.Count < 25)
            {
                MessageBox.Show("Insufficient number of checks\nPlease select other settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string output = Logic.NoLimit(possibleChecks);

                if (this.sfdOutput.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(this.sfdOutput.FileName, output);
                    Clipboard.SetText(output);

                    MessageBox.Show("Grid successfuly generated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ChangeEnableState(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in this.flpMain.Controls)
            {
                Category category = CategoryFactory.Categories.Find(categ => categ.Name == checkBox.Text);
                checkBox.Enabled = category.Parent == null ? true : category.Parent.IsActive;
            }
        }
    }
}
