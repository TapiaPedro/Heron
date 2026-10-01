double lado1, lado2, lado3;
double p; //semiperímetro 
double area; 

Console.WriteLine("Digite os lados do triângulo\n");

Console.Write("Lado 1: ");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado 2: ");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado 3: ");
lado3 = Convert.ToDouble(Console.ReadLine());

p = (lado1 + lado2 + lado3) / 2;
area = Math.Sqrt (p* (p - lado1) * (p - lado2) * (p - lado3));
//Math.Sqrt é para calcular raiz quadrada

Console.WriteLine($"Semiperímetro: {p}"); //o {p} seria o resultado da operação da linha 17
Console.WriteLine($"Área: {area}");