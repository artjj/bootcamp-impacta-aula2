using System;

namespace SegundaAula
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            bool isAdulto = true;
            decimal valor = 10.55m;
            double valor1 = 10.55;
            char sigla = 'C';
            string estado = "São Paulo";

            var teste = "Teste";

            if (idade >= 18)
            {
                teste = "Maior de idade";
                isAdulto = true;
            }
            else if(estado == "São Paulo")
            {
                teste = "Paulista";
            }

            /*
            switch (idade)
            {
                case <= 2: 
                    teste = "Neném";
                    break;
                case > 2 && < 18:
                    teste = "Criança";
                    break;
                case >= 18 && <= 65:
                    teste = "Adulto";
                    break;
                case > 65:
                    teste = "Senior";
                    break;
            }
            */
            Console.WriteLine(teste);

            foreach (var argumento in args)
            {
                Console.WriteLine($"Argumento lido no foreach: {argumento}");
            }

            for (var i = 0; i < args.Length; i++)
            {
                var argumento = args[i];
                Console.WriteLine($"Argumento lido no for: {argumento}");
                //Console.WriteLine($"Estamos no loop: {i}");

            }

            var cont = 0;
            while (cont < args.Length)
            {
                var argumento = args[cont];
                Console.WriteLine($"Argumento lido no while: {argumento}");
                cont++;
            }

            var cont2 = 0;
            do
            {
                var argumento = args[cont2];
                Console.WriteLine($"Argumento lido no DO: {argumento}");
                cont2++;
            } while (cont2 < args.Length);
        }
    }
}
