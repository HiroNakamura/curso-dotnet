using System;

namespace clases
{
  public class MyFile
  {
  
      public string Nombre
      {
        get;set;
      }

      public string Directorio
      {
        get;set;
      }

      public DateTime UltimoAcceso
      {
        get;set;
      }

      public bool Existe
      {
        get;set;
      }
      public MyFile(){
        Console.WriteLine("Objeto MyFile creado e inicializado");
      }

      public MyFile(string nombre, DateTime ultimoAcceso, bool existe, string directorio):base()
      {
        Nombre = nombre;
        UltimoAcceso = ultimoAcceso;
        Existe = existe;
        Directorio = directorio;
      }
      
      ~MyFile(){}

      public override string ToString()
      {
        string result = Existe==true? "existe" : "no existe"; 
        return String.Format("El archivo {0} {1} , el ultimo acceso fue el {2}, Directorio = {3}",Nombre,result,UltimoAcceso,Directorio);
      }
  }
}
