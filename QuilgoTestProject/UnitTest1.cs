namespace QuilgoTestProject
{
   
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var arr = new[] { 1, 2,2, 3 };

            var result = HigestOccurence(arr);
            
            result.Equals(2);
        }

        public static int HigestOccurence(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            var dict = new Dictionary<int, int>();
            int max = 0;
            int occurence = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] += 1;
                    if (dict[arr[i]] > max)
                    {
                        max = dict[arr[i]];
                        occurence = arr[i];
                    }
                }
                else
                {
                    dict[arr[i]] = 1;
                }

            }

            return occurence;
        }
    }

}