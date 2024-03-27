//cliente.nome = "Macoratti";

class Cliente
{
    public string nome;

    public Cliente(string nome, int idade)
    {
        this.nome = nome;
    }

    public void Saudacao()
    {
        Console.WriteLine($"Olá, meu nome é: {nome}");
    }
}