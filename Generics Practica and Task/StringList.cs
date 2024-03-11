

namespace Generics_Practica_and_Task
{
    public class StringList
    {

        public string[] intArray;
        public StringList()
        {
            intArray = Array.Empty<string>();
        }

        public void Add(string num)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;

        }
        public string[] GetAll()
        {
            return intArray;

        }


    }
}
