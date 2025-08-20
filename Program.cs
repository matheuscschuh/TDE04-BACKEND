double saldo = 1000.00;
int opcao;
do
{
    Console.WriteLine("1 - Ver Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Sair");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"O seu saldo disponivel é: {saldo}");
            break;
        case 2:
            Console.WriteLine("Digite o valor que queira depositar:");
            double depositar = Convert.ToDouble(Console.ReadLine());
            if (depositar < 0)
            {
                saldo = saldo + depositar;
                Console.WriteLine("Deposito realizado com sucesso!");

            }
            else
            {
                Console.WriteLine("Valor invalido!");
            }
            break;
        case 3:
            Console.WriteLine("Digite o valor que queira sacar:");
            double sacar = Convert.ToDouble(Console.ReadLine());
            if (sacar <= saldo)
            {
                saldo -= sacar;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            break;
        case 4:
            Console.WriteLine("Obrigado por usar nosso sistema!");
            break;
        default:
            Console.WriteLine("Valor invalido!");
            break;
    }
} while (opcao != 4);
