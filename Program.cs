//// Comentário - anotar (mostra texto na tela)
// * 
// * esse é um comentário de multiplas linhas
// * 
// fechar -> */

////TODA INSTRUÇÃO TERMINA COM ;
//Console.WriteLine("Olá, muito bom dia!");


//// Guardar informações
//// 1. Variaveis (caixinhas que guardam informações)

//// TIPO NOME_DA_VARIAVEL = VALOR;       "=' -> ATRIBUIÇÃO
//int idade = 25;
//idade = 20;
//Console.WriteLine(idade);

//string nome = "Brayan";
//Console.WriteLine(nome);

//const double pi = 3.14159;
//Console.WriteLine(pi);

//double preco = 20.99;

//// int - integer (Numeros Inteiros)
////double/float - Numero Quebrados    (float - capacidade menor)
////string - Textos - ""

//;
//Console.WriteLine("informe sua idade");
//int idadeUsuario = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite seu nome:");
//string nomeUsuario = Console.ReadLine();

//Console.WriteLine("Ola, " + nomeUsuario + "! \n Voce tm " + idadeUsuario + " anos.");

//// Interpolação de Strings
////Console.WriteLine($"Ola, {nome de usuario]! voce tem [idadeUsuario

////Operaoes Aritmeticas

//int soma = 10 + 5;
//int subtraca = 10 - 5;
//int multiplicacao = 10 * 5;
//int divisao = 10 / 2;

////resto da divisao - recebe o resto da divisao de 10 por 3
//int modulo = 10 % 3;

//Console.WriteLine(soma);
//Console.WriteLine(subtraca);
//Console.WriteLine(multiplicacao);
//Console.WriteLine(divisao);
//Console.WriteLine(modulo);


//exercícios Fundamentais
using System.ComponentModel.Design;

///* abrir
Console.WriteLine("Ola, mundo!");

int numero = 10;
Console.WriteLine(numero);

int a = 5;
int b = 3;
int totals = a + b;
Console.WriteLine(totals);

int num1 = 8;
int num2 = 7;
int totalm = num1 * num2;
Console.WriteLine(totalm);

String nome = "Ana";
Console.WriteLine($"Ola, {nome}!");

// Intermediario

int valor = 10;
valor = valor * 2;
Console.WriteLine(valor);
// prox

Console.WriteLine("Digite o primeiro numero");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
double n3 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

// prox ** bool -> Tipo que armazena True ou False (apenas)

int userIdade = 16;

bool verificarIdade = userIdade >= 16;
Console.WriteLine(verificarIdade);

Console.WriteLine(a == b); // A é igual a B ? - False
Console.WriteLine(a != b); // A é de diferente de B ? - True
Console.WriteLine(a > b); // A é maior que B ? - True
Console.WriteLine(a < b); // A é menor que B ? - False

Console.WriteLine(a >= b); // A é maior ou igual que B ? - True
Console.WriteLine(a <= b); // A é menor ou igual que B ? - False

//



//Avançado
Console.WriteLine("Informe sua idade: ");
int valorIdade = int.Parse(Console.ReadLine());

if (valorIdade >= 16)
{
    Console.WriteLine("Verdadeiro!");
}
else
{
    Console.WriteLine("Falso!");
};


//


int temperatura = 28;

if (temperatura > 25 && temperatura < 30)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}


//

bool temCartao = true;
double compra = 50.0;

if (temCartao == true || compra > 100.0)
{
    Console.WriteLine("Tem desconto!");
}
else
{
    Console.WriteLine("Não tem desconto!");
};











