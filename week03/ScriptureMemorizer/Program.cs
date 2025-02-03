// Your program must do the following:

// 1.Store a scripture, including both the reference 
// (for example "John 3:16") and the text of the scripture.

// 2.Accommodate scriptures with multiple verses, such as 
// "Proverbs 3:5-6".

// 3.Clear the console screen and display the complete scripture, 
// including the reference and the text.

// 4.Prompt the user to press the enter key or type quit.

// 5.If the user types quit, the program should end.

// 6.If the user presses the enter key (without typing quit), 
// the program should hide a few random words in the scripture, 
// clear the console screen, and display the scripture again. 
// (Hiding a word means that the word should be replace by 
// underscores (_) and the number of underscores should match 
// the number of letters in that word.)

// 7.The program should continue prompting the user and hiding 
// more words until all words in the scripture are hidden.

// 8.When all words in the scripture are hidden, the program should
// end. (The final display of the scripture should show the scripture
// with all words hidden.) 

// 9.When selecting the random words to hide, for the core requirements,
// you can select any word at random, even if the word was already 
// hidden. (As a stretch challenge, try to randomly select from only 
// those words that are not already hidden.)

using System;

class Program
{
    static void Main(string[] args)
    {
        // Store scripture
        Reference referenceShort = new Reference("D&C", 10, 5);
        Scripture scriptureShort = new Scripture(referenceShort, "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.");

        // Accomodate scriptures with multiple verses
        Reference referenceLong = new Reference("Matthew", 11, 28, 30);
        Scripture scriptureLong = new Scripture(referenceLong, "Come unto me, all ye that labour and are heacy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");

        
        // Create while loop to Clear screen and start program
        
        while(true){

            // Clear the console screen and display the complete scripture
            Console.Clear();
            Console.Write($"{referenceShort.GetDisplayText()} ");
            Console.WriteLine(scriptureShort.GetDisplayText());

            // Prompt the user to press the enter key or type to quit.
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userChoice = Console.ReadLine().ToLower();
                
            

            // Add while loop to continue to display scripture until all words are hidden
            if(userChoice == "quit"){
                break;
            }
            else if(userChoice == ""){

                scriptureShort.HideRandomWords(3);
                
                if (scriptureShort.CompletelyHidden()){
                    Console.WriteLine("Congratulations! You have successfully memmorized your scriptures!");
                    break;  
                }
                
                
            }
        } 
         
    }
}