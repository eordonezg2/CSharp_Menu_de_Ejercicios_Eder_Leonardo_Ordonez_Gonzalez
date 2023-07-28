using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        string ejericicio1()
        {
            Console.WriteLine("Verificar si un numero es par o no");
            int Ln_numero;
            Console.WriteLine("Ingrese el numero");
            Ln_numero = Convert.ToInt32(Console.ReadLine());
            if (Ln_numero % 2 == 0)
            {
                return "Es par";
            } else
            {
                return "No es impar";
            }
        }

        string ejercicio2()
        {
            Console.WriteLine("El mayor de tres numeros ingresados");
            int Ln_numero1, Ln_numero2, Ln_numero3;
            Console.WriteLine("Ingrese los tres numeros");
            Ln_numero1 = Convert.ToInt32(Console.ReadLine());
            Ln_numero2 = Convert.ToInt32(Console.ReadLine());
            Ln_numero3 = Convert.ToInt32(Console.ReadLine());
            if (Ln_numero1 > Ln_numero2 && Ln_numero1 > Ln_numero3)
            {
                return Ln_numero1 + " Es mayor";
            } if (Ln_numero2 > Ln_numero1 && Ln_numero2 > Ln_numero3)
            {
                return Ln_numero2 + " Es mayor";
            } if (Ln_numero3 > Ln_numero1 && Ln_numero3 > Ln_numero2)
            {
                return Ln_numero3 + " Es mayor";
            }
            else
            {
                return "Los numeros son iguales";
            }
        }

        string ejercicio3()
        {
            Console.WriteLine("Verificar si un numero es divisible para otro");
            Console.WriteLine("Ingrese el primer numero");
            int Ln_numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int Ln_numero2 = Convert.ToInt32(Console.ReadLine());
            if (Ln_numero1 % Ln_numero2 == 0)
            {
                return Ln_numero1 + " si es divisible para " + Ln_numero2;
            }
            else
            {
                return Ln_numero1 + " no es divisible para " + Ln_numero2;
            }
        }

        string ejercicio4()
        {
            Console.WriteLine("Verificar si una cadena contiene mas de 5 caracteres");
            Console.WriteLine("Ingresa la cadena");
            string Lv_cadena = Console.ReadLine();
            int Ln_longitud = Lv_cadena.Length;
            if (Ln_longitud > 5)
            {
                return "La cadena tiene mas de 5 caracteres";
            }
            else
            {
                return "La cadena no tiene mas de 5 caracteres";
            }

        }

        int[] ejercicio5()
        {
            Console.WriteLine("Dado un arreglo de numeros ingresado por el usuario, presentar uno por uno con su posicion");
            Console.WriteLine("Ingresa el numero de elementos para el arreglo");
            int Ln_elementos = Convert.ToInt32(Console.ReadLine());
            int[] La_arreglo = new int[Ln_elementos];
            for (int i = 0; i < Ln_elementos; i++)
            {
                Console.WriteLine("Ingresa el elemento " + (i+1));
                La_arreglo[i] =Convert.ToInt32(Console.ReadLine());
            }
            return La_arreglo;
        }

        string ejercicio6()
        {
            Console.WriteLine("Dado un arreglo de numeros ingresado por el usuario, presentar los numeros impares y la suma de ellos");
            Console.WriteLine("Ingresa el numero de elementos para el arreglo");
            int Ln_elementos = Convert.ToInt32(Console.ReadLine());
            int[] La_arreglo = new int[Ln_elementos];
            for (int i = 0; i < Ln_elementos; i++)
            {
                Console.WriteLine("Ingresa el elemento " + (i + 1));
                La_arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Ln_suma = 0;
            int Ln_longitud = La_arreglo.Length;
            Console.WriteLine("Los elementos impares dentro del arreglo son:");
            for (int i = 0; i < Ln_longitud; i++)
            {
                if (La_arreglo[i] % 2 != 0)
                {
                    Console.WriteLine("Posicion [" + i + "] = " + La_arreglo[i]);
                    Ln_suma = Ln_suma + La_arreglo[i];
                }
            }
            return "La suma de ellos es: " + Ln_suma;
        }
        
        int[,] ejercicio7(int Ln_filas, int Ln_columnas)
        {
            int[,] Lm_matriz=new int[Ln_filas, Ln_columnas];

            for (int i = 0; i < Ln_filas; i++)
            {
                for (int j = 0; j < Ln_columnas; j++)
                {
                    Console.WriteLine("Ingresa el elemento en la posición : [" + i + "," + j + "]");
                    Lm_matriz[i, j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            return Lm_matriz;
        }

        string ejericicio8()
        {
            Console.WriteLine("Cuantas vocales hay en una cadena");
            Console.WriteLine("Ingresa la cadena a comprobar");
            string Lv_cadena = Console.ReadLine();
            int Ln_cont = 0;
            string Lv_vocales = "aeiouAEIOU";

            for (int i = 0; i < Lv_cadena.Length; i++)
            {
                char Lv_caracter = char.ToLower(Lv_cadena[i]);
                if (Lv_vocales.IndexOf(Lv_caracter) != -1)
                {
                    Ln_cont++;
                }
            }

            return "Hay " + Ln_cont + " vocales en la cadena ingresada";
        }
        
        string ejercicio9()
        {
            Console.WriteLine("Verificar si un numero es primo");
            Console.WriteLine("Ingresa el numero a comprobar");
            int Ln_numero=Convert.ToInt32(Console.ReadLine());
            int Ln_cont=0;
            int x=1;
            while (Ln_cont<=3 && x<=Ln_numero)
            {
                if (Ln_numero%x==0)
                {
                    Ln_cont=Ln_cont+1;
                }
                x=x+1;
            }
            if (Ln_cont==2)
            {
                return "Es primo";
            }
            else
            {
                return "No es primo";
            }
        }

        string ejercicio10()
        {
            Console.WriteLine("La suma de todos los multiplos de 5 de un rango de numeros");
            int Ln_suma = 0;
            Console.WriteLine("Desde que numero deseas iniciar");
            int Ln_Inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasta que numero ");
            int Ln_final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los multiplos encontrados son:");
            for(int i=Ln_Inicio; i<Ln_final; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    Ln_suma = Ln_suma + i;
                }
            }
            return "La suma es:" + Ln_suma;
        }

        string ejercicio11()
        {
            Console.WriteLine("Presentar la cantidad de comas y puntos que tiene una cadena");
            Console.WriteLine("Ingresa la cadena a comprobar");
            string Lv_cadena = Console.ReadLine();
            int Ln_longitud = Lv_cadena.Length;
            int i = 0;
            int Ln_contador = 0;
            while (i <= Ln_longitud-1)
            {
                if (Lv_cadena[i] == ',' || Lv_cadena[i] == '.')
                {
                    Ln_contador = Ln_contador + 1;
                }
                i++;
            }
            return "El numero de comas y puntos en la cadena es:" + Ln_contador;
        }

        string ejercicio12()
        {
            Console.WriteLine("Presentar el numero maximo en un arreglo con numeros");
            Console.WriteLine("Ingresa la cantidad de numeros para el arreglo");
            int Ln_elementos =Convert.ToInt32(Console.ReadLine());
            int[] La_arreglo = new int[Ln_elementos];
            int i = 0, Ln_maximo = int.MinValue, Ln_numeros = 0;
            while (i < Ln_elementos)
            {
                Console.WriteLine("Ingresa el numero " + (i + 1));
                Ln_numeros = Convert.ToInt32(Console.ReadLine());
                La_arreglo[i] = Ln_numeros;
                i++;
            }
            foreach (int q in La_arreglo) 
            {
                if (q > Ln_maximo)
                {
                    Ln_maximo = q;
                }
            }
            return "El numero maximo dentro del arreglo es: " + Ln_maximo;
        }
        
        string ejercicio13()
        {
            Console.WriteLine("Presentar la cantidad de numeros en una cadena y la suma de ellos.");
            Console.WriteLine("Ingrese la cadena a comprobar");
            string Lv_cadena = Console.ReadLine();
            int Ln_contador = 0;
            int Ln_suma = 0;
            int i = 0;
            while (i < Lv_cadena.Length)
            {
                if (char.IsDigit(Lv_cadena[i]))
                {
                    Ln_contador=Ln_contador+1;
                    Ln_suma = Ln_suma + Convert.ToInt32(Lv_cadena[i].ToString());

                }

                i++;
            }

            return "La cantidad de números en la cadena es: " + Ln_contador + "\n" +
                "La suma de ellos es: " + Ln_suma;
        }
        
        string ejercicio14()
        {
            Console.WriteLine("Ingresar un numero hasta que introduzca uno negativo");
            int Ln_numero;
            do
            {
                Ln_numero = Convert.ToInt32(Console.ReadLine());
                if (Ln_numero > 0)
                {
                    Console.WriteLine(Ln_numero + " es positivo");

                }
                if(Ln_numero < 0)
                {
                    Console.WriteLine(Ln_numero + " es negativo");
                }
                if(Ln_numero == 0)
                {
                    Console.WriteLine(Ln_numero + " es neutro");
                }
            } while (Ln_numero > -1);
            return "Ingresaste un numero negativo, fin del proceso";
        }

        string ejercicio15()
        {
            Console.WriteLine("Ingresar una cadena hasta que se introduzca una de menos de 5 caracteres");
            string Lv_cadena;
            do
            {
                Console.WriteLine("Ingresa una cadena");
                Lv_cadena = Console.ReadLine();
            } while (Lv_cadena.Length > 4);
            return "Ingresastes una cena de menos de 5 caracteres, fin del proceso";
        }

        //Menu de ejericicios con IF-ElSE, WHILE, FOR, DO-WHILE, SWITCH, CADENAS Y ARREGLOS.
        //Se desarrollo 15 ejercicios y se estructuró el siguiente menu de 15 opciones para ejecutarlos respectivamente.
        int opcion=1;
            while (opcion != 0 || opcion!= 16)
            {
            Console.WriteLine("Menú de ejercicios");
            Console.WriteLine("1.- Verificar si un numero es par o no\n" +
                              "2.- El mayor de 3 numeros ingresados\n" +
                              "3.- Verificar si un numero es divisor de otro\n" +
                              "4.- Comprobar si una cadena tiene mas de 5 caracteres\n" +
                              "5.- Presentar los numeros de un arreglo con sus indices\n" +
                              "6.- Presentar los numeros impares de un arreglo y la suma de ellos \n" +
                              "7.- Presentar los numeros de una matriz y la suma de ellos \n" +
                              "8.- Presentar cuantas vocales tiene una cadena \n" +
                              "9.- Verificar si un numero es primo o no \n" +
                              "10.- Suma de todos los multiplos de 5 en un rango de numeros \n" +
                              "11.- Presentar la cantidad de comas y puntos que hay en una cadena \n" +
                              "12.- Presenatar el numero maximo de un arreglo \n" +
                              "13.- Dado una cadena presentar la cantidad de numeros que tiene \n" +
                              "14.- Ingresar un numero hasta que se introduzca uno negativo \n" +
                              "15.- Ingresar cadenas hasta que se introduzca una de menos de 5 caracteres \n" +
                              "16.- Salir");
            Console.WriteLine("Eliija una opcion del 1 al 15");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(ejericicio1());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine(ejercicio2());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine(ejercicio3());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine(ejercicio4());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 5:
                    int[] La_arreglo = ejercicio5();
                    int Ln_longitud = La_arreglo.Length;
                    Console.WriteLine("Los elementos dentro del arreglo son:");
                    for (int i = 0; i < Ln_longitud; i++)
                    {
                        Console.WriteLine("Posicion [" + i + "] = " + La_arreglo[i]);
                    }
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine(ejercicio6());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine("Dado una matriz ingresada por el usuario, presentar los numeros y la suma de todo ellos");
                    Console.WriteLine("Ingresa el numero de filas para la matriz");
                    int Ln_filas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el numero de columnas para la matriz");
                    int Ln_Columnas = Convert.ToInt32(Console.ReadLine());
                    int Ln_suma = 0;
                    int[,] Lm_matriz = ejercicio7(Ln_filas, Ln_Columnas);
                    Console.WriteLine("Elementos dentro de la matriz:");
                    for (int i = 0; i < Ln_filas; i++)
                    {
                        for (int j = 0; j < Ln_Columnas; j++)
                        {
                            Ln_suma = Ln_suma + Lm_matriz[i, j];
                            Console.WriteLine("Elemento en la posición : [" + i + "," + j + "] = " + Lm_matriz[i, j]);
                        }
                    }
                    Console.WriteLine("La suma de todos los elementos de la matriz es: " + Ln_suma);
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 8:
                    Console.WriteLine(ejericicio8());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine(ejercicio9());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 10:
                    Console.WriteLine(ejercicio10());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 11:
                    Console.WriteLine(ejercicio11());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 12:
                    Console.WriteLine(ejercicio12());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 13:
                    Console.WriteLine(ejercicio13());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 14:
                    Console.WriteLine(ejercicio14());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 15:
                    Console.WriteLine(ejercicio15());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
            }
            if (opcion == 16)
            {
                Console.WriteLine("Saliendo del programa, gracias por su visita, vuelva pronto");
                Thread.Sleep(3000);
                break;
            }
          }
        }
    }        






