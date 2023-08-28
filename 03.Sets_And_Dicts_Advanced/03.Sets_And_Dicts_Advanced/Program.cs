namespace _03.Sets_And_Dicts_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Pesho", 3);
            dict["Pesho"] = 4;
            dict["Gosho"] = 3;
            // Console.WriteLine(dict["Gosho"]);   // 3
            dict.Remove("Gosho");

            foreach (KeyValuePair<string, int> kvpair in dict)
            {
                // Console.WriteLine($"{kvpair.Key} -> {kvpair.Value}");
            }

            if (dict.ContainsKey("Pesho"))      // fast
            {
                // Console.WriteLine("Pesho is here");
            }

            if (dict.ContainsValue(3))          // slow!!!
            {
                // Console.WriteLine("3 is here");
            }

            // Console.WriteLine(dict.Count);      // 1

            // ----------------------------------------------

            // Sorted Dictionary        // by key
            SortedDictionary<string, int> sortedDict =
                new SortedDictionary<string, int>(new MyComparer());
            sortedDict.Add("Pesho", 3);
            sortedDict.Add("Gosho", 5);
            sortedDict.Add("Dasho", 4);

            foreach (var kvpair in sortedDict)
            {
                // Console.WriteLine($"{kvpair.Key} -> {kvpair.Value}");
            }

            // Task1();

            // ----------------------------------------------

            // Sorting
            List<int> list1 = new List<int>() { 11, 2, -3, 4, 15 };
            // list.Sort();            // sort ascending
            var list2 = list1.OrderBy(x => x).ToList(); //doesnt change list1!
            var list3 = list1.OrderBy(x => x % 2).ToList(); //even first
            var list4 = list1.OrderByDescending(x => x).ToList(); //descending
            // Console.WriteLine(String.Join(", ", list1));
            // Console.WriteLine(String.Join(", ", list2));

            var products = new Dictionary<string, double>();
            products.Add("beer", 1.2);
            products.Add("chips", 2.3);
            products.Add("cola", 1.5);
            var sortedProducts = products
                .OrderBy(x => -x.Value)    // first by value descending
                .ThenBy(x => x.Key)        //then by key ascending
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(String.Join(", ", sortedProducts));
            // [chips, 2.3], [cola, 1.5], [beer, 1.2]

            // ----------------------------------------------
            // Nested dictionaries

            var grades = new Dictionary<string, List<int>>();
            grades.Add("Pesho", new List<int>() { 2, 3, 4 });
            grades["Pesho"].Add(5);

            var countires = new Dictionary<string, Dictionary<string, int>>();
            countires.Add("Bulgaria", new Dictionary<string, int>());
            countires["Bulgaria"].Add("Sofia", 2000000);

            // ----------------------------------------------
            // Sets

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            set1.Add(6);
            set1.Remove(3);
            Console.WriteLine(set1.Contains(3));    // very fast

            SortedSet<int> set2 = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // ----------------------------------------------

        }

        class MyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return y.CompareTo(x);  //Reverse
            }
        }

        static void Task1()
        {
            double[] input = Console.ReadLine()
                .Split().Select(double.Parse).ToArray();
            Dictionary<double, int> myDict = new Dictionary<double, int>();
            
            foreach (var item in input)
            {
                if (!myDict.ContainsKey(item))
                {
                    myDict.Add(item, 0);
                }
                myDict[item]++;
            }

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}