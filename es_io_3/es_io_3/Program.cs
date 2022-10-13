using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace es_io_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            string[] linee = File.ReadAllLines("password.txt");
            string kiave;
            List<string> kiavi = new List<string>();
            List<string> password_singole = new List<string>();
            List<int> pos = new List<int>();
            List<int> top_5 = new List<int>();
            for (int i = 0; i < linee.Length; i++)
            {
                for (int j = 0; j < linee[i].Length; j++)
                {
                    if (linee[i][j] == '|')
                    {
                        kiave = linee[i].Substring(j + 1);
                        kiavi.Add(kiave);
                    }

                }
            }

            for (int i = 0; i < kiavi.Count; i++)
            {
                if (!ripetuta(kiavi, pos,i))
                {
                    password_singole[i] = kiavi[i];
                }
            }
            int[] 


            sw.Close();
            Console.ReadKey();
        }

        static bool ripetuta(List<string> kiavi, List<int> pos, int indiacatore)
        {
            for (int i = 0; i < kiavi.Count; i++)
            {
                if (kiavi[indiacatore] == kiavi[i])
                {
                    pos.Add(indiacatore);
                    return true;
                }
            }
            return false;

        }
    }
}
