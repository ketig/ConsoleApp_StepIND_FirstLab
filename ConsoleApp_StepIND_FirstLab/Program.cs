using ConsoleApp_StepIND_FirstLab.Models;
using System.Collections;

Dictionary<string, double> books = new Dictionary<string, double>();
books.Add("Samanishvilis Dedinacvali", 25.00);
books.Add("Dedaena", 15.20);
books.Add("Didostatis Marjvena", 30.00);
foreach (var book in books)
{
    Console.WriteLine($"{book.Key} : {book.Value}");
}

Console.WriteLine("===============");

Dictionary<string, int> scores = new Dictionary<string, int>();
scores["Alice"] = 90;
scores["Bob"] = 85;
Console.WriteLine(scores["Alice"]); // 90

Console.WriteLine(scores["Alice"]);

foreach (var item in scores)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

#region Collections
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Hello");
arrayList.Add(new Rectangle());
int a = arrayList.Count;
List<int> list = new List<int>();

Stack stack = new Stack();
stack.Push(1);
stack.Push("Hello");
stack.Push(new Rectangle());
object obj = stack.Peek();
obj = stack.Pop();

Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue("Hello");
queue.Enqueue(new Rectangle());
obj = queue.Peek();
obj = queue.Dequeue();

Hashtable hashtable = new Hashtable();
hashtable.Add("key1", 1);
hashtable.Add("key2", 1);
hashtable.Add("key3", 1);

Dictionary<char, double> keyValuePairs = new Dictionary<char, double>();
keyValuePairs.Add('a', 1.0);
keyValuePairs.Add('b', 2.0);
keyValuePairs.Add('c', 3.0);
#endregion

#region Generics
int x = 5;
int y = 10;
Swap(ref x, ref y);

string str = "";
string str2 = "Hello";
Swap(ref str, ref str2);

Rectangle rectangle = new Rectangle(3, 4);

Box<Rectangle> box = new Box<Rectangle>();
box.Value = rectangle;

//Box<int> box1 = new Box<int>(); // This line will cause a compile-time error because int is not a class type.

static void Swap<T>(ref T a, ref T b) /*where T : class*/
{
    (a, b) = (b, a);
}

public class Box<T> where T : class
{
    public T Value { get; set; }
}
#endregion