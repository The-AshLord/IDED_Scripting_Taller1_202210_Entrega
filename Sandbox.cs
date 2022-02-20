 using System;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");
        }
    }


    //Ejercicio 1:
    internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
    {
        Stack<int> result = new Stack<int>(); //Crea la pila para los resultados

        While(sourceStack()! = null) {
            Int dato = sourceStack.pop();
            Situar(dato, result, new Stack<int>());
        }

        return result;
    }

}