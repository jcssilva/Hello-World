using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo01
{
	class Program
	{
		static void Main(string[] args)
		{
			double dValor1;
			double dValor2;
			String strOperacao;
			double dResultado;
			Console.WriteLine("Digite o primeiro valor:");
			dValor1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite a operação:");
			strOperacao = Console.ReadLine();

			if (strOperacao == "+" || strOperacao == "-" || strOperacao == "*" || strOperacao == "/")
			{
				Console.WriteLine("Operação válida!");
				Console.ReadKey();
				return;
			}
			else
			{
				Console.WriteLine("Operação Inválida!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("Digite o segundo valor:");
			dValor2 = Convert.ToInt32(Console.ReadLine());

			if (strOperacao == "+")
			{
				dResultado = dValor1 + dValor2;
				Console.WriteLine("O resultado de {0} + {1} = {2}", dValor1, dValor2, dResultado);
			}
			else if (strOperacao == "-")
			{
				dResultado = dValor1 - dValor2;
				Console.WriteLine("O resultado de {0} - {1} = {2}", dValor1, dValor2, dResultado);
			}
			else if (strOperacao == "*")
			{
				dResultado = dValor1 * dValor2;
				Console.WriteLine("O resultado de {0} * {1} = {2}", dValor1, dValor2, dResultado);
			}
			else if (strOperacao == "/")
			{
				if (dValor2 == 0)
				{
					Console.WriteLine("Erro. Divisão por zero não pode ser feita.");
				}
				else
				{
					dResultado = dValor1 / dValor2;
					Console.WriteLine("O resultado de {0} / {1} = {2}", dValor1, dValor2, dResultado);
				}
			}
			//Console.WriteLine("O resultado de {0} {1} {2} = {3}", dValor1, strOperacao, dValor2);
			Console.ReadKey();
		}
	}
}
