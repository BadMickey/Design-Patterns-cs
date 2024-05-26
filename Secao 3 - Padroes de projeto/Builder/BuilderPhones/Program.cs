﻿// Criando o Director
using Builder_Phones;

Fabricante fabrica1 = new Fabricante();
// Lets have the Builder class ready
ICelularBuilder celularBuilder = null;

// cria um Android
celularBuilder = new AndroidBuilder();
fabrica1.Construir(celularBuilder);
Console.WriteLine($"Um novo celular criado :\n\n{celularBuilder.Fone.ToString()}");

// cria um IPhone
celularBuilder = new IPhoneBuilder();
fabrica1.Construir(celularBuilder);
Console.WriteLine($"Um novo celular criado :\n\n{celularBuilder.Fone.ToString()}");