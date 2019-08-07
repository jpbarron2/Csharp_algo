namespace DLL
{
    class Node
    {
        public int value;
        public Node next;
        public Node prev;
        public Node(int val, Node n = null, Node p = null){
            value = val;
            if(n != null){
                next = n;
            }
            if(p != null){
                prev = p;
            }
        }
    }
}
