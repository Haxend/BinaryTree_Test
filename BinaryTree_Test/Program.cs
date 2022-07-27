using System;

namespace BinaryTree_Test
{
    public class Programm
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            ////////////////
            //      5
            //     / \
            //   3     7
            //  / \   / \
            // 1   2 6   8
            //            \
            //             9
            ////////////////
            foreach (var item in tree.PreOrder())
            { 
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in tree.InOrder())
            {
                Console.Write(item + " ");
            }
        }
    }
}