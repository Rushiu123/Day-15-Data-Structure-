using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable and BinarySearchTree of Data structure");
            Console.WriteLine("Enter the option given below");      //Taking user input
            Console.WriteLine("1:Find frequency of words\n2:Find frequency of words in large paraghraph\n3:Remove avoidable word from phrase");
            Console.WriteLine("1:Find frequency of words\n2:Find frequency of words in large paraghraph\n3:Remove avoidable word from phrase\n4:Create binary search tree");
            int option = Convert.ToInt32(Console.ReadLine());

            static void  CountNumbOfOccurence(string paragraph)          //Method to get final frequency
            {
                MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);
                string[] words = paragraph.Split(' ');
                foreach (string word in words)
                {
                    if (hashTabe.Exists(word.ToLower()))
                        hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                    else
                        hashTabe.Add(word.ToLower(), 1);
                }
                Console.WriteLine("Displaying after add operation");
                hashTabe.Display();
                string s = "avoidable";
                hashTabe.Remove();
                Console.WriteLine("After removed an item {0}", s);
                hashTabe.Display();
            }
            switch (option)
            {
                case 1:
                    CountNumbOfOccurence("To be or not to be");
                    break;
                case 2:
                    CountNumbOfOccurence("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
                    break;
                case 3:
                    CountNumbOfOccurence("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
                    break;
                case 4:
                    INode root = new INode(56);
                    INode n1 = new INode(30);
                    INode n2 = new INode(70);

                    root.left = n1;
                    root.right = n2;

                    INode nodeToFind = MyBinaryNode. Search (root, 30);
                    Console.WriteLine("The node to find is:" + nodeToFind.value);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}
