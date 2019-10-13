using System;

namespace clases
{
   class Empleado
   {
   
     public Empleado(){}
     
     public Empleado(string nombre, DateTime ingreso)
     {
        Nombre = nombre;
        Ingreso = ingreso;
     }
     
     ~Empleado(){}
     
     
     
     public string Nombre
     {
        get; set;
     }
     
     public DateTime Ingreso
     {
       get; set;
     }
   }
}
