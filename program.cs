using System;

public class Calculadora
{
    public static void Main(string[] args)
    {
        //VARIABLES:
        float num, num2, soma, sub, mul, div, rest;
        int menu, loop2 = 0;
        bool loop = true;

        Console.WriteLine("----------CALCULADORA---------");
        Console.WriteLine("Olá, seja bem-vindo(a)!\n");

        while (loop == true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("----------CALCULADORA---------");
            Console.WriteLine("Digite um número:");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("OPERAÇÃO:");
            Console.WriteLine("1 [+] - 2 [-] - 3 [*] - 4 [/] - 5 [%]");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1) // SUM
            {
                soma = num + num2;
                Console.WriteLine("Resultado: " + num + " + " + num2 + " = " + soma);
            }
            else if (menu == 2) // SUBTRACTION
            {
                sub = num - num2;
                Console.WriteLine("Resultado: " + num + " - " + num2 + " = " + sub);

            }
            else if (menu == 3) // MULTIPLICATION
            {
                mul = num * num2;
                Console.WriteLine("Resultado: " + num + " * " + num2 + " = " + mul);

            }
            else if (menu == 4) // DIVISION
            {
                div = num / num2;
                Console.WriteLine("Resultado: " + num + " / " + num2 + " = " + div);
            }
            else if (menu == 5) // REST ex: 80 % 8 = 0
            {
                rest = num % num2;
                Console.WriteLine("Resultado: " + num + " % " + num2 + " = " + rest);
            }
            Console.WriteLine("Deseja fazer outra operação? 1 [SIM] - 2 [NÃO]");
            loop2 = int.Parse(Console.ReadLine());
            if (loop2 == 1)
            {
                loop = true;
            }
            else
            {
                loop = false;
            }
        }
        while (loop == false)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Volte sempre! :)");
        }
    }
}
