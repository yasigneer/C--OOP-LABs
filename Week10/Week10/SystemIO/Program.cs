using System;
using System.IO;
using System.Text;
using System.Xml;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = $@"d:\myfile.txt";
            var myText = "How are you Elif?";

            //// FileStream fs = new FileStream(path, FileMode.Create);  
            //FileStream fs = new FileStream(path, FileMode.Open);

            //byte[] bytesOfMyFile = Encoding.Default.GetBytes(myText);

            //fs.Write(bytesOfMyFile,0, bytesOfMyFile.Length);

            //fs.Close();

            //FileStream fs1 = new FileStream(path, FileMode.Open);

            //StreamReader reader = new StreamReader(fs1);

            //var readText = reader.ReadToEnd();

            //Console.WriteLine(readText);

            //StreamWriter sw = new StreamWriter(path);

            //sw.Write("Hello ");
            //sw.Write("How Are You? ");
            //sw.Write("I am ok! ");

            //sw.Close();

            //StreamReader sr = new StreamReader(path);

            //var result = sr.ReadToEnd(); 

            //sw.Close();

            //Console.WriteLine(result);


            //TextWriter tw = File.CreateText(path);
            //tw.Write("Hello, ");
            //tw.Write("How are you ");
            //tw.Close();

            //TextReader tr = File.OpenText(path);
            //Console.WriteLine(tr.ReadToEnd());
            //tr.Close();


            //BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));

            //bw.Write("Hello ");
            //bw.Write("How are you");

            //bw.Close();

            //BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(br.ReadString());
            //}

            //br.Close();

            //StringBuilder sb = new StringBuilder();
            //StringWriter sw = new StringWriter(sb);
            //sw.WriteLine("Hello how are you 1");
            //sw.WriteLine("Hello how are you 2");
            //sw.Flush();
            //sw.Close();

            //StringReader sr = new StringReader(sb.ToString());

            //while (sr.Peek()>-1)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}


            //Directory.CreateDirectory(@"D:\MyDirectory");
            //Directory.Delete(@"D:\MyDirectory",true);

            //if (!Directory.Exists(@"D:\MyDirectory"))
            //{
            //    Directory.CreateDirectory(@"D:\MyDirectory");
            //}

            //var directories= Directory.GetDirectories(@"D:\","*a*");

            // foreach (var name in directories)
            // {
            //     Console.WriteLine(name);
            // }

            //var list = Directory.GetFiles(@"D:\MyProjects", "*",SearchOption.AllDirectories);

            // foreach (var name in list)
            // {
            //     Console.WriteLine(name);
            // }

            //FileInfo fi = new FileInfo(@"D:\myfile.txt");
            //Console.WriteLine(fi.Extension);
            //Console.WriteLine(fi.CreationTime);
            //Console.WriteLine(fi.Directory);
            //Console.WriteLine(fi.FullName);
            //Console.WriteLine(fi.Length);

            // DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\MyProjects");

            // Console.WriteLine(directoryInfo.Parent);
            // Console.WriteLine(directoryInfo.Exists);

            // Console.WriteLine(directoryInfo.Name);
            // Console.WriteLine(directoryInfo.GetDirectories()[0]);
            //// Console.WriteLine(directoryInfo.GetFiles("*")[0]);


            FileSystemWatcher fsw = new FileSystemWatcher(@"D:\");

            //fsw.EnableRaisingEvents = true;

            //fsw.Changed += Fsw_Changed;


            fsw.Renamed += Fsw_Renamed; ;

            new System.Threading.AutoResetEvent(false).WaitOne();
        }

        private static void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine(e.OldName + "-->" + e.Name);
        }

        private static void Fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + "Deleted " + DateTime.Now);
        }

        private static void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Changed"+e.FullPath);
        }
    }
}
