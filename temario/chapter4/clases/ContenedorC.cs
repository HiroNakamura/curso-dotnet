using interfaces;

namespace clases
{
    class ContenedorC
    {
        public ContenedorC(ServicioC servicioC)
        {
            MiServicioC = servicioC;
        }

        public ServicioC MiServicioC
        {
            get;set;
        }

        public void Saludar()
        {
            MiServicioC.Saludar();
        }
    }
}