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
using Newtonsoft.Json;

namespace Bingo_Generator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.btnGenerate.BringToFront();

            foreach (Category category in CategoryFactory.Categories)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = category.Name;
                checkBox.Checked = category.IsActive;
                checkBox.CheckedChanged += CategoryFactory.ChangeCategoryState;

                this.flpMain.Controls.Add(checkBox);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<Check> possibleChecks = CheckFactory.Checks.FindAll(check => check.Category.IsActive);

            if (possibleChecks.Count < 25)
            {
                MessageBox.Show("Insufficient number of checks\nPlease select other settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Random random = new Random();
                CheckMin[] checks = new CheckMin[25];

                for (int ind = 0; ind < 25; ind += 1)
                {
                    int checkInd = random.Next(possibleChecks.Count);

                    checks[ind] = new CheckMin(possibleChecks[checkInd].Name);

                    possibleChecks.RemoveAt(checkInd);
                }

                Clipboard.SetText(JsonConvert.SerializeObject(checks, Formatting.Indented));
            }
        }
    }
}
