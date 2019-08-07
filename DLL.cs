namespace DLL
{
    class DLL
    {
        Node head, tail;
        int count;
        public DLL(){
            count = -1;
        }
        public DLL addToFront(int val){
            Node n = new Node(val);
            if(count > -1){
                n.next = head;
                head = n;
                n.next.prev = n;
            }else{
                head = n;
                tail = n;
            }
            count++;
            return this;
        }
        public DLL addToBack(int val){
            Node n = new Node(val);
            if(count > -1){
                n.prev = tail;
                tail = n;
                n.prev.next = n;
            }else{
                head = n;
                tail = n;
            }
            count++;
            return this;
        }
        public DLL removeFromBack(){
            if(count==-1){
                return null;
            }else{
                tail = tail.prev;
                tail.next = null;
            }
            if(count ==1){
                head = null;
                tail = null;
            }
            count--;
            return this;
        }
        public DLL removeFromFront(){
            if(count==-1){
                return null;
            }else{
                head = head.next;
                head.prev = null;
            }
            if(count ==0){
                head = null;
                tail = null;
            }
            count--;
            return this;
        }
        public DLL insert(int k, int val){
            if(count == -1){
                Node n = new Node(val);
                Node head = tail = n;
            }else if(k > count-1){
                System.Console.WriteLine($"That index does not exist in this List, there are {count} items in this list");
            }else if(k == count){
                addToBack(val);
            }else if(k ==0){
                addToFront(val);
            }else{
                Node runner = head;
                int run =0;
                while(run != k){
                    run++;
                    runner = runner.next;
                }
                Node n = new Node(val);
                n.prev = runner.prev;
                n.next = runner;
                runner.prev.next = n;
                runner.prev = n;
            }
            return this;
        }
    }
}
