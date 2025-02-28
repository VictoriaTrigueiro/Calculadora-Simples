namespace Calculadora_Vic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor escolha sua operação!");

            int operação;

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subitração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            //Operação do usuario 
            operação = int.Parse(Console.ReadLine());

            //Funções

            if (operação == 1) Console.WriteLine($"Função Soma");
            if (operação == 2) Console.WriteLine($"Função Subitração");
            if (operação == 3) Console.WriteLine($"Função Multiplicação");
            if (operação == 4) Console.WriteLine($"Função Divisão");

            Console.WriteLine("Digite o primeiro número da operação:");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite o segundo número da operação:");
            int Num2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (operação)
            {
                case 1:

                    resultado = Num1 + Num2;
                    Console.WriteLine($"O resultado da sua operação é: {resultado}");

                    break;

                case 2:

                    resultado = Num1 - Num2;
                    Console.WriteLine($"O resultado da sua operação é: {resultado}");

                    break;

                case 3:

                    resultado = Num1 * Num2;
                    Console.WriteLine($"O resultado da sua operação é: {resultado}");

                    break;

                case 4:
                    resultado = Num1 / Num2;
                    Console.WriteLine($"O resultado da sua operação é: {resultado}");

                    break;









            }



        }



    }
}
