using System;
using System.Collections.Generic;
using clases;
using estructuras;


namespace chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }

        static void MockTestA()
        {
            Console.WriteLine("*** Clases en C# ***");
            Modelo modeloA = new Modelo();
            modeloA.Nombre = "MJ45-3321";
            Modelo modeloB = new Modelo("MX23-2100");
            List<Modelo> modelos = new List<Modelo>{modeloA, modeloB, new Modelo("MX66-0092")};
            foreach(var modelo in modelos)
            {
                Console.WriteLine("{0}",modelo.GetModelo());
            }
            
            Console.WriteLine();
            modeloA.Mostrar();
            modeloB.Mostrar();
            modelos[2].Mostrar();

            string iguales = "";
            if(modeloB.Equals(modeloA)){
                iguales = modeloB.GetType() 
                +" A es igual a "
                +modeloA.GetType()+ " B ";
            }else{
                iguales = modeloB.GetType() 
                +" A no es igual a "
                +modeloA.GetType()+" B ";
            }
            Console.WriteLine("{0}",iguales);

            Dictionary<int,Modelo> mapaModelo = new Dictionary<int, Modelo>();
            mapaModelo.Add(1,modeloA);
            mapaModelo.Add(2,modeloB);
            mapaModelo.Add(3,modelos[2]);
            Console.WriteLine();
            foreach (var articulo in mapaModelo)
            {
                Console.WriteLine("{0} : {1}", articulo.Key, articulo.Value);
            }

            if (mapaModelo.ContainsKey(2))
            {
                Console.WriteLine("Contiene la llave 2");
            }

            if(mapaModelo.ContainsValue(modeloA))
            {
                Console.WriteLine("Contiene modeloA.Nombre: MJ45-3321");   
            }

            var tipoMapaModelo = mapaModelo.GetType();
            Console.WriteLine("Tipo: {0}",tipoMapaModelo);

            var tipoModelo = modeloA.GetType();
            Console.WriteLine("Tipo: {0}",tipoModelo);

            Numero myNumA = new Numero(1,"Uno");
            Console.WriteLine("{0}",myNumA.GetNumero());
            myNumA.Valor=2;
            myNumA.Nombre="Dos";
            Console.WriteLine("{0}",myNumA.GetNumero());

            var tipoNum = myNumA.GetType();
            Console.WriteLine("Tipo: {0}",tipoNum);


        }
    }
}
