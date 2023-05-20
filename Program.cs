namespace SimpleTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTree tree = new MyTree();
            tree.Add(5);
            tree.Add(3);
            tree.Add(8);
            tree.Add(4);
            tree.Add(1);
            tree.Add(2);
            tree.Add(7);
            tree.Add(9);
            tree.Add(6);

            foreach(var item in tree.Preorder())
            {
                Console.WriteLine(item);
            }
        }
    }
}