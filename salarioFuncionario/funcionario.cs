﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarioFuncionario
{
    public class funcionario
    {
        public string nome { get; set; }
        public double salarioBruto { get; set; }
        public procentagemImposto{get; set;}
    public funcionario(string nome, doubble salarioBruto, double porcentagemImpostos)
    {
        nome = nome;
        salarioBruto = salarioBruto;
        porcentagemImposto = porcentagemImposto;
    }
    public double calcularSalarioLiquido()
    {
        double desconto = SalarioBruto * (PorcentagemImposto / 100);
        double salarioLiquido = SalarioBruto - desconto;
        return salarioLiquido;
    }
    public override string toString()
    {
     
        double salarioLiquido = calcularSalarioLiquido();
        return $"Nome: {nome}, salário bruto: R${salarioBruto:F2}, porcentagem de imposto: R${porcentagemImposto:F2}%, salário líquido: R${salarioLiquido:f2};";
    }     
    }

    }
}
