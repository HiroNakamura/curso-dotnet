using System;
using System.IO;
using clases;

namespace chapter8
{
    class Program
    {
        public static readonly string PATH = @"C:\\Users\\DELL\\Documents\\programacion\\testRepositories\\curso-dotnet\\temario\\chapter8\\datos.csv";

        public static readonly string RUTA = @"C:\\Users\\DELL\\Documents\\programacion\\testRepositories\\curso-dotnet\\temario\\chapter8\\datos.dat";
        

        static void Main(string[] args)
        {
            TestMockA();
            TestMockB();
        }

        static void EscribiendoLeyendoArch(string archivo)
        {
            if (!File.Exists(archivo))
            {
                using (StreamWriter sw = File.CreateText(archivo))
                {
                    sw.WriteLine("1. El color no tiene forma.");
                    sw.WriteLine("2. Torre oscura: Resurección.");
                    sw.WriteLine("3. El Cabalista de Lisboa.");
                }
            }
            
            using (StreamReader sr = File.OpenText(archivo))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("Hemos terminado de procesar archivo");
        }

        static void EscribiendoArch(string archivo) {
            FileStream F = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            Console.WriteLine("1. Escribiendo archivo...");
            
            for(int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            
            F.Position = 0;

            Console.WriteLine("2. Leyendo archivo...");
            
            for(int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            
            F.Close();
            Console.ReadKey();
        }

        static void TestMockB()
        {
            if(File.Exists(RUTA))
            {
                EscribiendoArch(RUTA);
            }
        }

        static void TestMockA()
        {
            Console.WriteLine("*** File in C# ***");
            var myFile = new MyFile();

            if(File.Exists(PATH))
            {
                myFile.Existe = true;
            }

            myFile.Nombre = PATH;
            DateTime fechaActualizacion = File.GetLastAccessTime(PATH);
            myFile.UltimoAcceso = fechaActualizacion;
            Console.WriteLine("{0}",myFile);

            Console.WriteLine("Leyendo contenido...");
            using (StreamReader sr = File.OpenText(myFile.Nombre)){
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }



        }
    }
}
