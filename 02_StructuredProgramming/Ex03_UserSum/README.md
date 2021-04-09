## Exercise 3 - User Sum

Complete the implementation of the SOLUTION program. The program should use a while loop to repeatedly ask the use to enter an integer. The program should break out of the loop if the user enters a sentinel value, 999; otherwise, the value entered should be added to a running total which will be displayed after the loop terminates.

Notes:

As part of the supplied skeleton code, a variable called runningTotal of type int, has been declared and initialised to zero.
Your task is to complete the implementation by writing a while statement to compute the running total as set out in the instructions above. To do this, write a suitable loop (probably a while loop):
Prompts the user to enter a value, using the pre-defined constant.
Reads an integer.
Tests to see if the value entered is equal to the sentinel.
Breaks out of the loop if the value matches the sentinel.
Otherwise, adds the value to the running total.
After the loop terminates, skeleton code will emit the results to the standard output stream.
All input and output is carried out by the supplied skeleton code.
Do not attempt to rewrite the supplied code.
In this exercise, all supplied input text will consist of suitable numeric strings.

Tests will cover the following categories:

Empty list: the sentinel value is entered immediately.
Single value: one unpredictable integer value is entered, followed by the sentinel value.
Multiple values: multiple unpredictable integer values are entered, followed by the sentinel value.