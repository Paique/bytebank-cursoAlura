using bytebank;

Console.WriteLine("Bem vindo ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Gabriel Perrett";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia central";
conta1.saldo = 1.99; // Sim duro qq nem coco

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = "Carla Mattosa Palio Carro"; //?
conta2.conta = "33921-y";
conta2.numero_agencia = 131;
conta2.nome_agencia = "Agencia mais pro lado";
conta2.saldo = 7000000.50; // Rica

ContaCorrente conta3 = new ContaCorrente();

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("---------------------------------------------------- \n");


Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Número agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome da agencia: " + conta2.nome_agencia);
Console.WriteLine("Saldo: " + conta2.saldo);

Console.WriteLine("---------------------------------------------------- \n");

Console.WriteLine("Titular: " + conta3.titular);
Console.WriteLine("Conta: " + conta3.conta);
Console.WriteLine("Número agencia: " + conta3.numero_agencia);
Console.WriteLine("Nome da agencia: " + conta3.nome_agencia);
Console.WriteLine("Saldo: " + conta3.saldo);
Console.WriteLine("Verificador: " + conta3.verificador);




Console.ReadKey();

