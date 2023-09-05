namespace _07.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            List<long> longs = new List<long>() { 1, 2, 3 };
            List<string> strings = new List<string>() { "1", "2", "3" };
            ///PrintList(list);
            //PrintList(longs);
            //PrintList(strings);

            int[] array = { 1, 2, 3 };
            Console.WriteLine(FindElement(array, 2));

            Console.WriteLine(GetBiggestElement(1, 2, 3));
        }

        // instead of method overloading
        //static void PrintList(List<int> list)
        static void PrintList<T>(List<T> list)
        {
            Type type = typeof(T);
            Console.WriteLine(type.Name);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool FindElement<T>(T[] array, T element)
        {
            foreach (var item in array)
            {
                if (item.Equals(element))   // for all types
                // if (item == element)     // not working
                {
                    return true;
                }
            }
            return false;
        }

        // 2 T parameters
        KeyValuePair<TKey, TValue> CreateKeyValuePair<TKey, TValue>(TKey key, TValue value)
        {
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        // return T & constraints
        // use contrsaints to limit possible types for T
        static T GetBiggestElement<T>(T first, T second, T third) 
            where T: IComparable<T>     // inherits IComparable<T>
        {
            T biggest = first;

            if (second.CompareTo(biggest) > 0)
            {
                biggest = second;
            }

            if (third.CompareTo(biggest) > 0)
            {
                biggest = third;
            }
            return biggest;
        }
    }

    // generic class
    public class CustomList<T>
    {
        private T[] items;

        public CustomList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }   
}
