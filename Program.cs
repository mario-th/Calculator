class Program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        var cientifica = new Cientifica();
        
        Console.WriteLine(calculadora.nombre);
        Console.WriteLine(calculadora.modelo = 5622); 
        Console.WriteLine("Bienvenido");
        Console.WriteLine("introduzca el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introduzca el segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escoja una opcion:");
        Console.WriteLine("1. sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Raiz");
        Console.WriteLine("6. Potencia");
        Console.WriteLine("7. Modulo");
        Console.WriteLine("8. Logaritmo");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion){
            case 1:
                Console.WriteLine($"El resultado de {num1} + {num2} es: " + calculadora.Sumar(num1, num2));
                break;
            case 2:
                Console.WriteLine($"El resultado de {num1} - {num2} es: " + calculadora.Restar(num1, num2));
                break;
            case 3:
                Console.WriteLine($"El resultado de {num1} * {num2} es: " + calculadora.Multiplicar(num1, num2));
                break;
            case 4:
                Console.WriteLine($"El resultado de {num1} / {num2} es: " + calculadora.Dividir(num1, num2));
                break;
            case 5:
                Console.WriteLine($"La raiz de {num1} es: " + cientifica.Raiz(num1));
                break;
            case 6:
                Console.WriteLine($"La potencia de {num1} elevado a la {num2} es: " + cientifica.Potencia(num1, num2));
                break;
            case 7:
                Console.WriteLine($"El modulo de {num1} , {num2} es: " + cientifica.Modulo(num1, num2));
                break;
            case 8:
                Console.WriteLine($"El logaritmo de {num1} es: " + cientifica.Logaritmo(num1));
                break;
            default:
                Console.WriteLine("La opcion no es valida");
                break;
        }
    }

    class Calculadora
    {
        public string nombre = "Casio";
        public int modelo;

        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Cientifica: Calculadora{
        public double Raiz(double num1){
            return Math.Sqrt(num1);
        }

        public double Potencia(double num1, double num2){
            return Math.Pow(num1, num2);
        }

        public double Modulo(double num1, double num2){
            return num1 % num2;
        }

        public double Logaritmo(double num1){
            return Math.Log(num1);
        }
    }
}