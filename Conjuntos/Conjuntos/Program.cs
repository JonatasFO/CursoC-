using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O Curso A possui quantos alunos? ");
            int N = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < M; i++) {
                int y = int.Parse(Console.ReadLine());
                B.Add(y);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int O = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < O; i++) {
                int z = int.Parse(Console.ReadLine());
                C.Add(z);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de alunos: " + Novo.Count);

        }
    }
}
