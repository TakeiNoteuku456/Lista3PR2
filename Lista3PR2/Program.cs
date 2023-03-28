using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int Ex;

                Console.WriteLine("========Menu========");
            Console.WriteLine("Exercício 1");
                Console.WriteLine("Exercício 2");
                Console.WriteLine("Exercício 3");
                Console.WriteLine("Exercício 4");
                Console.WriteLine("Exercício 5");
                Console.WriteLine("Exercício 6");

                Ex = int.Parse(Console.ReadLine());

                switch (Ex)
                {
                    case 1:
                        int dia;
                        Console.WriteLine("Exercicio dias da semana");
                        Console.WriteLine("Digite um numero de de 1 a 7 correspondente a um dia da semana");
                        dia = int.Parse(Console.ReadLine());

                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("numero digitado é domingo");
                                break;

                            case 2:
                                Console.WriteLine("numero digitado é a segunda-feira");
                                break;

                            case 3:
                                Console.WriteLine("numero digitado é a quarta-feira");
                                break;

                            case 4:
                                Console.WriteLine("numero digitado é a quarta-feira");
                                break;

                            case 5:
                                Console.WriteLine("numero digitado é a quinta-feira");
                                break;

                            case 6:
                                Console.WriteLine("numero digitado é a sexta-feira");
                                break;

                            case 7:
                                Console.WriteLine("numero digitado é a sábado");
                                break;
                            default:
                                Console.WriteLine("Número inválido.");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Digite o valor total da compra: ");
                        int valorTotal = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escolha a forma de pagamento: ");
                        Console.WriteLine("1 - À vista no dinheiro (15% de desconto)");
                        Console.WriteLine("2 - À vista no PIX (10% de desconto)");
                        Console.WriteLine("3 - No débito (5% de acréscimo)");
                        Console.WriteLine("4 - No cartão de crédito (10% de acréscimo)");

                        int FPaga = int.Parse(Console.ReadLine());

                        int valorFinal = 0;

                        switch (FPaga)
                        {
                            case 1:
                                valorFinal = (int)(valorTotal * 0.85);
                                break;
                            case 2:
                                valorFinal = (int)(valorTotal * 0.9);
                                break;
                            case 3:
                                valorFinal = (int)(valorTotal * 1.05);
                                break;
                            case 4:
                                valorFinal = (int)(valorTotal * 1.1);
                                break;
                            default:
                                Console.WriteLine("Forma de pagamento inválida.");
                                break;
                        }

                        Console.WriteLine("Valor final da compra: R$ " + valorFinal);
                        break;
                    case 3:
                        {
                            Console.Write("Digite o número do mês (1-12): ");
                            int mes = int.Parse(Console.ReadLine());

                            int diasNoMes;

                            switch (mes)
                            {
                                case 1:
                                    Console.WriteLine("Janeiro - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 2:
                                    Console.Write("Fevereiro - ");
                                    Console.Write("Digite o ano (yyyy): ");
                                    int ano = int.Parse(Console.ReadLine());
                                    if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                                    {
                                        Console.WriteLine("29 dias");
                                        diasNoMes = 29;
                                    }
                                    else
                                    {
                                        Console.WriteLine("28 dias");
                                        diasNoMes = 28;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Março - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 4:
                                    Console.WriteLine("Abril - 30 dias");
                                    diasNoMes = 30;
                                    break;
                                case 5:
                                    Console.WriteLine("Maio - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 6:
                                    Console.WriteLine("Junho - 30 dias");
                                    diasNoMes = 30;
                                    break;
                                case 7:
                                    Console.WriteLine("Julho - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 8:
                                    Console.WriteLine("Agosto - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 9:
                                    Console.WriteLine("Setembro - 30 dias");
                                    diasNoMes = 30;
                                    break;
                                case 10:
                                    Console.WriteLine("Outubro - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                case 11:
                                    Console.WriteLine("Novembro - 30 dias");
                                    diasNoMes = 30;
                                    break;
                                case 12:
                                    Console.WriteLine("Dezembro - 31 dias");
                                    diasNoMes = 31;
                                    break;
                                default:
                                    Console.WriteLine("Mês inválido");
                                    diasNoMes = 0;
                                    break;
                            }

                            Console.WriteLine($"O mês de {mes} tem {diasNoMes} dias.");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());

                        Console.Write("Digite a operação desejada (+, -, *, / ou ^): ");
                        int operacao = int.Parse(Console.ReadLine());

                        int resultado = 0;

                        switch (operacao)
                        {
                            case '+':
                                resultado = num1 + num2;
                                break;
                            case '-':
                                resultado = num1 - num2;
                                break;
                            case '*':
                                resultado = num1 * num2;
                                break;
                            case '/':
                                if (num2 != 0)
                                {
                                    resultado = (int)num1 / num2;
                                }
                                else
                                {
                                    Console.WriteLine("Erro: divisão por zero!");
                                    return;
                                }
                                break;
                            case '^':
                                resultado = (int)num1 ^ num2;
                                break;
                            default:
                                Console.WriteLine("Operação inválida!");
                                return;
                        }

                        Console.WriteLine($"O resultado da operação é: {resultado}");


                        break;
                    case 5:
                        Console.Write("Digite o salário do funcionário: ");
                        int salario = int.Parse(Console.ReadLine());

                        Console.Write("Digite o cargo do funcionário: ");
                        string cargo = Console.ReadLine().ToLower();

                        int novoSalario = 0;

                        switch (cargo)
                        {
                            case "Professor":
                                novoSalario = (int)(salario * 1.075);
                                break;
                            case "Secretário":
                                novoSalario = (int)(salario * 1.097;
                                break;
                            case "Publicitário":
                                novoSalario = (int)(salario * 1.117;
                                break;
                            case "Jornalista":
                                novoSalario = (int)(salario * 1.089;
                                break;
                            case "Mecânico":
                                novoSalario = (int)(salario * 1.1324;
                                break;
                            case "Estagiário":
                                novoSalario = (int)(salario * 1.104;
                                break;
                            case "Técnico de TI":
                                novoSalario = (int)(salario * 1.146;
                                break;
                            default:
                                novoSalario = (int)(salario * 1.435;
                                break;
                        }

                        int diferenca = novoSalario - salario;

                        Console.WriteLine($"Salário antigo: R${salario}");
                        Console.WriteLine($"Novo salário: R${novoSalario}");
                        Console.WriteLine($"Diferença: R${diferenca}");

                        break;
                    case 6:
                        Console.Write("Digite o salário mensal: ");
                        int Salario = int.Parse(Console.ReadLine());

                        int imposto = 0;
                        int salarioLiquido = 0;

                        int caso = 0;

                        if (Salario <= 1903.98)
                            caso = 1;
                        else if (Salario <= 2826.65)
                            caso = 2;
                        else if (Salario <= 3751.05)
                            caso = 3;
                        else if (Salario <= 4664.68)
                            caso = 4;
                        else
                            caso = 5;

                        switch (caso)
                        {
                            case 1:
                                imposto = 0;
                                salarioLiquido = Salario;
                                break;
                            case 2:
                                imposto = (int)(Salario * 0.075 - 142.80);
                                salarioLiquido = Salario - imposto;
                                break;
                            case 3:
                                imposto = (int)(Salario * 0.15 - 354.80);
                                salarioLiquido = Salario - imposto;
                                break;
                            case 4:
                                imposto = (int)(Salario * 0.225 - 636.13);
                                salarioLiquido = Salario - imposto;
                                break;
                            case 5:
                                imposto = (int)(Salario * 0.275 - 869.36);
                                salarioLiquido = Salario - imposto;
                                break;
                        }

                        Console.WriteLine("Salário bruto: R$ " + Salario);
                        Console.WriteLine("Imposto devido: R$ " + imposto);
                        Console.WriteLine("Salário líquido: R$ " + salarioLiquido);
                        break;
                    default:
                        Console.WriteLine("Operação inválida!");
                        return;
                }
            }
        }
    }
}
