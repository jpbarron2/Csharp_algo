using System;

namespace DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL List = new DLL();
            List.addToFront(2);
            List.addToBack(6);
            List.addToFront(1);
            List.addToFront(2);
            List.insert(1, 5);
            // List.removeFromBack();
            // List.removeFromFront();
        }
    }
}
