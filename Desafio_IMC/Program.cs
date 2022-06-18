using System;
using System.Globalization;

namespace Desafio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string sexo = "";            
            int idade;
            double altura, peso, imc;

            #region Cabeçalho do programa
            Console.WriteLine("********************************************************************");
            Console.WriteLine("**************** PREENCHA SUAS INFORMAÇÕES ABAIXO ******************");
            Console.WriteLine("********************************************************************");
            #endregion

            //Faz a chamada do método ['VerificaNome'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o nome           
            nome = VerificaNome("\nInforme seu nome completo: ");

            //Faz a chamada do método ['VerificaSexo'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o sexo
            sexo = VerificaSexo("\nInforme seu sexo, 'M' para Masculino ou 'F' para Feminino: ");

            //Faz a chamada do método ['VerificaIdade'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar a idade
            idade = VerificaIdade("\nInforme sua idade: ");

            //Faz a chamada do método ['VerificaAltura'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar a altura
            altura = VerificaAltura("\nInforme sua altura em metros: ");

            //Faz a chamada do método ['VerificaPeso'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o peso
            peso = VerificaPeso("\nInforme seu peso em kg: ");

            Console.Clear();

            //Faz o cáculo do imc com as informações colhidas do usuário
            imc = peso / (Math.Pow(altura, 2));

            #region Label para o resultado do diagnóstico prévio
            Console.WriteLine("********************************************************************");
            Console.WriteLine("*********************** DIAGNÓSTICO PRÉVIO *************************");
            Console.WriteLine("********************************************************************");
            #endregion

            //Informações que serão retornadas para o usuário
            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Altura: {altura} m");
            Console.WriteLine($"Peso: {peso} kg");

            //Categoria de idade
            if (idade >= 0 && idade < 12)
                Console.WriteLine("Categoria: Infantil");
            else if (idade >= 12 && idade <= 20)
                Console.WriteLine("Categoria: Juvenil");
            else if (idade >= 21 && idade <= 65)
                Console.WriteLine("Categoria: Adulto");
            else Console.WriteLine("Categoria: Idoso");

            Console.WriteLine("\n\nIMC desejável: entre 20 e 24");
            Console.WriteLine($"\nResultado IMC: {imc.ToString("F")}"); //Retorna o resultado do imc calculado pelo programa com um limite de casas decimais

            //Classificação IMC: Riscos
            if (imc < 20) {
                Console.Write("\nRiscos: ");
                Console.WriteLine("Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.");
            }
            else if (imc >= 20 && imc < 25) {
                Console.Write("\nRiscos: ");
                Console.WriteLine("Seu peso está ideal para suas referências.");
            }
            else if (imc >= 25 && imc < 30) {
                Console.Write("\nRiscos: ");
                Console.WriteLine("Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");
            }
            else if (imc >= 30 && imc < 35) {
                Console.Write("\nRiscos: ");
                Console.WriteLine("Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");
            }
            else {
                Console.Write("\nRiscos: ");
                Console.WriteLine("O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas."); 
            }
                                                                    
            //Classificação IMC: Recomendações
             if (imc < 20) {
                Console.Write("\nRecomendação inicial: ");
                Console.WriteLine("Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.");
            }
             else if (imc >= 20 && imc < 25) {
                Console.Write("\nRecomendação inicial: ");
                Console.WriteLine("Mantenha uma dieta saudável e faça seus exames periódicos.");
            }
             else if (imc >= 25 && imc < 30) {
                Console.Write("\nRecomendação inicial: ");
                Console.WriteLine("Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante.");
            }
             else if (imc >= 30 && imc < 35) {
                Console.Write("\nRecomendação inicial: ");
                Console.WriteLine("Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).");
            }
             else {
                Console.Write("\nRecomendação inicial: ");
                Console.WriteLine("Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).");
            }
             

        }

        #region Método VerificaNome
        static string VerificaNome(string msg) //Método criado para fazer a leitura do nome do usuário
        {
            string nomeInformado = ""; //declaração de variável que vai receber o nome do usuário
            do
            {
                Console.Write(msg); //Mostra a mensagem no console pedindo para o usuário informar o nome
                nomeInformado = Console.ReadLine(); //Faz a leitura do nome
            } while (string.IsNullOrWhiteSpace(nomeInformado)); //Valida a entrada de nome do usuário caso ele deixe o espaço em branco
            return nomeInformado; //Faz o retorno do método para a leitura do nome do usuário
        }
        #endregion

        #region Método VerificaSexo
        static string VerificaSexo(string msg) //Método criado para fazer a leitura do sexo do usuário
        {
            bool sexoEhValido = false; //declaração de variável para validar o sexo do usuário
            string sexoInformado = ""; //declaração de variável para receber o sexo informado pelo usuário
            do
            {
                Console.Write(msg); //Mostra a mensagem no console pedindo para o usuário informar o sexo
                sexoInformado = Console.ReadLine(); //Faz a leitura do mesmo
                if (sexoInformado == "m" || sexoInformado == "M")
                {
                    sexoInformado = "Masculino";
                    sexoEhValido = true;
                }
                else if (sexoInformado == "f" || sexoInformado == "F")
                {
                    sexoInformado = "Feminino";
                    sexoEhValido = true;
                }
                else Console.WriteLine("\nValor inválido!\nDigite 'M' para Masculino ou 'F' para feminino");
            } while (!sexoEhValido); //Valida o valor de entrada do sexo do usuário caso ele informe outros caracteres além de 'f' ou 'm'
            return sexoInformado; //Faz o retorno do método para a leitura do sexo do usuário
        }
        #endregion

        #region Método VerificaIdade
        static int VerificaIdade(string msg) //Método criado para ler a idade do usuário e verificar se é um valor válido
        {
            bool idadeEhvalida = false; //declaração de variável para validar a idade
            int ValidaIdadeInformada = 0; //declaração de variável para receber o valor informado pelo usuário
            do
            {
                Console.Write(msg); //Mostra a mensagem no console pedindo para o usuário informar a idade
                var valorInformado = Console.ReadLine(); //Faz a leitura da idade informada pelo usuário                
                idadeEhvalida = int.TryParse(valorInformado, out ValidaIdadeInformada); //Valida a entrada do usuário verificando se o número que ele digitou é um valor válido referente a idade                
                if (!idadeEhvalida || ValidaIdadeInformada < 0 || ValidaIdadeInformada > 120)
                    Console.WriteLine("\nValor inválido ou fora do padrão!\nInforme sua idade em anos, sem pontos ou vírgulas");
            } while (!idadeEhvalida || ValidaIdadeInformada < 0 || ValidaIdadeInformada > 120); //Faz a validação caso o usuário digite valores inválidos e assim continuando no laço até digitar um valor válido
            return ValidaIdadeInformada; //Faz o retorno do método para letura de idade do usuário
        }
        #endregion

        #region Método VerificaAltura
        static double VerificaAltura(string msg) //Método criado para receber e validar a altura do usuário
        {
            bool alturaEhvalida = false; //declaração de variável para validar a altura
            double AlturaInformada = 0; //Variável que vai receber a altura do usuário
            do
            {
                Console.Write(msg); //Mostra a mensagem no console para o usuário informar a altura
                var valorInformado = Console.ReadLine(); //Lê a altura informada pelo usuário
                alturaEhvalida = double.TryParse(valorInformado.Replace(",", "."),NumberStyles.Number, CultureInfo.InvariantCulture, out AlturaInformada); //Verifica se o valor informado é válido, podendo receber a altura do usuário com vírgula ou ponto
                if (!alturaEhvalida || AlturaInformada < 0 || AlturaInformada > 2.60) //Condição que valida caso o usuário digite algo fora do esperado
                {
                    Console.WriteLine("\nAltura inválida ou fora do padrão!\nPor favor, digite novamente.");
                }
            } while (!alturaEhvalida || AlturaInformada < 0 || AlturaInformada > 2.60); //Enquanto o usuário digitar um valor inválido o laço se repete
            return AlturaInformada; //Faz o retorno do método para a leitura da altura do usuário
        }
        #endregion

        #region Método VerificaPeso
        static double VerificaPeso(string msg) //Método criado para ler e verificar se o valor informado pelo usuário é válido
        {
            bool pesoEhValido = false; //variável criada para ser usada na validação do peso do usuário
            double pesoInformado = 0; //variável que vai receber o peso informado
            do
            {
                Console.Write(msg); //Mostra a mensagem no console 
                var valorInformado = Console.ReadLine(); //Faz leitura do valor informado pelo usuário
                pesoEhValido = double.TryParse(valorInformado.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out pesoInformado); //Verifica se o valor digitado é válido, podendo receber tanto ponto quanto vírgula, não deixando o usuário preencher a informação apenas com um espaço em branco ou qualquer outro caractere
                if(!pesoEhValido || pesoInformado < 0 || pesoInformado > 400) //Condição para validar o peso caso o usuário digite uma informação fora do esperado
                {
                    Console.WriteLine("\nValor inválido ou fora do padrão! Por favor, tente novamente.");
                }
            } while (!pesoEhValido || pesoInformado < 0 || pesoInformado > 400); //Laço de repetição fica continuamente até o usuário digitar um valor válido
            return pesoInformado; //Faz o retorno do método para leitura de peso do usuário
        }
        #endregion
    }
}

