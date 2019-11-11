using System;

namespace estructuras
{
    struct Fecha
    {
        public Fecha(int anyo, int mes, int dia, int hora,int minutos, int segundos){
            Mes = mes;
            Anyo = anyo;
            Dia = dia;
            Hora = hora;
            Minutos = minutos;
            Segundos = segundos;
            Console.WriteLine("Estructura Fecha creada");
        }
        
        public int Anyo
        {
            get;set;
        }

        public int Mes
        {
            get;set;
        }
        
        public int Dia
        {
           get; set;
        }
        
        public int Hora
        {
           get; set;
        }
        
        public int Minutos
        {
           get; set;
        }
        
        public int Segundos
        {
           get; set;
        }
        
      
        public string GetFecha()
        {
            return Anyo + " - " + Mes+" - "+Dia+" | "+Hora+":"+Minutos+":"+Segundos;
        }

    }
}
