namespace estructuras
{
    struct Numero
    {
        public Numero(int valor, string nombre){
            Valor = valor;
            Nombre = nombre;
        }
        
        public int Valor
        {
            get;set;
        }

        public string Nombre
        {
            get;set;
        }

        public string GetNumero()
        {
            return Nombre + " : " + Valor;
        }

    }
}