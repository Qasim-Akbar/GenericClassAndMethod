using GenericClassAndMethod;
using GenericClassAndMethod.Models;

//GenericStack<int> stack = new GenericStack<int>();
//stack.Push(31);
//stack.Push(67);

//int poppedInt = stack.Pop();

//Console.WriteLine($"poppedInt={poppedInt}");

//GenericStack<string> nameStack = new GenericStack<string>();
//nameStack.Push("Ali");
//nameStack.Push("Zinta");

//string poppedName = nameStack.Pop();

//Console.WriteLine($"\n\npoppedName={poppedName}");

// Example usage with integers

GenericStack<int> intStack = new GenericStack<int>();

intStack.Push(10);

intStack.Push(20);

intStack.Display();

Console.WriteLine($"Popped item: {intStack.Pop()}");

intStack.Display();

// Example usage with strings

GenericStack<string> stringStack = new GenericStack<string>();

stringStack.Push("Hello");

stringStack.Push("World");

stringStack.Display();

Console.WriteLine($"Popped item: {stringStack.Pop()}");

stringStack.Display();

// Example usage with custom objects

GenericStack<Person> personStack = new GenericStack<Person>();

personStack.Push(new Person("John", 25));

personStack.Push(new Person("Alice", 30));

personStack.Display();

Console.WriteLine($"Popped item: {personStack.Pop()}");

personStack.Display();