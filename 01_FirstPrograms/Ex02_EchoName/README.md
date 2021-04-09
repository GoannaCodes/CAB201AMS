## Exercise 2 - Echo Name
Extend the "Hello World" program to ask for the user's name, then greet them by name.

Complete a program that:

    -  Displays a prompt asking the user to enter their name, using the text "Hi there, please enter your name: ".
    - Reads a single line of text from the standard input stream.
    - Displays a greeting on a line by itself, using the text "Hello X, glad you could join us in CAB201!", with the symbol 'X' replaced by the text which was entered by the user.

Notes:

- Use the WriteLine method of the Console class to display the prompt.
- Use the ReadLine method of the Console class to read user input.
- Use the WriteLine method of the Console class to display the greeting.
- We recommend that you use the supplied skeleton (see the “Edit source code” tab) as the basis for your solution to ensure that the namespace, class, and method names are correct.
- Keep it simple. Do not attempt to use advanced formatting or embedded control symbols.

Code tests:
- Empty input: this occurs in real life when the user (possibly by accident) commits an empty line. It may onclude an empty line, or one containing only spaces.
- Single token: user enters a single word.
- Minimal length: token contains just one letter or digit.
- Normal length: token contains more than one letters or digits.
- Two tokens: user enters two words, separated by astretch of space.
- Multiple tokens: user enters multiple words, separated by stretches of space which may vary in length.
- Padding: the input contains leading or trailing spaces, or possibly both.