using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree
    {
        private Node Root { get; set; }
        public int Count;
        public int Height
        {
            get
            {
                return 0;
            }
        }
        private int CountRecursive(Node n)
        {
            throw new NotImplementedException();
        }
        public void Insert(char val)
        {
            if(Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Insert(Root, val);
            }
        }
        private void Insert(Node cur,char val)
        {
            if(val >= cur.Value && cur.RightChild==null)
            {
                cur.RightChild = new Node(val);
                return;
            }
            if(val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new Node(val);
                return;
            }
            if (val > -cur.Value)
                Insert(cur.RightChild, val);
            else if (val < cur.Value)
                Insert(cur.LeftChild, val);
        }
        public bool Remove(char c)
        {
            throw new NotImplementedException();
        }
        private bool Remove(Node n, char c)
        {
            throw new NotImplementedException();
        }
        public bool Search(char c)
        {
            throw new NotImplementedException();
        }
        private bool Search(Node cur, char val)
        {
            bool found = false;
            if(val > cur.Value && cur.RightChild != null)
            {
                Search(cur.RightChild, val);
            }
            if (val < cur.Value && cur.LeftChild != null)
            {
                Search(cur.LeftChild, val);
            }
            else if (val == cur.Value)
                return found = true;
            else
                return found = false;
            return found;
            //throw new NotImplementedException();
        }
        //public void Balance(){}
        public void PreOrderPrint()
        {
            List<Node> node = new List<Node>();
            
        }
        private void PreOrderPrint(Node cur)
        {
        }
        private void InOrderPrint()
        {

        }
        public void InOrderPrint(Node cur)
        {
            if (cur.LeftChild != null)
            {
                PreOrderPrint(cur.LeftChild);
            }
        }
        private void PostOrderPrint()
        {

        }
        public void PostOrderPrint(Node cur)
        {

        }

    }
}
