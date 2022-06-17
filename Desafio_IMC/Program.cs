using System;
using System.Globalization;

namespace Desafio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double imc;
            string nome = "";
            string sexo = "";            
            int idade;
            double altura;

            #region Cabeçalho do programa
            Console.WriteLine("********************************************************************");
            Console.WriteLine("*********************** DIAGNÓSTICO PRÉVIO *************************");
            Console.WriteLine("********************************************************************");
            #endregion

            //Faz a chamada do método ['VerificaNome'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o nome           
            nome = VerificaNome("\nInforme seu nome: ");

            //Faz a chamada do método ['VerificaSexo'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar o sexo
            sexo = VerificaSexo("\nInforme seu sexo, 'M' para Masculino ou 'F' para Feminino: ");

            //Faz a chamada do método ['VerificaIdade'] para o método ['Main'] fazendo com que a mensagem abaixo apareça para o usuário informar a idade
            idade = VerificaIdade("\nInforme sua idade: ");

            //Faz a chamada do método ['VerificaAltura'] para o método ['Main'] 
            altura = VerificaAltura("\nInforme sua altura em metros: ");

            Console.WriteLine($"\nAltura: {altura}");

            /*Console.Write("\nInforme seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));*/

            /*Categoria de idade
             * if (idade >= 0 && idade < 12)
                Console.WriteLine("Categoria: Infantil");
            else if (idade >= 12 && idade <= 20)
                Console.WriteLine("Categoria: Juvenil");
            else if (idade >= 21 && idade <= 65)
                Console.WriteLine("Categoria: Adulto");
            else Console.WriteLine("Categoria: Idoso");
            
             
             
             *Classificação IMC: Riscos
             * if (imc < 20) {
             * Console.WriteLine("IMC abaixo de 20");
             * Console.WriteLine("RISCO: Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.");
             * }
             * else if (imc >= 20 && imc <= 24) {
             * Console.WriteLine("IMC entre 20 e 24");
             * Console.WriteLine("Seu peso está ideal para suas referências.");
             * }
             * else if (imc >= 25 && imc <= 29) {
             * Console.WriteLine("IMC entre 25 e 29");
             * Console.WriteLine("Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");
             * }
             * else if (imc >= 30 && imc <= 35) {
             * Console.WriteLine("IMC entre 30 e 35");
             * Console.WriteLine("Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");
             * else {
             *  Console.WriteLine("IMC acima de 35");
             *  Console.WriteLine("RISCO: O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.");}
             *  
             *  
             *  
             *  
             *  
             *  Classificação IMC: Recomendações
             *  if (imc < 20) {
             * Console.WriteLine("Recomendações:");
             * Console.WriteLine("Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.");}
             * else if (imc >= 20 && imc <= 24) {
             * Console.WriteLine("Recomendações:");
             * Console.WriteLine("Mantenha uma dieta saudável e faça seus exames periódicos.");}
             * else if (imc >= 25 && imc <= 29) {
             * Console.WriteLine("Recomendações:");
             * Console.WriteLine("Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante");}
             * else if (imc >= 30 && imc <= 35) {
             * Console.WriteLine("Recomendações:");
             * Console.WriteLine("Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).");}
             * else {
             *  Console.WriteLine("Recomendações:");
             *  Console.WriteLine("Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).");}
             * 
             * }*/

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
                    Console.WriteLine("Valor inválido ou fora do padrão!\nInforme sua idade em anos, sem pontos ou vírgulas");
            } while (!idadeEhvalida || ValidaIdadeInformada < 0 || ValidaIdadeInformada > 120); //Faz a validação caso o usuário digite valores inválidos e assim continuando no laço até digitar um valor válido
            return ValidaIdadeInformada; //Faz o retorno do método para letura de idade do usuário
        }
        #endregion

        static double VerificaAltura(string msg)
        {
            bool alturaEhvalida = false;
            double AlturaInformada = 0;
            do
            {
                Console.Write(msg);
                var valorInformado = Console.ReadLine();
                alturaEhvalida = double.TryParse(valorInformado.Replace(",", "."),NumberStyles.Number,(CultureInfo.GetCultureInfo("pt-br")), out AlturaInformada);
            } while (!alturaEhvalida);
            return AlturaInformada;
        }
    }
}

