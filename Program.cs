namespace ArrayADT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IntegerArray IA = new IntegerArray(9);
            IA.insert(0,56); IA.insert(1,49); IA.insert(2,67); 
            IA.insert(3,21); IA.insert(4,90);

            IA.traverse();

            IA.insert(1, 70);
            IA.traverse();

            int index=IA.search(67);
            if (index == -1)
                Console.WriteLine(67 + " not found!");
            else
                Console.WriteLine(67 + " found at position " + index);
            index=IA.search(10);
            if (index == -1)
                Console.WriteLine(10 + " not found!");
            else
                Console.WriteLine(10 + "found at position " + index);

            IA.delete(49); IA.traverse();
            IA.delete(10);
        }
    }
}