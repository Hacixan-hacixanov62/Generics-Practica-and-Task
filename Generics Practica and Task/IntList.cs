
namespace Generics_Practica_and_Task
{
    public class IntList
    {
        //public int age { get; set; }

        public int[] intArray;
        public IntList()
        {
            intArray = Array.Empty<int>();
        }

        public void Add(int num)
        {
            Array.Resize(ref intArray,intArray.Length+1 );  
            intArray[intArray.Length-1] = num;
        
        }
        public int[] GetAll()
        {
            return intArray;
        
        }
    }
}
 