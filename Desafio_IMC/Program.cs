using System;
using System.Globalization;

namespace Desafio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de variáveis
            string confirm = "";
            string nome = "";
            string sexo = "";            
            int idade, opcao;
            double altura, peso, imc;
            bool opcaoEhValida = false;
            #endregion

            inicio: //label indicado

            #region Cabeçalho do programa
            Console.WriteLine("\t\t********************************************************************");
            Console.WriteLine("\t\t**************** PREENCHA SUAS INFORMAÇÕES ABAIXO ******************");
            Console.WriteLine("\t\t********************************************************************");
            #endregion            

            //Faz a chamada do método ['VerificaNome'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o nome           
            nome = VerificaNome("\n\t\tInforme seu nome completo: ");

            //Faz a chamada do método ['VerificaSexo'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o sexo
            sexo = VerificaSexo("\n\t\tInforme seu sexo, 'M' para Masculino ou 'F' para Feminino: ");

            //Faz a chamada do método ['VerificaIdade'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar a idade
            idade = VerificaIdade("\n\t\tInforme sua idade: ");

            //Faz a chamada do método ['VerificaAltura'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar a altura
            altura = VerificaAltura("\n\t\tInforme sua altura em metros: ");

            //Faz a chamada do método ['VerificaPeso'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o peso
            peso = VerificaPeso("\n\t\tInforme seu peso em kg: ");

            Console.WriteLine("\n\n\n\t\tEstá certo(a) de que seus dados foram preenchidos corretamente?");
            Console.Write("\n\t\tSe sim, apenas pressione a tecla [Enter] para continuar." +
            "\n\t\tSe não, digite 'N' para retornar e fazer a correção: ");
            confirm = Console.ReadLine();
            if (confirm == "n" || confirm == "N")
            {                
                Console.Clear();
                goto inicio; //Faz um desvio no fluxo de execução do programa para o label indicado
            }
            
            Console.Clear(); //Limpa o console

            //Faz o cáculo do imc com as informações colhidas do usuário
            imc = peso / (Math.Pow(altura, 2));

            #region Label para o resultado do diagnóstico prévio
            Console.WriteLine("\t\t********************************************************************");
            Console.WriteLine("\t\t*********************** DIAGNÓSTICO PRÉVIO *************************");
            Console.WriteLine("\t\t********************************************************************");
            #endregion

            //Informações que serão retornadas para o usuário
            Console.WriteLine($"\n\t\tNome: {nome}");
            Console.WriteLine($"\t\tSexo: {sexo}");
            Console.WriteLine($"\t\tIdade: {idade} anos");
            Console.WriteLine($"\t\tAltura: {altura} m");
            Console.WriteLine($"\t\tPeso: {peso} kg");

            //Categoria de idade
            if (idade >= 0 && idade < 12)
                Console.WriteLine("\t\tCategoria: Infantil");
            else if (idade >= 12 && idade <= 20)
                Console.WriteLine("\t\tCategoria: Juvenil");
            else if (idade >= 21 && idade <= 65)
                Console.WriteLine("\t\tCategoria: Adulto");
            else Console.WriteLine("\t\tCategoria: Idoso");

            Console.WriteLine("\n\n\t\tIMC desejável: entre 20 e 24");
            Console.WriteLine($"\n\t\tResultado IMC: {imc.ToString("F")}"); //Retorna o resultado do imc calculado pelo programa com um limite de casas decimais

            //Classificação IMC: Riscos
            if (imc < 20) {
                Console.Write("\n\t\tRiscos: ");
                Console.WriteLine("Muitas complicações de saúde como doenças pulmonares e" +
                "\n\t\tcardiovasculares podem estar associadas ao baixo peso.");
            }
            else if (imc >= 20 && imc < 25) {
                Console.Write("\n\t\tRiscos: ");
                Console.WriteLine("Seu peso está ideal para suas referências.");
            }
            else if (imc >= 25 && imc < 30) {
                Console.Write("\n\t\tRiscos: ");
                Console.WriteLine("Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");
            }
            else if (imc >= 30 && imc < 35) {
                Console.Write("\n\t\tRiscos: ");
                Console.WriteLine("Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");
            }
            else {
                Console.Write("\n\t\tRiscos: ");
                Console.WriteLine("O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas."); 
            }
                                                                    
            //Classificação IMC: Recomendações
            if (imc < 20) {
                Console.Write("\n\t\tRecomendação inicial: ");
                Console.WriteLine("Inclua carboidratos simples em sua dieta, além de" +
                "\n\t\tproteínas - indispensáveis para ganho de massa magra. Procure um profissional.");
            }
            else if (imc >= 20 && imc < 25) {
                Console.Write("\n\t\tRecomendação inicial: ");
                Console.WriteLine("Mantenha uma dieta saudável e faça seus exames periódicos.");
            }
            else if (imc >= 25 && imc < 30) {
                Console.Write("\n\t\tRecomendação inicial: ");
                Console.WriteLine("Adote um tratamento baseado em dieta balanceada, exercício físico" +
                "\n\t\te medicação. A ajuda de um profissional pode ser interessante.");
            }
            else if (imc >= 30 && imc < 35) {
                Console.Write("\n\t\tRecomendação inicial: ");
                Console.WriteLine("Adote uma dieta alimentar rigorosa, com o acompanhamento" +
                "\n\t\tde um nutricionista e um médico especialista (endócrino).");
            }
            else {
                Console.Write("\n\t\tRecomendação inicial: ");
                Console.WriteLine("Procure com urgência o acompanhamento de um nutricionista para realizar" +
                "\n\t\treeducação alimentar, um psicólogo e um médico especialista (endócrino).");
            }
            
            do
            {
                Console.WriteLine("\n\n\n\t\tDeseja fazer um novo diagnóstico?");
                Console.Write("\t\tDigite [1] para continuar\n" +
                "\t\tou digite [2] para encerrar o programa: ");
                var opcaoInfomada = Console.ReadLine();
                opcaoEhValida = int.TryParse(opcaoInfomada, out opcao); //Valida a opção de entrada do usuário
                if (opcao == 1) //Se a opção [1] for diditada, o programa limpa o console e volta ao início
                {
                    opcaoEhValida = true;
                    Console.Clear();
                    goto inicio;
                }
                else if (opcao == 2)
                {   
                    Console.WriteLine("\n\t\tPrograma finalizado!\n\t\tObrigado por sua colaboração.");
                    opcaoEhValida = true;                    
                    break;
                }
                else Console.WriteLine("\n\t\tPor favor, escolha uma das opções abaixo!");
            } while (!opcaoEhValida || opcao != 1 || opcao != 2); //Enquanto o usuário não digitar as opções disponíveis, ele continua dentro do laço
           
        }

        #region Método VerificaNome
        static string VerificaNome(string msg) //Método criado para fazer a leitura do nome do usuário
        {
            string nomeInformado = ""; 
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
            bool sexoEhValido = false; 
            string sexoInformado = ""; 
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
                else Console.WriteLine("\n\t\tValor inválido!\n\t\tDigite 'M' para Masculino ou 'F' para feminino");
            } while (!sexoEhValido); //Valida o valor de entrada do sexo do usuário caso ele informe outros caracteres além de 'f' ou 'm'
            return sexoInformado; //Faz o retorno do método para a leitura do sexo do usuário
        }
        #endregion

        #region Método VerificaIdade
        static int VerificaIdade(string msg) //Método criado para ler a idade do usuário e verificar se é um valor válido
        {
            bool idadeEhvalida = false; 
            int ValidaIdadeInformada = 0; 
            do
            {
                Console.Write(msg); //Mostra a mensagem no console pedindo para o usuário informar a idade
                var valorInformado = Console.ReadLine(); //Faz a leitura da idade informada pelo usuário                
                idadeEhvalida = int.TryParse(valorInformado, out ValidaIdadeInformada); //Valida a entrada do usuário verificando se o número que ele digitou é um valor válido referente a idade                
                if (!idadeEhvalida || ValidaIdadeInformada < 1 || ValidaIdadeInformada > 110)
                    Console.WriteLine("\n\t\tValor inválido ou fora do padrão!\n\t\tInforme sua idade em anos, sem pontos ou vírgulas");
            } while (!idadeEhvalida || ValidaIdadeInformada < 1 || ValidaIdadeInformada > 110); //Faz a validação caso o usuário digite valores inválidos e assim continuando no laço até digitar um valor válido
            return ValidaIdadeInformada; //Faz o retorno do método para letura de idade do usuário
        }
        #endregion

        #region Método VerificaAltura
        static double VerificaAltura(string msg) //Método criado para receber e validar a altura do usuário
        {
            bool alturaEhvalida = false; 
            double AlturaInformada = 0; 
            do
            {
                Console.Write(msg); //Mostra a mensagem no console para o usuário informar a altura
                var valorInformado = Console.ReadLine(); //Lê a altura informada pelo usuário
                alturaEhvalida = double.TryParse(valorInformado.Replace(",", "."),NumberStyles.Number, CultureInfo.InvariantCulture, out AlturaInformada); //Verifica se o valor informado é válido, podendo receber a altura do usuário com vírgula ou ponto
                if (!alturaEhvalida || AlturaInformada < 1 || AlturaInformada > 2.20) //Condição que valida caso o usuário digite algo fora do esperado
                {
                    Console.WriteLine("\n\t\tAltura inválida ou fora do padrão!\n\t\tPor favor, digite novamente.");
                }
            } while (!alturaEhvalida || AlturaInformada < 1 || AlturaInformada > 2.20); //Enquanto o usuário digitar um valor inválido o laço se repete
            return AlturaInformada; //Faz o retorno do método para a leitura da altura do usuário
        }
        #endregion

        #region Método VerificaPeso
        static double VerificaPeso(string msg) //Método criado para ler e verificar se o valor informado pelo usuário é válido
        {
            bool pesoEhValido = false; 
            double pesoInformado = 0; 
            do
            {
                Console.Write(msg); //Mostra a mensagem no console 
                var valorInformado = Console.ReadLine(); //Faz leitura do valor informado pelo usuário
                pesoEhValido = double.TryParse(valorInformado.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out pesoInformado); //Verifica se o valor digitado é válido, podendo receber tanto ponto quanto vírgula, não deixando o usuário preencher a informação apenas com um espaço em branco ou qualquer outro caractere
                if(!pesoEhValido || pesoInformado < 1 || pesoInformado > 300) //Condição para validar o peso caso o usuário digite uma informação fora do esperado
                {
                    Console.WriteLine("\n\t\tValor inválido ou fora do padrão! Por favor, tente novamente.");
                }
            } while (!pesoEhValido || pesoInformado < 1 || pesoInformado > 300); //Laço de repetição fica continuamente até o usuário digitar um valor válido
            return pesoInformado; //Faz o retorno do método para leitura de peso do usuário
        }
        #endregion

    }
}

