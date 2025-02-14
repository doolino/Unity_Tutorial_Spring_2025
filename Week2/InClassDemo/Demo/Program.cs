
//////////////////// Arrays /////////////////////////

// Declaration

// Initialization

// Declaration and Initialization Together

// Alternative Short Syntax

// Accessing and Modifying Elements

// Get the size of an array

// Sort scores

// Copy the first 2 elements of scores to a new array

// Copy scores starting at index 1 in destinationArray

// Find the first even score 

// Find all scores greater than 10

// Find the index of the first occurrence of the score 15.

// Find the index of the first occurrence of the score greater than 5

// Check whether score of 20 exists

// Clear the last two scores



//////////////////// Lists /////////////////////////

// Declare and initialize a list

// Accessing elements

// Get the list capacity

// Get the length (count) of elements in the list

// Add values to the list

// Add a multiple values to the list at once

// Check whether the list contains an element

// Insert 110 before the last element

// Insert -20, 10, and 0 at the start of the list

// Remove the first occurrence of the value -20 from the list

// Remove the value at index 0 from the list

// Remove all elements greater than 50

// Sort the list

// Convert the list into an array of the same type

// Copy the list values into an array of double size, starting from index 5

// Check whether at least an odd value exists

// Find the first even score 

// Find all values greater than 10

// Find the index of the first occurrence of the value 15.

// Find the index of the first occurrence of the value greater than 5

// Remove all elements from the list, making it empty


//////////////////// Dictionaries /////////////////////////

// Declare and Initialize a dictionary
Dictionary<string, float> myDictionary = new Dictionary<string, float>()
{
    { "Alice", 3.5f },
    { "Brian", 3.2f }

};
// Add elements
myDictionary.Add("Aditya", 5.0f);
myDictionary.Add("Michael", 4.9f);
// Accessing a key and Modifying its value
myDictionary["Alice"] = 3.99f;
// Show the total number of students
Console.WriteLine(myDictionary.Count);
// Retrieve all keys
foreach(var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
// Retrieve all values
foreach(var values in myDictionary.Keys)
{
    Console.WriteLine(values);
}
// Retrieve all key-value pairs
foreach (KeyValuePair<string, float> kvp in myDictionary)
{
    Console.WriteLine($"Key: {kvp.Key} | Value: {kvp.Value}");
}
// Check whether a key exists. If so, show its value
if (myDictionary.ContainsKey("Alice"))
{
    Console.WriteLine(myDictionary["Alice"]);
}
// Remove a key
//myDictionary.Remove(key, "Alice");
//Console.WriteLine(myDictionary.Count);
// Remove all keys and values
myDictionary.Clear();


//////////////////// HashSets /////////////////////////

// Declare and Initialize a HashSet
HashSet<int> mySet = new HashSet<int>() { 1, 2, 3 };
// Add elements
mySet.Add(3);
mySet.Add(4); // {1,2,3,4}
// Remove an element
mySet.Remove(3);
// Check if an element exists
mySet.Contains(3); //False
// Iterate through hashset
foreach (var Item in mySet)
{
    Console.WriteLine(Item);
}
// Copy all elements into an array
int[] newArray = new int[mySet.Count];
mySet.CopyTo(newArray, 0);
// Remove all elements in the HashSet
mySet.Clear();
// Combine two sets 
HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4 };
HashSet<int> setB = new HashSet<int>() { 3, 4, 5 };
setA.UnionWith(setB);
Console.WriteLine(string.Join(',', setA));

// Intersect two sets
setA = new HashSet<int>() { 1, 2, 3, 4 };
setA.IntersectWith(setB);
Console.WriteLine(string.Join('.', setA));

// Difference between two sets
setA = new HashSet<int>() { 1, 2, 3 };
setA.ExceptWith(setB);
Console.WriteLine(string.Join(',', setA));

// Symmetric Difference between two sets (elements that are only in one)

setA = new HashSet<int>() { 1, 2, 3 };
setA.ExceptWith(setB);
Console.WriteLine(string.Join(',',setA));
//////////////////// LinkedList /////////////////////////

// Declare and Initialize a LinkedList
LinkedList<int> myLinkedList = new LinkedList<int>(collection: [1, 2, 3, 4, 5]);

// Count the number of items in the list
Console.WriteLine(myLinkedList.Count); //4
// Add 0 at the beginning of the list
myLinkedList.AddFirst(0); //[0,1,3,4,5]

// Add 8 and 10 at the end of the list
myLinkedList.AddLast(8);
myLinkedList.AddLast(10); //[0,1,3,4,5,8,10]
// Find the first node equal to 3
LinkedListNode<int> node = myLinkedList.Find(3);
Console.WriteLine(node.Value);
Console.WriteLine(myLinkedList.Find(3).Value);
// Put a 2 in the list right before the 3
LinkedListNode<int> newNode = new LinkedListNode<int>(2);
myLinkedList.AddBefore(myLinkedList.Find(3), 2);
// Add another 2 to the list right after the 1
LinkedListNode<int> newerNode = new LinkedListNode<int>(2);
myLinkedList.AddAfter(myLinkedList.Find(1), 2);
// Check whether 5 is in the list
myLinkedList.Contains(5); //true
// Remove the first and last values in the list
myLinkedList.RemoveLast();
myLinkedList.RemoveFirst();
// Return the first(Head) and last(Tail) node of the list
LinkedListNode<int> head = myLinkedList.First;
LinkedListNode<int> tail = myLinkedList.Last;
Console.WriteLine(head.Value);
Console.WriteLine(tail.Value);
// Return the value of the node right after the head node
int value = head.Next.Value;
// Remove the first occurrence of 2
node = myLinkedList.Find(2);
myLinkedList.Remove(node);
// Copy the entire list to an array
int[] newArray2 = new int[myLinkedList.Count];
myLinkedList.CopyTo(newArray2, 0);

// Remove all values in the list
myLinkedList.Clear();

//////////////////// Stack /////////////////////////

// Declare and Initialize a stack

// Get the number of elements in the stack

// check if 5 exists in the stack

// Return the top element in the stack

// Remove and return the top element in the stack

// Add 5 to the stack

// Convert the current stack into an array 

// Copy elements of current stack into a new array

// Remove all elements from the stack

//////////////////// Queue /////////////////////////

// Declare and initialize a queue

// Get the number of elements in the queue

// check if 5 exists in the queue

// Return the element at the front of the queue

// Remove and return the element at the front of the queue

// Add 5 to the queue

// Convert the current queue into an array 

// Copy elements of current queue into a new array

// Remove all elements from the queue



//////////////////// Functions /////////////////////////

// Write a function that takes two integers and return their sum.
// Then, call the function


// Write a void function that prints messages on console


// Write a function that greet users with an optional parameter
