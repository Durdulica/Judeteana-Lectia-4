using System;
using System.Collections.Generic;
using System.IO;

namespace Descoperiri
{
    public static class Date
    {
        public static List<Insula> CitesteInsule(string cale, List<string> erori)
        {
            List<Insula> lista = new List<Insula>();

            if (!File.Exists(cale))
            {
                erori.Add("Lipseste fisierul insule.txt de langa aplicatie.");
                return lista;
            }

            var reader = new StreamReader(cale);
            

            string linie = reader.ReadLine();
            int rand = 1;
            while ((linie = reader.ReadLine()) != null) 
            {
                Insula ins = new Insula();
                rand++;
                if (string.IsNullOrWhiteSpace(linie)) continue;
                string[] date = linie.Split('#');

                if(date.Length != 7)
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                }

                int aux;
                if(!Int32.TryParse(date[0], out aux))
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                }
                ins.Id = aux;
                ins.Nume = date[1];
                if(!Int32.TryParse(date[2], out aux))
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                }
                ins.X = aux;
                if (!Int32.TryParse(date[3], out aux))
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                }
                ins.Y = aux;

                if (!Int32.TryParse(date[4], out aux))
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                }
                if (aux == 0)
                {
                    ins.AreBogatii = false;
                }
                else if (aux == 1)
                {
                    ins.AreBogatii = true;
                }

                if (!Int32.TryParse(date[5], out aux))
                {
                    erori.Add("Randul " + rand + " este stricat si a fost sarit.");
                    continue;
                 
                }
                if(aux == 0)
                {
                    ins.AreVirusi = false;
                }
                else if (aux == 1)
                {
                    ins.AreVirusi = true;
                }

                ins.Descriere = date[6];
                lista.Add(ins);
            }

            reader.Close();
            return lista;
        }
    }
}
