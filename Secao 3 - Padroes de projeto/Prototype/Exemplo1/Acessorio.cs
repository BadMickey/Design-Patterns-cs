namespace Exemplo1
{
    public class Acessorio
    {
        public string Nome { get; set; }

        public Acessorio Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}
