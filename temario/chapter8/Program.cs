using System;
using System.IO;
using clases;

namespace chapter8
{
    class Program
    {
        public static readonly string PATH = @"C:\\Users\\DELL\\Documents\\programacion\\testRepositories\\curso-dotnet\\temario\\chapter8\\datos.csv";
        static void Main(string[] args)
        {
            TestMockA();
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
