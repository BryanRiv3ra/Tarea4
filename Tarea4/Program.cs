//int x = 2;
//while (x <= 10)
//{
//    Console.WriteLine(x);
//    x = x + 2;
//}

//int x = 1;
//int suma = 0;
//while (x <= 10)
//{
//    suma += x;
//    Console.WriteLine(x);
//    x++;
//}
//Console.WriteLine(suma);
//int num = 0;
//do
//{
//    Console.WriteLine("ingrese un numero entero");
//    int.TryParse(Console.ReadLine(), out num);
//}
//while (num >= 0);
//{
//    Console.WriteLine("ingreso un numero negativo el programa se cerrara");
int numero = 1;
while (true)
{

    if (numero % 7 == 0 && numero % 11 == 0)
    {
        Console.WriteLine("¡El número es divisible entre 7 y 11! Cerrando el programa.");
        break;
    }
}