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

     public override string ToString()
     {
        return string.Format("{0} {1}",Nombre, Ingreso);
     }


   }
}
