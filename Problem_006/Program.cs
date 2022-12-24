// Minha solução
int soma = 0, quadrado = 0;
for (int i = 1; i <= 100; i++)
{
    quadrado += i * i;
    soma += i;
}
Console.WriteLine($"Soma2  {soma * soma}");
Console.WriteLine($"Soma Quadrados  {quadrado}");
Console.WriteLine($"Resultado: {(soma * soma) - quadrado}\n\n");

// Solução do site
var limite = 100;
var soma2 = limite * (limite + 1) / 2;
var somaQuadrados = (2 * limite + 1) * (limite + 1) * limite / 6;

Console.WriteLine($"Soma2  {soma2 * soma2}");
Console.WriteLine($"Soma Quadrados  {somaQuadrados}");
Console.WriteLine(soma2 * soma2 - somaQuadrados);