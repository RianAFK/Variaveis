// See https://aka.ms/new-console-template for more information

// Atalho de comentário: Ctrl + K + C

// String para armezenar texto
string nome = "Rian Nunes Colombaro";

// Tipo de variável para valores inteiros: 1, 2 etc
int idade = 16;

// Tipo de variável para valores decimais: 1.5, 2.5 etc
float altura = 1.75f;
double preco = 17.5;
decimal saldo = 1000.50m;
// Tipo de variável para valores lógicos: true ou false
bool estudante = true;

// Tipo de variável para valores únicos: 'A', 'B' e etc
char genero = 'M';

// Tipo de variável para valores constantes: PI = 3.14
const double PI = 3.14;

// Forma 1
Console.WriteLine(nome);

// Forma 2 - Interpulação de strings
Console.WriteLine($"O {nome} tem {idade} anos");

// Forma 3 - Concatenação de strings
Console.WriteLine("O " + nome + " tem " + idade + " anos");

// Utilizando \n para pular uma linha
// Semelhante ao <br> do HTML que já utilizamos
Console.WriteLine($"\n O valor de pi é: {PI}");