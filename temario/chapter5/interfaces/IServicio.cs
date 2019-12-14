namespace interfaces
{
    public interface IServicio
    {
        void Mensaje();
        void Mensaje(string msg);
        bool Mensaje(string msg, char car);
        int Mensaje(char c);
    }
}