string[] nome = new string[5];
            double[] nota1 = new double[5];
            double[] nota2 = new double[5];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Digite a primeira nota: ");
                nota1[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite a segunda nota: ");
                nota2[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("\nResultado");
            
            for(int i = 0; i < 5; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;
                Console.WriteLine($"Nome: {nome[i]} | Primeira Nota: {nota1[i]} | Segunda Nota: {nota2[i]} | Média: {media:F2}");
            }
            Console.ReadKey();