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

                Node? node = new Node(inputData).GetSuitNode(RootNode);

                if(node.Data < inputData)
                    node.RightChild = new Node(inputData, null, null, node);
                else
                    node.LeftChild = new Node(inputData, null, null, node);

            }
            Count++;
        }
    }
}