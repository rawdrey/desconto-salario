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

            double salarioLiquido = calcularSalarioLiquido(salarioBruto, porcentagemImposto);
            Console.WriteLine($"O funcionário {funcionario}, recebe um salário líquido de R${salarioLiquido:F2}.");
        }
            public static doub
            le calcularSalarioLiquido(double salarioBruto, doubleporcentagemImposto)
            
            double desconto = salarioBruto * (porcentoImposto / 100);
            salarioBrutoLiquido = salarioBruto - desconto;
            return salarioLiquido;
        
    }
}
