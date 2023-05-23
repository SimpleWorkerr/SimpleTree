using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
    internal class MyTree
    {
        public int Count { get; private set; }
        public Node? RootNode { get; private set; } = null;

        public void Add(int inputData)
        {

            if (RootNode == null)
            {
                RootNode = new Node(inputData);
            }
                
            else
            {

                Node? node = new Node(inputData).GetSuitNodeAdd(RootNode);

                if (node.Data < inputData)
                    node.RightChild = new Node(inputData, null, null, node);
                else
                    node.LeftChild = new Node(inputData, null, null, node);

            }
            Count++;
        }
        
        public List<int> Preorder()
        {
            if(RootNode == null)
            {
                return new List<int>();
            }

            return Preorder(RootNode);
        }

        private List<int> Preorder(Node node)
        {
            List<int> result = new List<int>();

            if(node != null)
            {
                result.Add(node.Data);

                if(node.LeftChild != null)
                {
                    result.AddRange(Preorder(node.LeftChild));
                }
                if(node.RightChild != null)
                {
                    result.AddRange(Preorder(node.RightChild));
                }
            }

            return result;
        }

        public List<int> Postorder()
        {
            if (RootNode == null)
            {
                return new List<int>();
            }

            return Postorder(RootNode);
        }
        private List<int> Postorder(Node node)
        {
            List<int> result = new List<int>();

            if (node != null)
            {
                if (node.LeftChild != null)
                {
                    result.AddRange(Postorder(node.LeftChild));
                }
                if (node.RightChild != null)
                {
                    result.AddRange(Postorder(node.RightChild));
                } 
                result.Add(node.Data);
            }

            return result;
        }

    }

}