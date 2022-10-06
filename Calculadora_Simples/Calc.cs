namespace CalculateSimple
{
    internal class Calculate
    {
        public void Add() // adição
        {
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");

        }
        public void Subtract() // subtração
        {
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiply() // Multiplicação
        {
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Divide() // Divisão
        {
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Power() // Potenciação
        {
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            double potential = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potential}");
        }
        public void Sine() // Seno
        {
            Console.WriteLine("Digite o primeiro número:");
            double angle = Convert.ToInt32(Console.ReadLine());

            double radians = angle * Math.PI / 180; // Conversão para radiano
            double sine = Math.Sin(radians);
            Console.WriteLine($"Seno de {angle}º = {Math.Round(sine, 4)}");
        }

        public void Cosine() // Coseno
        {
            Console.WriteLine("Digite o primeiro número:");
            double angle = Convert.ToInt32(Console.ReadLine());

            double radians = angle * Math.PI / 180;
            double cosine = Math.Cos(radians);
            Console.WriteLine($"Coseno de {angle}º = {Math.Round(cosine, 4)}");
        }

        public void Tangent() // Tangente
        {
            Console.WriteLine("Digite o primeiro número:");
            double angle = Convert.ToInt32(Console.ReadLine());

            double radians = angle * Math.PI / 180;
            double tangent = Math.Tan(radians);
            Console.WriteLine($"Tangente de {angle}º = {Math.Round(tangent, 4)}");
        }
        public void SquareRoot() // Raiz quadrada
        {
            Console.WriteLine("Digite o primeiro número:");
            double x = Convert.ToInt32(Console.ReadLine());

            double root = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de: {x} = {Math.Round(root, 4)}");
        }
    }
}
