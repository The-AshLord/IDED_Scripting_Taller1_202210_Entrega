 using System;
 using System.Collections.Generic; //agrego esto para usar Sandbox de borrador

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
        //para evitarnos problemas, vamos a hacer un back up de la Pila Fuente:
        int[] trasnferSourceToArray = sourceStack.ToArray(); //Trasferimos a un arreglo todo el contenido de sourceStack

        //Creamos las estructuras que vamos a utilizar
        Stack<int> calkStack = new Stack<int>(); //Crea la pila en la que vamos a calcar a sourceStack
        Stack<int> auxStack = new Stack<int>(); //Crea la pila Auxiliar
        Stack<int> result = new Stack<int>(); //Crea la pila para los resultados
        List<int> dataList = new List<int>(); //Crea una lista para ordenar los resultados 

        //Llenamos la Pila calkStack con el contenido del Aregglo de Trasferencia
        for (int i =trasnferSourceToArray.Length -1, i >= 0; i--)
        {
            calkStack.Push(trasnferSourceToArray[i]); 
        }

        //Mientras en calkStack haya elemntos: 
        while(calkStack()! = null) {

            int dato = calkStack.pop();
            int biggestData = dato; 
            elementList.Add(dato);
            ColocarEnPilas(dato,result,auxStack);
            
        }
        
        return result;
    }

    private void ColocarEnPilas (int dato, Stack<int> auxStack, List<int> elementList)
    {

        if (auxStack.peek() == null)
        {
            result.push(-1);
            //luego tenemos que llevar todos los platos de auxStack a result
        }
        else
        {
            if (dato.compareTo(result.peek() < 0))
            {

            }
        }
    }



}