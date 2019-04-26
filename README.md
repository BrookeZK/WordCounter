# _Word Counter_

#### _A Program that counts how many times a word appears in your sentence, 04.26.2019_

#### By _Brooke Kullberg_

## Description
_This program gathers user input - a word and a sentence - and then it counts how many times that word appears in the sentence. To do this, the program asks for a word, stores it in its working memory, then asks for a sentence and does the same. Both are turned to lower case, so that the program can process the user input. Then the program checks the sentence for the word, and tells the user how many times it has appeared._

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| Program checks if user input is not a word and rejects it | "243" | "This is not a word, please type in a word." |
| Program ignores special characters, looking only at words | "Hello! Hi." | "Hello" "Hi" |
| Program turns words with upper case into lower case | "HeLlO" | "hello" |
| Program takes the word input and checks that it appears in the sentence input one time | "word" & "this is a word" | "word" appears 1 time |
| Program takes the word input and checks that it appears in the sentence more than once | "the" & "the dog and the cat" | "the" appears 2 times |

## Setup/Installation Requirements - Option 1

* _Open the website by typing in the following link into your web browser: <https://BrookeZK.github.io/WordCounter>_.

## Setup/Installation Requirements - Option 2

* _Open via GitHub repository by going to <https://github.com/BrookeZK/WordCounter>._
* _In your command line (Terminal or another program), navigate to your desktop._
* _In your command line, type "git clone https://github.com/BrookeZK/WordCounter" to clone the repository to your desktop._
* _In your command line, navigate into the new folder "WordCounter.Solution", then into the subfolder "WordCounter"._
* _Once inside "WordCounter," type "mcs Program.cs Models/RepeatCounter.cs; mono Program.exe" and your terminal will compile and initiate "Word Counter" right there in your terminal._


## Known Bugs

_Currently the IsInputValid method does not work._

## Support and contact details

_Should any problems occur, or any bugs discovered, please contact Brooke Kullberg at brookekullberg@gmail.com_

## Technologies Used

_This program was written in C#._

### License

*This software is licensed under MIT license.*

Copyright (c) 2019 **_Brooke Kullberg_**
