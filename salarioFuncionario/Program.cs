using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incira o nome do funcionário");
            string funcionario = Console.ReadLine();
            Console.WriteLine("Incira o salário:");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Incira o %imposto sobre o salário");
            double porcentagemImposto = double.Parse(Console.ReadLine());
            funcionario funcionario = newFuncionario(nome, salarioBruto, porcentagemImposto);
            Console.WriteLine(funcionario);
        }
           
    }
}
