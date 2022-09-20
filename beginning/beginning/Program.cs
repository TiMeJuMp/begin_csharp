using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");


            //fi.CopyTo("C:/050 Ausbilder/03 Ausbildung 2022/begin_csharp/beginning/beginning/meine_datei13.csv");
            //FileInfo fi_neu = new FileInfo("C:/050 Ausbilder/03 Ausbildung 2022/begin_csharp/beginning/beginning/meine_datei13.csv");
            //fi_neu.Delete();


            //Console.WriteLine("Gebe mir den pfad an, wohin die Datei geschrieben werden soll!");
            //string path = Console.ReadLine();
            //path = path.Replace("\\", "\\\\");
            //DirectoryInfo di = new DirectoryInfo(path.Replace("\\", "\\\\"));

            //while(di.Exists == false)
            //{
            //    Console.WriteLine("Dein Pfad existiert nicht, gib mir einen neuen!");
            //    path = Console.ReadLine();
            //    di = new DirectoryInfo(path.Replace("\\", "\\\\"));
            //}
            //Console.WriteLine("Wie soll die Datei heißen?");
            //string fileName = Console.ReadLine();

            //fi.CopyTo(path +"\\"+ fileName);

            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMIS-data.csv");

            //if(fi.Exists)
            //{
            //    //Execute only if file exists
            //    fi.CopyTo("C:/050 Ausbilder/03 Ausbildung 2022/begin_csharp/beginning/beginning/meine_datei13111.csv");
            //}

            string path = @"C:\050 Ausbilder\03 Ausbildung 2022\begin_csharp\beginning\beginning\meine_datei123.csv";
            StreamReader sr = new StreamReader(path);
            List<string[]> eintraege = new List<string[]>();
            //Remove Header
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                eintraege.Add(sr.ReadLine().Split(';'));
            }
            for (int j = 18; j < 101; j++)
            {
                using (StreamWriter writer = new StreamWriter($@"C:\050 Ausbilder\03 Ausbildung 2022\begin_csharp\Gewicht_{j}.csv", true))
                {
                    for (int i = 0; i < eintraege.Count; i++)
                    {
                        if (Convert.ToInt32(eintraege[i][2]) ==j)
                        {
                            writer.WriteLine(string.Join(";", eintraege[i]));
                            Console.WriteLine(string.Join("\t", eintraege[i]));
                        }
                    }
                }
            }

            Console.ReadLine();            
        }



        

    }
}
