var firstInput, secondInput;
//firstNumber 
var btn1 = document.getElementById("btn1");
var input = document.getElementById("firstNumber");
btn1.addEventListener("key", function(e) {
    if (e.key === "Enter"){
        e.preventDefault();
        document.getElementById("btn1").click();
    }
})
function revealMessage(){
    document.getElementById("hiddenFirstStep").style.display = 'block';
    //document.getElementById("hiddenFirstStep").addEventListener("keypress", function(event){
   // if (event.keycode === "Enter") 
    //{
      //  event.preventDefault();
        //document.getElementById("bt1").click();
    //} 
    }

function revealMessage2(){
    document.getElementById("hiddenSecondStep").style.display = 'block';
}
function revealMessage3(){
    document.getElementById("calculationButton").style.display = 'block';
    
}

//Step 1: The user enters the number to start with. Then they click the Enter button.  
   
//Step 2: The user enters the number to finish with. Then they click the Enter button. 



//Step 3: Print Sweet, Salty, Sweet'nSalty, and the numbers to the screen as the user instructed.  
//Step 4: Print the total number of Sweet, Salty, and Sweet’nSalty after printing the numbers and words. 
//Step 5: After all the numbers have been printed, present a button allowing the user to delete everything and restart. 
//Instructions
//As always: 
//When the number is a multiple of three, print “Sweet” instead of the number 
//If the number is a multiple of five, print “salty” instead of the number.  
//For numbers which are multiples of three and five, print “Sweet’nSalty” instead of the number. 
//The difference in this project is that you will use JS to manipulate the DOM and print the numbers and words to the web page (NOT the console). 
//This will be a single page application that takes the user through the following steps by displaying and not displaying text and instructions.  
//Each line will be displayed one at a time.  
//“Please enter a starting number” 

//const textNode = document.createTextNode("Welcome to the SweetnSalty!");
//h1.appendChild(textNode);
//“Please enter a final number” 
//“Please press enter to display your results.” 
//You will start with only the template html (an empty <body>) 
//You will add, delete, and alter elements exclusively using JavaScript DOM manipulation as the user moves through the steps.  
//You must display each step separately one at a time, while not displaying the other steps.  
//You must have styling using internal (not inline) styling. 
//This means you will have to plan ahead for class/id names to pair with pre-created (by you) CSS rulesets. 
//Then, you will apply those class/id names to the elements dynamically using DOM manipulation. 
//The start and stop numbers must be validated to be at least 200 apart and no more than 10,000 apart. 
//You also will implement input validation to verify that only positive numbers are entered and that the start number is less than the stop number. 
//There will be 40 numbers on each line, except the last line. 
//The numbers printed to the browser page must be formatted correctly (12,453) 
//Every “Sweet”, “Salty”, and “SweetnSalty” printed must have a green background with white text.  
//You will have small, red text that pops up under the input box to explain what the user did wrong while presenting that step again. 
//After printing the numbers to the screen, you will allow the user to click a ‘Reset’ button to erase everything and do it all again.  
//Make sure to merge this branch with your main branch.  