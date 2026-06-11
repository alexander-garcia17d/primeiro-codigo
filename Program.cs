// Escreva a mensagem "Informe um numero:"
Console.Write("informe um numero:");
//Cria a variavel que salva o numero , leia o que o usuario digitar e transforma o valor lido de texto para inteiro (int.parse)
int variavelQueSalvaUmNumero. = int.Parse(Console.ReadLine()!;

//verifica se o valor de variavel que salva um numero é par 
if (variavelQueSalvaUmNumero % 2 == 0) {
      Console.WriteLine("Número {variavelQueSalvaUmNumero} é par");
} else {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é ímpar");
}


