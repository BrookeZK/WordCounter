# _Game Center: Word Counter & HangMan_

#### _A website that offers two games, 05.3.2019_

#### By _Brooke Kullberg_

## Description
_This is a website that offers two games for the user to play. The game "WordCounter" gathers user input - a word and a sentence - and then it counts how many times that word appears in the sentence. To do this, the program asks for a word, stores it in its working memory, then asks for a sentence and does the same. Both are turned to lower case, so that the program can process the user input. Then the program checks the sentence for the word, and tells the user how many times it has appeared._

_The game "HangMan" provides the user with a mystery word to guess, letter by letter. The program provides a form for the user to submit a letter. The program takes this information, checks to see if it is part of the word: if it is, then the word blanks that represent the word are replaced with the correct letter; if it is not, then the user's number of allowed guesses increments and another guessing round begins. The user has only 6 guesses to guess the word. If the user guesses the word before that, they win, if not, they lose._

## Specs - WordCounter

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| Program checks if user input is not a word and rejects it | "243" | "This is not a word, please type in a word." |
| Program ignores special characters, looking only at words | "Hello! Hi." | "Hello" "Hi" |
| Program turns words with upper case into lower case | "HeLlO" | "hello" |
| Program takes the word input and checks that it appears in the sentence input one time | "word" & "this is a word" | "word" appears 1 time |
| Program takes the word input and checks that it appears in the sentence more than once | "the" & "the dog and the cat" | "the" appears 2 times |

## Specs - HangMan

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| Program selects a random word and provides the user with blanks representing each letter of the word | "happy" | "_ _ _ _ _" |
| Program checks if user input is not a letter and rejects it | "2" or "happy" | "This is not a letter, please type in a letter." |
| Program turns upper case letters into lower case | "H" | "h" |
| Program takes the letter input and checks if it is in the mystery word, if it is, that letter is displayed | "h" for mystery word "happy"  | "h _ _ _ _" |
| Program increments the # of available guesses if the user guesses wrong | "c" for mystery word "happy" | number of wrong guesses = 1 |
| Program checks for win or loss and displays a message based on which it is | Program finds win or loss | "You win!!" "You lose!!" | 

## Setup/Installation Requirements - Option 1

* _Open the website by typing in the following link into your web browser: <https://BrookeZK.github.io/WordCounter>_.

## Setup/Installation Requirements - Option 2

* _Open via GitHub repository by going to <https://github.com/BrookeZK/WordCounter>._
* _In your command line (Terminal or another program), navigate to your desktop._
* _In your command line, type "git clone https://github.com/BrookeZK/WordCounter" to clone the repository to your desktop._
* _In your command line, navigate into the new folder "WordCounter.Solution", then into the subfolder "WordCounter"._
* _Once inside "WordCounter," type "mcs Program.cs Models/RepeatCounter.cs; mono Program.exe" and your terminal will compile and initiate "Word Counter" right there in your terminal._


## Known Bugs

_In "WordCounter": currently, the user input validation methods that check for and replace punctuation and for invalid input (say, numbers) do not work. There is also no method to make user input lower case._

_In "Hangman": the logic is not yet connected to the website, so you cannot play the game. It will be up and running soon!_

## Support and contact details

_Should any problems occur, or any bugs discovered, please contact Brooke Kullberg at brookekullberg@gmail.com_

## Technologies Used

_This program was written in C#, with CSS and HTML for the UI._

### License

*This software is licensed under MIT license.*

Copyright (c) 2019 **_Brooke Kullberg_**
