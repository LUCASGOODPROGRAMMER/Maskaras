using BibliotecaDeMaskaras;

Console.WriteLine("1-Digitar valores sem maskara\n2-Digitar valores com maskara");
string escolha = Console.ReadLine();

if(escolha == "1")
{
    Console.Write("Informe o seu NÚMERO: ");
    string numero = Console.ReadLine();
    Console.Write("Informe o seu CPF: ");
    string cpf = Console.ReadLine();
    Console.Write("Informe seu CEP: ");
    string cep = Console.ReadLine();

    
    Console.WriteLine("NÚMERO: " + RemoverAdicionar.MaskararNumero(numero) + "\nCPF: " + RemoverAdicionar.MaskararCPF(cpf) + "\nCEP: "
        + RemoverAdicionar.MaskararCEP(cep));
}
else
{
    
    Console.Write("Informe o seu NÚMERO com maskara: ");
    string numero = Console.ReadLine();
    Console.Write("Informe o seu CPF com maskara: ");
    string cpf = Console.ReadLine();
    Console.Write("Informe seu CEP com maskara: ");
    string cep = Console.ReadLine();

    Console.WriteLine("NÚMERO: " + RemoverAdicionar.DesmaskararNumero(numero) + "\nCPF: " + RemoverAdicionar.DesmaskararCPF(cpf) + "\nCEP: "
       + RemoverAdicionar.DesmaskararCEP(cep));
}



