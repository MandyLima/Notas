using System;

class Program
{
    static void Main()
    {
        
        string[] nomes = new string[10];

       
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º nome:");
            nomes[i] = Console.ReadLine();
        }


    ProcurarNome: //goto
        Console.WriteLine("Digite o nome que deseja procurar:");
        string nomeProcurado = Console.ReadLine();

        
        bool encontrado = false;
        for (int i = 0; i < 10; i++)
        {
            if (nomes[i] == nomeProcurado)
            {
                encontrado = true;
                break;  
            }
        }

       
        if (encontrado)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NÃO ACHEI, TENTE NOVAMENTE!");
            goto ProcurarNome;
        }
        Console.ReadKey();
    }
}