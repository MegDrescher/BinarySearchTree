using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.cs
{
    class BinarySTree
    {

        public Node rootNode;
        public Random random;
        public object Data;
        public Node Left;
        public Node Right;
        public Node Parent;

        public Node root;


        public BinarySTree()
        {
            random = new Random();
            rootNode = new Node(100);
            root = null;
        }
        public void InsertNode(object data)  //
        {
            Node newNode = new Node(data);
            if (root.Data == null)
                root = newNode;
            else
            {
                Node current = root;
                while (true)
                {
                    Node tempParent = current;
                    if (Convert.ToInt32(newNode.Data) < Convert.ToInt32(current.Data))
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            tempParent = current.Left;
                            if (current == null)
                            {
                                tempParent.Left = newNode;
                                newNode.Parent = tempParent;
                                return;
                            }
                        }
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                tempParent.Right = newNode;
                                newNode.Parent = tempParent;
                                return;
                            }
                        }
                    }
                }      
            }   
        }

        public void InOrderTransversal(Node Root)
        {   
            if(Root != null)
            {
                InOrderTransversal(Root.Left);
                Console.WriteLine(Root.Left + " ");
                InOrderTransversal(Root.Right);
            }

        }

        public bool Search(TreeNode root, int target)
        {
            if(root == null)
            {
                Console.WriteLine("End of Binary Search Tree");
                return false;
            }
            else if (target < root.data)
            {
                Console.WriteLine("Not a current branch of the Binary Search Tree");
                return Search(root.Left, target);
            }
            else if (target > root.data)
            {
                Console.WriteLine("This is a current branch of the Binary Search Tree");
                return Search(root.Left, target);
            }
            return true;
        }

        private bool Search(object left, int target)
        {
            throw new NotImplementedException();
        }
    }
}
