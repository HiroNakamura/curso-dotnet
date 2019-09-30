using System;

namespace clases
{
  public class MyFile
  {
  
      public string Nombre
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

      public MyFile(string nombre, DateTime ultimoAcceso, bool existe):base()
      {
        Nombre = nombre;
        UltimoAcceso = ultimoAcceso;
        Existe = existe;
      }
      
      ~MyFile(){}

      public override string ToString()
      {
        string result = Existe==true? "existe" : "no existe"; 
        return String.Format("El archivo {0} {1} , el ultimo acceso fue el {2}",Nombre,result,UltimoAcceso);
      }
  }
}
