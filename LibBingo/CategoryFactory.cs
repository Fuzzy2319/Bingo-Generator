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

            string checksDir = @".\Checks\";

            foreach (string file in Directory.EnumerateFiles(checksDir).Where(file => file.EndsWith(".bgc")))
            {
                CategoryFactory.categories.Add(new Category(Path.GetFileNameWithoutExtension(file)));
            }
            int ind = 0;
            foreach (string file in Directory.EnumerateFiles(checksDir))
            {
                string parentCateg = File.ReadLines(file).First().Replace("#require ", "");

                if (parentCateg != "none")
                {
                    CategoryFactory.categories[ind].SetParent(CategoryFactory.categories.Find(category => category.Name == Path.GetFileNameWithoutExtension(parentCateg)));
                }

                ind += 1;
            }
        }


        public static void ChangeCategoryState(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Category category = CategoryFactory.categories.Find(categ => categ.Name == checkBox.Text);
            category.IsActive = checkBox.Checked;
        }
    }
}
