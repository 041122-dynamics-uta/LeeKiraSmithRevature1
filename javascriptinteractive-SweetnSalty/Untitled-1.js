//Start with a screen that explains the game and how the user will input their choices. 
    //Don't use innerHTML because someone purposely trying to break this code could throw game by entering a harmful input.
const h1Greeting = document.createElement("h1");
h1Greeting.textContent = "Sweet N Salty";
document.body.append(h1Greeting);  

const pExplain = document.createElement("p");
pExplain.textContent = "Briefly explain how the users will input choices/rules";
document.body.append(pExplain);
//Each step is visible only after the previous step has been successfully completed. 
    //I believe an on click function will help with this task. 
//Present a start button.  
const terms = document.createElement("button");
terms.setAttribute('id','Start');
var body = document.querySelector('body');
body.appendChild(terms)
document.getElementsByTagName("button")[0].textContent="Start";


//}
//Step 1: The user enters the number to start with. Then they click the Enter button.  
    //user input. 
   // const userFirstNumber = document.createElement("input");
    //userFirstNumber.textContent = "Enter the number you would like to start with. Then click enter.";
    //document.body.append(userFirstNumber);

//buttonStart.textContent = "Start";
//document.body.append(buttonStart);

//document.getElementById("Start").addEventListener("click", function(){
  //  document.getElementsById("hiddenFirstStep").textContent ="Enter the number you would like to start with. Then click enter.";
//});

const terms2 = document.createElement("p");
terms2.setAttribute('id','hiddenFirstStep');
var body = document.querySelector('body');
body.appendChild(terms2)
document.getElementsByTagName("p")[0].textContent="Enter the first number";

const terms3 = document.createElement("input");
terms3.setAttribute('id','userInput1');
var body = document.querySelector('body');
body.appendChild(terms3)
document.getElementsByTagName("input")[0].textContent="First number";

function revealMessage(){
    document.getElementById("hiddenFirstStep").style.display = 'block';
}
function revealMessage2(){
    document.getElementById("hiddenSecondStep").style.display = 'block';
}

//var x = document.getElementById("Start");
//x.addEventListener("click", myFunction,);

//function myFunction() {
  //  const t2 = document.getElementById("Start");
    //if (t2.firstChild.nodeValue =='clicked'){
        
    //} else {
      //  t2.firstChild.nodeValue = 'clicked';
    //}
//}


//div to move button to next line for now.
const divEmpty = document.createElement("div");
divEmpty.textContent = "";
document.body.append(divEmpty);

       
//}
//Step 1: The user enters the number to start with. Then they click the Enter button.  
    //user input. 
    //const userFirstNumber = document.createElement("input");
    //userFirstNumber.textContent = "Enter the number you would like to start with. Then click enter.";
    //document.body.append(userFirstNumber);

const userFirstNumber = document.createElement("input");
userFirstNumber.textContent = "First Number";
document.body.append(userFirstNumber);
//Step 2: The user enters the number to finish with. Then they click the Enter button. 
//Another div to move button to next line for now.
const divEmpty2 = document.createElement("div");
divEmpty2.textContent = "";
document.body.append(divEmpty2);

const buttonEnter = document.createElement("button");
buttonEnter.textContent = "Enter";
document.body.append(buttonEnter);


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