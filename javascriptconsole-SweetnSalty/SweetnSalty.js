//Print the numbers 1 to 1000 to the console. 
 //arr = new int[20];



//Print the numbers in groups of 20 per line with one space separating each number.  

//HINT: Use string concatenation to print the 20-number strings to the console at a time.  

//When the number is a multiple of three, print “Sweet” instead of the number on the console. 
//If the number is a multiple of five, print “Salty” (instead of the number) to the console. 
//Initialize count variables to be incremented
//How many "Sweet”, 
let Swt = 0;
//how many "Salty”, and 
let Sty = 0;
//how many "Sweet’nSalty".  
let SwtNSty = 0; 
//need a empty string to concat 
let strC = " ";



for (var i = 1; i <= 1000; i++)

    {  
    
        if (i % 3 === 0 && i % 5 === 0)
        {
            strC += " SweetNSalty ";
            SwtNSty++;
            
            
        }
        else if ( i % 3 === 0)
        {
            strC += " Sweet ";
            Swt++;
            
        }
        else if ( i % 5 === 0)
        {
          
            strC += " Salty ";
            Sty++;
        }           
        else
        {
            strC += " "+ i +" " ;
        }
    
        {
            if (i % 20 === 0)
            {
                console.log(strC)
                strC = ' ';
                
            }
            
        }
        
    }
//For numbers which are multiples of three and five, print “Sweet’nSalty” to the console (instead of the number).    
//After the numbers have all been printed, print out: 

//How many "Sweet”, 
console.log('Sweets:'+ Swt);
//how many "Salty”, and 
console.log('Salty:'+  Sty);
//how many "Sweet’nSalty".  
console.log('SweetNSalty:'+ SwtNSty);

//Sweet, Salty, and Sweet’nSalty are three separate groups, so Sweet’nSalty does not increment //Sweet or Salty (and vice versa).   
//Include verbose commentary in the source code to tell me what each few lines are doing. 
//Make sure to merge this branch with your main branch. 
