## Exercise 1 - Shopping List
Write a program that reads a shopping list into an array, one line at a time, and then displays the shopping list with the items ranked in ascending order.

To do this, complete the implementation of the ShoppingList program. The program should implement the following algorithm:

Get an integer which specifies the number of input lines that must be processed, prompting with the text
"Please enter the number of items:"
Declare a string array large enough to hold the required number of strings. If you prefer to use a List instead of an array, that is fine.
Use a suitable counter-controlled loop to read the input strings. For each input string:
Get a line of user input, prompting with the text
"Please enter an item:"
Store the current user input in the array (or list) so it can be processed later.
Sort the array/list.
Display two lines, containing the text
"---------------------------"
followed by
"Your shopping list:"
Use a suitable counter-controlled loop to display the contents of the sorted array. The display of each line should be presented as
"Item X -- Y"
where
symbol X is replaced by the position of the text in the sorted array/list, right-aligned to occupy two character positions;
symbol Y is replaced by the text itself
Notes:

A program similar but not necessarily identical to the program you will complete here produces the output shown below.
Beware: The required prompts and output text in your version of the exercise may be different from that shown in this transcript. This is by design: each person may get a unique combination of parameters for their version of the exercise.
Use the settings listed above in your solution!
$ dotnet run
===========================
Please enter the number of items:
-1
---------------------------
Your shopping list:
===========================

$ dotnet run
===========================
Please enter the number of items:
0
---------------------------
Your shopping list:
===========================

$ dotnet run
===========================
Please enter the number of items:
1
Please enter an item:
Watermelon
---------------------------
Your shopping list:
Item  0 -- Watermelon
===========================

$ dotnet run
===========================
Please enter the number of items:
2
Please enter an item:
Pumpkins
Please enter an item:
Corn
---------------------------
Your shopping list:
Item  0 -- Corn
Item  1 -- Pumpkins
===========================

===========================
Please enter the number of items:
14
Please enter an item:
Pumpkins
Please enter an item:
Pickles
Please enter an item:
Sugar
Please enter an item:
Tomatoes
Please enter an item:
Potatoes
Please enter an item:
Bread
Please enter an item:
Cereal
Please enter an item:
Jam
Please enter an item:
Chocolate
Please enter an item:
Watermelon
Please enter an item:
Watercress
Please enter an item:
Jambalaya
Please enter an item:
Corn
Please enter an item:
Lemonade
---------------------------
Your shopping list:
Item  0 -- Bread
Item  1 -- Cereal
Item  2 -- Chocolate
Item  3 -- Corn
Item  4 -- Jam
Item  5 -- Jambalaya
Item  6 -- Lemonade
Item  7 -- Pickles
Item  8 -- Potatoes
Item  9 -- Pumpkins
Item 10 -- Sugar
Item 11 -- Tomatoes
Item 12 -- Watercress
Item 13 -- Watermelon
===========================


Tests will cover combinations of following categories:

Invalid list size
Valid list size
