using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibBingo
{
    public class Logic
    {
        public static string GenerateOutput(List<Check> possibleChecks)
        {
            Random random = new Random();
            CheckMin[] checks = new CheckMin[25];

            for (int ind = 0; ind < 25; ind += 1)
            {
                int checkInd = random.Next(possibleChecks.Count);

                checks[ind] = new CheckMin(possibleChecks[checkInd].Name);

                possibleChecks.RemoveAt(checkInd);
            }

            return JsonConvert.SerializeObject(checks);
        }

        public static List<Check> Normal(List<Check> possibleChecks)
        {
            if (possibleChecks.Exists(check => check.Category.Name == "Dungeons"))
            {
                Random random = new Random();
                int count = random.Next(3, 8);
                List<Check> dungeonsChecks = possibleChecks.FindAll(check => check.Category.Name == "Dungeons");
                Check[] dungeonsPossibleChecks = new Check[count];

                for (int ind = 0; ind < count; ind += 1)
                {
                    int checkInd = random.Next(dungeonsChecks.Count);

                    dungeonsPossibleChecks[ind] = dungeonsChecks[checkInd];

                    dungeonsChecks.RemoveAt(checkInd);
                }

                possibleChecks.RemoveAll(check => check.Category.Name == "Dungeons");
                possibleChecks.AddRange(dungeonsPossibleChecks);
            }

            if (possibleChecks.Exists(check => check.Category.Name == "Sunken Treasure (Triforce)"))
            {
                Random random = new Random();
                int count = random.Next(2);
                List<Check> sunkenTreasureTriforceChecks = possibleChecks.FindAll(check => check.Category.Name == "Sunken Treasure (Triforce)");

                if (count == 1)
                {
                    int checkInd = random.Next(sunkenTreasureTriforceChecks.Count);

                    Check sunkenTreasureTriforcePossibleCheck = sunkenTreasureTriforceChecks[checkInd];

                    possibleChecks.RemoveAll(check => check.Category.Name == "Sunken Treasure (Triforce)");
                    possibleChecks.Add(sunkenTreasureTriforcePossibleCheck);
                }
                else
                {
                    possibleChecks.RemoveAll(check => check.Category.Name == "Sunken Treasure (Triforce)");
                }
            }

            if (possibleChecks.Exists(check => check.Category.Name == "Sunken Treasure"))
            {
                Random random = new Random();
                int count = random.Next(4);
                List<Check> sunkenTreasureChecks = possibleChecks.FindAll(check => check.Category.Name == "Sunken Treasure");

                if (count >= 1)
                {
                    Check[] sunkenTreasurePossibleChecks = new Check[count];
                    for (int ind = 0; ind < count; ind += 1)
                    {
                        int checkInd = random.Next(sunkenTreasureChecks.Count);

                        sunkenTreasurePossibleChecks[ind] = sunkenTreasureChecks[checkInd];

                        sunkenTreasureChecks.RemoveAt(checkInd);
                    }

                    possibleChecks.RemoveAll(check => check.Category.Name == "Sunken Treasure");
                    possibleChecks.AddRange(sunkenTreasurePossibleChecks);
                }
                else
                {
                    possibleChecks.RemoveAll(check => check.Category.Name == "Sunken Treasure");
                }
            }

            return possibleChecks;
        }

        public static List<Check> RaceMode(List<Check> possibleChecks)
        {
            return possibleChecks;
        }
    }
}
