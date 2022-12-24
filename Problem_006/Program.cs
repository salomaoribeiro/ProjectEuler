int soma = 0, quadrado = 0;
for (int i = 1; i <= 100; i++)
{
    quadrado += i * i;
    soma += i;
}
Console.WriteLine($"Resultado: {(soma * soma) - quadrado}");