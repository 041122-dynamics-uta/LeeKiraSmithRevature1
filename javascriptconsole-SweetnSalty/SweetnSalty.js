//Print the numbers 1 to 1000 to the console. 
//console.log ()
//[i] = new Array(1000);
var arr_1 = new Array(1001);
//var length = (arr_1, 20);
let Str = " ";
//let newStr = Str.repeat(5);

// create a function to call to print 2-



//Print the numbers in groups of 20 per line with one space separating each number.  

//HINT: Use string concatenation to print the 20-number strings to the console at a time.  

//When the number is a multiple of three, print “Sweet” instead of the number on the console. 
//If the number is a multiple of five, print “Salty” (instead of the number) to the console. 
//How many "Sweet”, 
let Sweet = 0;
//how many "Salty”, and 
let Salty = 0;
//how many "Sweet’nSalty".  
let SweetNSalty = 0; 

for (arr_1 = 1; arr_1 < 1001; arr_1++)

    {  
        if (arr_1 % 3 == 0 && arr_1 % 5 == 0)
        {
            
            //console.log(('SweetNSalty'));
            //console.log(arr_1.concat(arrayLength));
            
            
        }
        else if ( arr_1 % 3 == 0)
        {
            console.log('Sweet');
            
        }
        else if (arr_1 % 5 == 0)
        {
          
            console.log('Salty');
        }           
        else
        {
            console.log(arr_1);
        }
    }
//For numbers which are multiples of three and five, print “Sweet’nSalty” to the console (instead of the number).    
//After the numbers have all been printed, print out: 
//How many "Sweet”, 
//let Sweet = 0;
//how many "Salty”, and 
//let Salty = 0;
//how many "Sweet’nSalty".  
//let SweetNSalty = 0; 
//Sweet, Salty, and Sweet’nSalty are three separate groups, so Sweet’nSalty does not increment //Sweet or Salty (and vice versa).   
//Include verbose commentary in the source code to tell me what each few lines are doing. 
//Make sure to merge this branch with your main branch. 
