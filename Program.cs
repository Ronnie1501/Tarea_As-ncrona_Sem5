// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("ingresar el valor con que desea iniciar: ");
           int valorinicial = int.Parse(Console.ReadLine());

           Console.Write("ingrese el valor final: ");
           int valorFinal = int.Parse(Console.ReadLine());

           Console.Write("los numeros pares ingresados son: ");

           for (int i = valorinicial; i <= valorFinal; i++)
           {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
           }    

    






