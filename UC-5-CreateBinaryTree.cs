using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapAndBinarySearch
{
    internal class UC_5_CreateBinaryTree
    {
        // Class containing left and
        // right child of current node
        // and key value
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;

        BinarySearchTree() { root = null; }

        BinarySearchTree(int value) { root = new Node(value); }

        void insert(int key) { root = insertRec(root, key); }

        Node insertRec(Node root, int key)
        {

            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            return root;
        }

        void inorder() { inorderRec(root); }

        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }

        public static void Main(String[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            /* Let us create following BST
                  56
               /     \
              30      70
             /  \    /  \
           22   40  60   95 */
           /          \
          11          65
          / \         / \
         3   16      63  67
            tree.insert(56);
            tree.insert(30);
            tree.insert(22);
            tree.insert(40);
            tree.insert(11);
            tree.insert(3);
            tree.insert(16);
            tree.insert(70);
            tree.insert(60);
            tree.insert(95);
            tree.insert(65);
            tree.insert(63);
            tree.insert(67);

            tree.inorder();
        }
    }
}

