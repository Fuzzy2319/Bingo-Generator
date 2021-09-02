using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibBingo
{
    public class CategoryFactory
    {
        private static List<Category> categories;

        public static List<Category> Categories { get => categories; }

        static CategoryFactory()
        {
            CategoryFactory.categories = new List<Category>();

            string checksDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bingo Generator\Checks\";

            foreach (string file in Directory.EnumerateFiles(checksDir))
            {
                CategoryFactory.categories.Add(new Category(Path.GetFileNameWithoutExtension(file)));
            }
        }


        public static void ChangeCategoryState(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Category category = CategoryFactory.Categories.Find(categ => categ.Name == checkBox.Text);
            category.IsActive = checkBox.Checked;
        }
    }
}
