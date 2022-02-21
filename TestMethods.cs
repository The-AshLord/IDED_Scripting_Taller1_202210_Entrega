using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        //Definición para el Ejercicio 2
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
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
                dataList.Add(dato);

                //Recorro dataList
                for (int i = 0;i <dataList.Count; i++)
                {
                    //Reviso si hay el valor de biggestData es menor que el de cada elemento de dataList
                    if(biggestData < dataList[i])
                    {
                        //Si algun Valor es mayor, lo actualizo
                        biggestData = dataList[i];
                    }
                }
            
                //Como ya tengo actualizado el valor de biggestData, puedo empezar a llenar auxStuck
                //Si mi dato actual es menor que biggestData...
                if (dato < biggestData)
                {
                    //Agrego el valor mayor posterior anterior (biggestData) a auxStuck 
                    auxStack.Push(biggestData);
                }
                else 
                {
                    //De lo contraio, agrego un -1 a biggestData
                    auxStack.Push(-1)    
                }            
            }
        
            //Ya solo queda vaciar auxStuck para llenar result
            while (auxStack != null)
            {
                    result.Push(auxStack.Pop) //lo que saco de auxStuck lo meto en result
                    //De esta manera me aseguro de que los valores en result queden en el orden correcto
            }

            //devuelvo mi pila con las respuestas papara la posterior verificación
            return result;
        }

        //Ejercicio 2A
        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        //Ejercicio 2B
        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        //Ejercicio 2C
        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        //Ejercicio 3A
        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        //Ejercicio 3B
        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}