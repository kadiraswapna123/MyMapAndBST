using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapAndBinarySearch
{
    internal class UC_4_BstByAdding
    {
        // C# code to add all greater values to
        // every node in a given BST

        // A binary tree node
        public class Node
        {

            public int data;
            public Node left, right;

            public Node(int d)
            {
                data = d;
                left = right = null;
            }
        }

        public class BinarySearchTree
        {
            public Node root;

            public BinarySearchTree()
            {
                root = null;
            }

            public virtual void inorder()
            {
                inorderUtil(this.root);
            }

            public virtual void inorderUtil(Node node)
            {
                if (node == null)
                {
                    return;
                }

                inorderUtil(node.left);
                Console.Write(node.data + " ");
                inorderUtil(node.right);
            }

            public virtual void insert(int data)
            {
                this.root = this.insertRec(this.root, data);
            }

            /* A utility function to insert a new node with 
            given data in BST */
            public virtual Node insertRec(Node node, int data)
            {
                /* If the tree is empty, return a new node */
                if (node == null)
                {
                    this.root = new Node(data);
                    return this.root;
                }

                /* Otherwise, recur down the tree */
                if (data <= node.data)
                {
                    node.left = this.insertRec(node.left, data);
                }
                else
                {
                    node.right = this.insertRec(node.right, data);
                }
                return node;
            }

            public class Sum
            {
                private readonly BinarySearchTree outerInstance;

                public Sum(BinarySearchTree outerInstance)
                {
                    this.outerInstance = outerInstance;
                }

                public int sum = 0;
            }

            public virtual void modifyBSTUtil(Node node, Sum S)
            {
                if (node == null)
                {
                    return;
                }

                this.modifyBSTUtil(node.right, S);

                S.sum = S.sum + node.data;
                node.data = S.sum;

                this.modifyBSTUtil(node.left, S);
            }

            public virtual void modifyBST(Node node)
            {
                Sum S = new Sum(this);
                this.modifyBSTUtil(node, S);
            }

            public static void Main(string[] args)
            {
                BinarySearchTree tree = new BinarySearchTree();

                /* Let us create following BST
                      56
                   /     \
                  30      70
                 /  \    /  \
               20   40  60   80 */

                tree.insert(56);
                tree.insert(30);
                tree.insert(20);
                tree.insert(40);
                tree.insert(70);
                tree.insert(60);
                tree.insert(80);

                tree.modifyBST(tree.root);

                tree.inorder();
            }
        }

    }
}
