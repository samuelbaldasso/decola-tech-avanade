using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indexAluno = 0;
            string optionUser = optionUser();

            while (optionUser.ToUpper() != "X")
            {
                switch (optionUser)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Name = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal note))
                        {
                            aluno.Note = note;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indexAluno] = aluno;
                        indexAluno++;

                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Name))
                            {
                                Console.WriteLine($"ALUNO: {a.Name} - NOTA: {a.Note}");
                            }
                        }
                        break;
                    case "3":
                        decimal totalNote = 0;
                        var numberAlunos = 0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Name))
                            {
                                totalNote = totalNote + alunos[i].Nota;
                                numberAlunos++;
                            }
                        }

                        var generalAvarage = totalNote / numberAlunos;
                        ConceptType general;

                        if (generalAverage < 2)
                        {
                            general = concept.E;
                        }
                        else if (generalAvarage < 4)
                        {
                            general = concept.D;
                        }
                        else if (generalAvarage < 6)
                        {
                            general = concept.C;
                        }
                        else if (generalAvarage < 8)
                        {
                            general = concept.B;
                        }
                        else
                        { 
                            general = concept.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {generalAvarage} - conceito: {general}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                optionUser = optionUser();
            }
        }

        private static string optionUser()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1) Inserir novo aluno");
            Console.WriteLine("2) Listar alunos");
            Console.WriteLine("3) Calcular média geral");
            Console.WriteLine("4) Sair");
            Console.WriteLine();

            string optionUser = Console.ReadLine();
            Console.WriteLine();
            return optionUser;
        }
    }
}
