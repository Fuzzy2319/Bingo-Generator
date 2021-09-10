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
        public static string NoLimit(List<Check> possibleChecks)
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
    }
}
