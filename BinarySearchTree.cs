using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }


        public void PrintPostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.WriteLine(node.Key + " " + node.Value);
            }
        }

        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }

        private void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Key + " " + node.Value);
                PreOrderTraversal(node.LeftChild);
                PreOrderTraversal(node.RightChild);
            }
        }


        public void PrintInOrderTravelsal()
        {
            InOrderTraversal(Root);
        }

        private void InOrderTraversal (TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine(node.Key + " " + node.Value);
                InOrderTraversal(node.RightChild);
            }
        }

        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);
            //If this is the first time you insert, create the root
            if(node == null)
            {
                node = newNode;
                return node;
            }

            //If this isn't the first insert, traverse, find null, insert
            if(key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }
            return node;
        }


        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            }
            else if(key < node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else if(key > node.Key)
            {
                return Find(node.RightChild, key);
            }
            return null;
        }
    }
}
