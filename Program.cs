// Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
// Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
// Crie uma variável chamada altura e atribua a ela o valor 3.45.
// Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor

int idade = 35;
string nome = "Maria";
float altura = 3.45f;
const int ano = 12;

Console.WriteLine (idade);
Console.WriteLine (nome);
Console.WriteLine (altura);
Console.WriteLine (ano);

// Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = 7.80;

Console.WriteLine (nota);

// Quais as diferenças entre os tipos por valor e os tipos por referência?
// Tipos por valor: armazenam diretamente o valor na memória (int, double, struct)
// Tipos por referência: armazenam na memória onde os dados estão localizados (classes, arrays)

// O que é um nullable type e qual a sua utilidade?
// Um nullale type é um tipo de dados que pode armazenar valores de seu tipo subjacente, além de um valor nulo adicional.

// O que é Camel Case ? Dê um exemplo de sua aplicação.
// É uma convenção de nomenclatura em que múltiplas palavras são escritas juntas, sem espaços, e cada palavra subsequente começa com uma letra maiúscula, exceto a primeira palavra. Ele é comumente usado em nomes de variáveis, métodos e identificadores (camelCase).

// O que é Pascal Case ? Dê um exemplo de sua aplicação
// É uma convenção de nomenclatura semelhante ao camel case, mas com a primeira letra de cada palavra em maiuscula, incluindo a primeira. Comumente usado em classes, métodos e namespaces (PascalCase).

// Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)

int x = 77;
int y = 66;

int soma = (x+y);

Console.WriteLine(soma);

// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
// bool = false
// char = \0
// int = 0
// double = 0.0
// float = 0.0f
// decimal = 0.0m
// string = null