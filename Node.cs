using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
    internal class Node
    {
        public Node? Parent { get; set; }
        public Node? LeftChild { get; set; }
        public Node? RightChild { get; set; }
        public int Data { get; private set; }

        public Node(int data, Node? rightChild = null, Node? leftChild = null, Node? parent = null)
        {
            Parent = parent;
            RightChild = rightChild;
            LeftChild = leftChild;
            Data = data;
        }

        /// <summary>
        /// рекурсивный метод, возвращающий наиболее подходящий узел относительно своего предка
        /// </summary>
        /// <param name="tempNode">параметр являющийся предком, от которого нужно начинать поиск</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Node GetSuitNodeAdd(Node tempNode)
        {
            if (tempNode.Data < Data && tempNode.RightChild == null)
            {
                return tempNode;
            }
            else if (tempNode.Data > Data && tempNode.LeftChild == null)
            {
                return tempNode;
            }

            else
            {
                if (tempNode.Data > Data && tempNode.LeftChild != null)
                {
                    return GetSuitNodeAdd(tempNode.LeftChild);
                }
                else if (tempNode.Data < Data && tempNode.RightChild != null)
                {
                    return GetSuitNodeAdd(tempNode.RightChild);
                }
                else
                {
                    throw new Exception("Не может быть повторяющихся элементов");
                }
            }
        }
              
    }
}
