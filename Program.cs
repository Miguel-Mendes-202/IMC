double Peso, Altura, imc;

Console.WriteLine("Digite seu Peso(KG)");
Peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora sua Altura(m)");
Altura = Convert.ToDouble(Console.ReadLine());

imc= Peso/Math.Pow ("Altura, 2");


Console.WriteLine($"\nIMC: {imc:N1} kg/m²");