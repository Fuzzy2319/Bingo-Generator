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
            foreach(Check check in CheckFactory.Checks)
            {
                MessageBox.Show(check.Name, check.Category);
            }
        }
    }
}
