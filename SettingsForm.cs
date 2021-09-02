using System;
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
            MessageBox.Show("test");
        }
    }
}
