using System;
using System.Collections.Generic;
using clases;
using estructuras;
using interfaces;

namespace chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
            MockTestB();
            MockTestC();
        }

        static void MockTestC()
        {
            Oviparo perdigi = new Oviparo("Esteban");
            Console.WriteLine();
            Canario canario = new Canario("Ernesto");
        }

        static void MockTestB()
        {
            var servicioAImpl = new ServicioAImpl();
            servicioAImpl.X = 32;
            servicioAImpl.Y = 1;
            servicioAImpl.Mostrar();

            ServicioAImpl otroServicioAImpl = new ServicioAImpl(6,43);
            otroServicioAImpl.Mostrar();

            ServicioCImpl servicio = new ServicioCImpl();
            ContenedorC contenedor = new ContenedorC(servicio);
            contenedor.Saludar();

            ServicioDImpl servicioDImpl = new ServicioDImpl();
            var modelo = new Modelo("El general Urchate");
            servicioDImpl.GetModelo = modelo;
            servicioDImpl.Datos();
            Console.WriteLine("55+8 = {0}",servicioDImpl.Operacion(55,8));
            
            const int TAM = 4;
            var myNumeroX = new Numero(11,"FELIX");
            var myNumeroY = new Numero(17,"BILL");
            Numero[] mysNumeros = new Numero[TAM];
            mysNumeros[0] = myNumeroX;
            mysNumeros[1] = myNumeroY;
            mysNumeros[2] = new Numero(25,"FOXY");
            mysNumeros[3] = new Numero(12,"TOM");

            var cnt = TAM;
            while(cnt-- >0)
            {
                Console.WriteLine("{0}",mysNumeros[cnt].GetNumero());
            }

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

            SuperModelo superModelo = new SuperModelo();
            superModelo.Nombre = "Super Modelo";
            List<string> telefonos = new List<string>();
            telefonos.Add("7221339090");
            telefonos.Add("7221009030");
            telefonos.Add("7221222580");
            telefonos.Add("7221013232");
            superModelo.GetLista = telefonos;
            superModelo.Mostrar();
        }
    }
}
