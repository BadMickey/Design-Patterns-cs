using ComInterface;

var registraConsole =
    new RegistraOcorrencias(new RegistrarNoConsole());

registraConsole.Registrar("registro no console");

var registraArquivo =
    new RegistraOcorrencias(new RegistrarNoArquivo(@"C:\Users\Joãovirone\Documents\Projetos\Design-Patterns-cs\DesignPatterns\ComInterface\teste.txt"));

registraArquivo.Registrar("registro no arquivo");

Console.ReadLine();