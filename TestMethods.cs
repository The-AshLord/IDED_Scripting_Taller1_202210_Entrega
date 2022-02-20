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
            Stack<int> result = new Stack<int>(); //Crea la pila para los resultados


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