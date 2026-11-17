using System.Collections.Generic;
using System.IO;

namespace ExempluDate
{
    public static class Date
    {
        public static List<Planeta> CitestePlanete(string cale, List<string> erori)
        {
            List<Planeta> planete = new List<Planeta>();
            if (!File.Exists(cale))
            {
                erori.Add("Lipseste fisierul " + Path.GetFileName(cale) + " de langa aplicatie.");
                return planete;
            }

            string[] linii = File.ReadAllLines(cale);
            for (int i = 1; i < linii.Length; i++)
            {
                if (linii[i].Trim().Length == 0)
                {
                    continue;
                }

                string[] camp = linii[i].Split('#');
                int id, x, y;
                if (camp.Length != 7 || !int.TryParse(camp[0], out id)
                    || !int.TryParse(camp[2], out x) || !int.TryParse(camp[3], out y))
                {
                    erori.Add("Randul " + (i + 1) + " este stricat si a fost sarit.");
                    continue;
                }

                planete.Add(new Planeta
                {
                    Id = id,
                    Nume = camp[1],
                    X = x,
                    Y = y,
                    AreApa = camp[4] == "1",
                    AreRadiatii = camp[5] == "1",
                    Descriere = camp[6]
                });
            }
            return planete;
        }
    }
}
