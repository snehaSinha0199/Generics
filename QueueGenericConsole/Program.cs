using System.Collections;
using System.Collections.Generic;
using Generics;
using System.Linq;

//Non generic type of queues
Console.WriteLine("NON GENERIC OF QUEUE...........");
Queue queueObj = new Queue();
queueObj.Enqueue(10);
queueObj.Enqueue(20);
queueObj.Enqueue(10);
queueObj.Enqueue(20);
queueObj.Enqueue(20.9);
queueObj.Enqueue(true);
queueObj.Enqueue(new Student());
Console.WriteLine("Printing which enqueued");
foreach(var output in queueObj)
{
    Console.WriteLine(output);
    
}
Console.WriteLine("Printing count of queueObj "+ queueObj.Count);

Console.WriteLine("Printing which dequeued");
for(int i = 0; i < queueObj.Count; i++)
{ 
Console.WriteLine(queueObj.Dequeue());
}

queueObj.Enqueue("String type"); //wont throw any error here when i try to dequeue then in unboxing it will throw error.

queueObj.Enqueue(new Student());//boxing int to object type
//int result=(int)queueObj.Dequeue(); // will try to unboxing from object to int type by casting here will give error
//Console.WriteLine(result);

//Queue<T> queueobj1 = new Queue<T>(); cant give T type here
Console.WriteLine("GENERIC QUEUE........");
Queue<int> queueobj1 = new Queue<int>();
queueobj1.Enqueue(1);
queueobj1.Enqueue(2);
queueobj1.Enqueue(3);
  queueobj1.Enqueue(4);
queueobj1.Enqueue(5);
//queueobj1.Enqueue("try to put string in int type parameter"); it wont allow us to do so
Console.WriteLine("Dequeue the queue in FIFO structure "+queueobj1.Dequeue());//1
Console.WriteLine("Peek the generic type of queue "+queueobj1.Peek()); // 2
Console.WriteLine("Count the elements "+queueobj1.Count()); //4
foreach(var output in queueobj1) { Console.WriteLine(output); }

Console.WriteLine("List OF NON generic type.......");
List<double> list3 = new List<double>();
List<double> list2 = new List<double>();
IList list = new ArrayList();
list.Add(10);
list.Add(20);
list2.Add(10);
list2.Add(20);
list2.Add(30);
int result = list2.IndexOf(20);
list.Add(result); //trying to add list of int generic types.


foreach (var output in list) {
    Console.WriteLine(output.GetType());
    Console.WriteLine(output); 
} 


list3.AddRange(list2);
list3.Add(40);
list3.Add(50);
list3.Add(60);
list3.Add(70);
list3.Add(80);
list3.Add(90);
list3.Add(100);
list3.Add(110);
foreach (var output in list3) { Console.WriteLine("adding elements in list3 "+output); }
Console.WriteLine("counting elements of list3 "+list3.Count()); // 11


Console.WriteLine("LINKED LIST.........");
//IList linkedList = new LinkedList(); its not implementing the List interface and we dont have non generic type of linked list
LinkedList<char> linkedlist = new LinkedList<char>();
linkedlist.AddFirst('G') ;
linkedlist.AddLast('L');
linkedlist.AddLast('O');
linkedlist.AddLast('B');
linkedlist.AddLast('A');
linkedlist.AddLast('L');




foreach (char output in linkedlist) { Console.WriteLine(output); }


Console.WriteLine("Hashset........");
//ISet iset = new HashSet(); dont have non generic type of hashset

/* HASHSET PROPERTIES:-
 it contains unique elements
Hashset allows null
It doesnt maintains insertion order
inserted elements based on hashing mechanism
 */
HashSet<string> iset = new HashSet<string>();
iset.Add("one");
iset.Add("two");//ignore this sneha because it contains unique elements
iset.Add("three");
iset.Add("four");
iset.Add("five");
iset.Add(null);//Hashset allows null
Console.WriteLine(iset.Contains(iset.First()));
foreach (var item in iset) { Console.WriteLine(item); }



int[] arr = new int[] { 10, 25, 5, 87, 3, 50 };
Array.Sort(arr);
Array.Reverse(arr);
Console.WriteLine(arr[2]);










