## Exercise 6 - Locate Symbol
Complete a program that:

Displays a prompt asking the user to enter a line of text, using the phrase "Please enter one line of text:".
Reads a single line of text from the standard input stream.
Uses methods from the string class to get the first and last positions of symbol '*' in the input text.
Displays the text "The first occurrence of symbol '*' is at Y; the last occurrence is at Z.".
Replace symbol 'Y' in the output message with the location of the first occurrence of '*'.
Replace symbol 'Z' in the output message with the location of the last occurrence of '*'.

Tests will cover combinations of the following categories:

Empty input: this occurs in real life when the user (possibly by accident) commits an empty line. It may onclude an empty line, or one containing only spaces.
Single occurrence of symbol.
Two occurrences of symbol.
Three or more occurrences of symbol.
Symbol appears at either or both ends of input.
Symbol is properly embedded into the input.