namespace List_the_elements
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));

            int input2 = int.Parse(Console.ReadLine());

            List<int> output = UserProgramCode.GetElements(list, input2);

            if (output.Count == 1 && output[0] == -1)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                foreach (int x in output)
                    Console.Write(x + " ");
            }
        }
    }
}
