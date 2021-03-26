# Data Strucutures and Algorithms in C#

## Description

These are my Data Structures and Algorithms implementations in C# to better prepare myself for the grueling interview process. I will be gradually adding and making improvements to my entries here. My plan is to add explanations, implementations, and which data strucutures and algorithms one might use to solve common interview problems.

***

## Data Strucutures

### Arrays

An array is a collection of items stored at contiguous memory locations. The idea is to store multiple items of the same type together.

An array of integers in C# looks like this:
` int[] arr = {1, 2, 3, 4, 5}; `

Each item in an array has an index. The first index of the array is always 0 and the last index of the array is always the arrays length - 1.


#### Common Operations

Access: *O(1)*

Accessing is as simple as passing in the index of an array to square brackets. 
Consider our array from above. If you wanted to access the first item, or
the item at the zeroeth index it would look something like this.

` arr[0] == 1 `

As long as you know the index for the array item you want 
you will be able to access it in constant time.

Search: *O(n)*

Searching for an item in an array involves having to, worst case scenario, look through the entire array. This is if we use something like linear search of course. Really makes you wonder why it's called *linear*..

that might look something like this:

```csharp

class MainClass {
	static void Main(string[] args)
	{
		MainClass mc = new MainClass();
		int[] arr = {1,2,3,4,5};
		mc.Search(arr);
	}
	
	public int Search(int[] arr, int num)
	{
		int length = arr.Length;
		int i;
		
		for (i < 0; i < length; i++)
		{
			if (arr[i] == num)
			{
				return i;
			}
		}
		return -1;
	}
}


```

The code above returns -1 if the int is not in the array, otherwise it returns the index where the int was found.

Of course if we were dealing with a sorted array we would be able to find our integer much more efficiently using Binary Search.

Insertion: *O(n)*

Deletion: *O(n)*


***

### Strings

***

### Hash Tables

***

### Linked List

***

### Stack

***

### Queue

***

### Trees

***

### Heaps

***

### Tries

***

### Graphs

***

### Sorting Algorithms


***