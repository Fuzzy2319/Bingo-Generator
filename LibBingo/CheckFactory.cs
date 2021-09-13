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

            string checksDir = @".\Checks\";

            foreach (string file in Directory.EnumerateFiles(checksDir))
            {
                Category category = CategoryFactory.Categories.Find(categ => categ.Name == Path.GetFileNameWithoutExtension(file));
                string[] lines = File.ReadLines(file).ToArray();

                for (int ind = 1; ind < lines.Length; ind +=1)
                {
                    CheckFactory.checks.Add(new Check(lines[ind], category));
                }
            }
        }
    }
}
