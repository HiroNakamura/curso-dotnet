# Herencia en C#

Crear clases derivadas de otras ya existentes.

Ejemplo de herencia.

```java
using System;

class Mamifero
{
   public Mamifero
   {
     Console.WriteLine("Se ha creado e inicializado objeto Mamifero");
   }
   
   ~Mamifero(){}
   
   public override string ToString()
   {
     return "Mamifero";
   }
}

class Delfin:Mamifero
{

 public Delfin:base()
   {
     Console.WriteLine("Se ha creado e inicializado objeto Delfin");
   }
   
   ~Delfin(){}
   
   public override string ToString()
   {
     return base.ToString()+"::Delfin";
   }


}

class Gato:Mamifero
{

   public Gato
   {
     Console.WriteLine("Se ha creado e inicializado objeto Gato");
   }
   
   ~Gato(){}
   
   public override string ToString()
   {
     return base.ToString()+"::Gato";
   }


}


```
