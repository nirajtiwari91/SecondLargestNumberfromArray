This C# console application, named "2ndLargestNumberfromArray," provides three different methods to find the second-largest number in an array.

Sorting and Indexing:

The SecondLargestNumberfromArray1 method initializes an array (myArray) and sorts it in descending order using Array.Sort and Array.Reverse.
The second-largest number is then obtained by accessing the element at index 1.
The result is displayed.
Loop and Comparison:

The SecondLargestNumberfromArray2 method sorts the array (myArray) and iterates through it starting from the second-to-last element.
It compares each element with the largest element and identifies the first element that is not equal to the largest.
The result is printed.
Iterative Comparison:

The SecondLargestNumberfromArray3 method iterates through the array (myArray) and keeps track of the largest and second-largest numbers.
If an element is greater than the current largest, it becomes the new largest, and the previous largest becomes the second-largest.
The second-largest number is printed as the result.
All three methods offer different approaches to solving the problem of finding the second-largest number in an array, showcasing variations in sorting, indexing, and iterative comparison techniques.
