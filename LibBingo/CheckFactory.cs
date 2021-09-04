using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibBingo
{
    public class CheckFactory
    {
        private static List<Check> checks;

        public static List<Check> Checks { get => checks; }

        static CheckFactory()
        {
            CheckFactory.checks = new List<Check>();

            string checksDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bingo Generator\Checks\";

            foreach (string file in Directory.EnumerateFiles(checksDir))
            {
                Category category = CategoryFactory.Categories.Find(categ => categ.Name == Path.GetFileNameWithoutExtension(file));

                foreach (string checkName in File.ReadLines(file))
                {
                    CheckFactory.checks.Add(new Check(checkName, category));
                }
            }
        }
    }
}
