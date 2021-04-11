## Exercise 2 - Median Temperature

Write a program that uses a sentinel-controlled loop to read a sequence of floating point values into a list, then calculates and displays the median value.

To do this, complete the implementation of the MedianTemperature program. The program should implement the following algorithm:

Declare and initialise a list of double-precision floating point values.
Get the user to enter a sequence of values, prompting for each value with the text
"Please enter a temperature reading (999 to finish):"
If the list is empty, display error text
"Median is not defined for an empty list."
Otherwise:
Sort the list.
Calculate the median:
Let x be the list, and let n be the number of elements in the list.
If n is odd, median = x[n/2].
If n is even, median = (x[n/2] + x[n/2-1])/2.
Display the median, using text
"The median temperature is M degrees."
where
symbol M is replaced by the median value, with precision of two decimal places.
Notes:

For an explanation of the ideas involved, please refer to https://en.wikipedia.org/wiki/Median. Keep in mind that list elements are indexed from 0 in C#, where the treatment in Wikipedia assumes that sequences are indexed starting at 1.
A program similar but not necessarily identical to the program you will complete here produces the output shown below.
Beware: The required prompts and output text in your version of the exercise may be different from that shown in this transcript. This is by design: each person may get a unique combination of parameters for their version of the exercise.
Use the settings listed above in your solution!
$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
999
Median is not defined for an empty list.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
4.5148
Please enter a temperature reading (999 to finish):
999
The median temperature is 4.51 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
24.8421
Please enter a temperature reading (999 to finish):
25.0171
Please enter a temperature reading (999 to finish):
999
The median temperature is 24.93 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
9.2943
Please enter a temperature reading (999 to finish):
-4.8083
Please enter a temperature reading (999 to finish):
-2.3799
Please enter a temperature reading (999 to finish):
999
The median temperature is -2.38 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
18.0429
Please enter a temperature reading (999 to finish):
7.2208
Please enter a temperature reading (999 to finish):
13.4378
Please enter a temperature reading (999 to finish):
20.1221
Please enter a temperature reading (999 to finish):
999
The median temperature is 15.74 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
17.9085
Please enter a temperature reading (999 to finish):
3.5737
Please enter a temperature reading (999 to finish):
11.3044
Please enter a temperature reading (999 to finish):
4.5694
Please enter a temperature reading (999 to finish):
2.9381
Please enter a temperature reading (999 to finish):
999
The median temperature is 4.57 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
24.7425
Please enter a temperature reading (999 to finish):
29.5924
Please enter a temperature reading (999 to finish):
5.3403
Please enter a temperature reading (999 to finish):
28.3062
Please enter a temperature reading (999 to finish):
-1.9738
Please enter a temperature reading (999 to finish):
26.3373
Please enter a temperature reading (999 to finish):
999
The median temperature is 25.54 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
-4.5051
Please enter a temperature reading (999 to finish):
24.0999
Please enter a temperature reading (999 to finish):
15.9956
Please enter a temperature reading (999 to finish):
6.6885
Please enter a temperature reading (999 to finish):
20.2999
Please enter a temperature reading (999 to finish):
20.8259
Please enter a temperature reading (999 to finish):
-1.7041
Please enter a temperature reading (999 to finish):
999
The median temperature is 16.00 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
-8.3334
Please enter a temperature reading (999 to finish):
17.0484
Please enter a temperature reading (999 to finish):
22.4546
Please enter a temperature reading (999 to finish):
24.4190
Please enter a temperature reading (999 to finish):
1.2475
Please enter a temperature reading (999 to finish):
28.5759
Please enter a temperature reading (999 to finish):
26.9588
Please enter a temperature reading (999 to finish):
26.0859
Please enter a temperature reading (999 to finish):
999
The median temperature is 23.44 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
26.2134
Please enter a temperature reading (999 to finish):
-3.2357
Please enter a temperature reading (999 to finish):
2.3084
Please enter a temperature reading (999 to finish):
22.5109
Please enter a temperature reading (999 to finish):
18.7663
Please enter a temperature reading (999 to finish):
0.8391
Please enter a temperature reading (999 to finish):
18.3136
Please enter a temperature reading (999 to finish):
12.3099
Please enter a temperature reading (999 to finish):
23.9033
Please enter a temperature reading (999 to finish):
999
The median temperature is 18.31 degrees.
===========================

$ dotnet run
===========================
Please enter a temperature reading (999 to finish):
28.2535
Please enter a temperature reading (999 to finish):
0.2728
Please enter a temperature reading (999 to finish):
24.6058
Please enter a temperature reading (999 to finish):
9.5217
Please enter a temperature reading (999 to finish):
26.2709
Please enter a temperature reading (999 to finish):
2.0953
Please enter a temperature reading (999 to finish):
-7.3665
Please enter a temperature reading (999 to finish):
28.5082
Please enter a temperature reading (999 to finish):
13.6413
Please enter a temperature reading (999 to finish):
14.3539
Please enter a temperature reading (999 to finish):
999
The median temperature is 14.00 degrees.
===========================



Tests will cover the following categories:

Empty list
List with single element
List with odd number of elements
List with even number of elements