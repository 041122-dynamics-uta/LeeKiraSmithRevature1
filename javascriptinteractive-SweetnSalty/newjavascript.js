//starting interactive page
        //create an html heading element with DOM
        let intro = document.createElement('h1');
        //add the element to the html body
        document.body.append(intro);
        //add introductions text to the element
        intro.innerText = "Sweet, Salty, SweetNSalty";
        let intro2 = document.createElement('h2');
        document.body.append(intro2);
        intro2.innerText = "Welcome to SweetNSalty! Where numbers are Sweet, Salty, SweetNSalty or none of the above";
        //create an html paragraph element
        let instructions = document.createElement('p');
        //add the element to the html body
        document.body.append(instructions);
        //add instructions text to the element with new lines
        instructions.innerText = "Step 1: Enter your first number. Then click ENTER. \n Step 2: Enter a second number. Then click ENTER. \n Step 3: Click ENTER to get your results! \n \n Rules: Please make sure that both numbers are at least 200 numbers apart and no more than 10,000 numbers apart.";

        //present a start button
        //create a button
        let startButton = document.createElement('button');
        //add element to the html body
        document.body.append(startButton);
        //add text to button
        startButton.innerText = "START";

        //starting number page
        //create html element h3
        let startNumText = document.createElement('h3');
        //create starting number input field
        let inputStartNum = document.createElement('input');
        //create submit button
        let submitStartNum = document.createElement('button');
        //add text to button
        submitStartNum.innerText = "ENTER";
        //initialize a starting number variable and assign 0
        let startNum = 0;

        //ending number page
        //create html element h3
        let endNumText = document.createElement('h3');
        //create ending number input field
        let inputEndNum = document.createElement('input');
        //create submit button
        let submitEndNum = document.createElement('button');
        //add text to button
        submitEndNum.innerText = "ENTER";
        //initialize a final number variable and assign 0
        let endNum = 0;

        //create html element h4 for error
        let error = document.createElement('h4');
        
        //create html element p for sweetsalty output
        let output = document.createElement('p');

        //create elements to print the total number of Sweet, Salty, and Sweet???nSalty
        let sweetFinalCount = document.createElement('p');
        let saltyFinalCount = document.createElement('p');
        let sweetNSaltyFinalCount = document.createElement('p');

        //create delete/restart button
        let submitRestart = document.createElement('button');
        //add text to button
        submitRestart.innerText = "RESTART";

        //add click event listener to start button
        //on start button click event do the following:
        startButton.addEventListener('click', () => {
            //clear page
            document.body.innerHTML = "";
            //add html h3 element to body
            document.body.appendChild(startNumText);
            //add text
            startNumText.innerText = "Enter a starting number";
            //add input field to body
            document.body.appendChild(inputStartNum);
            //add submit button to body
            document.body.appendChild(submitStartNum);          
        });

        //on enter button click event do the following:
        submitStartNum.addEventListener('click', () => {
            //set start number to user input value
            startNum = inputStartNum.value;
            //console.log(startNum); //for debug
            //clear page   
            document.body.innerHTML = "";
            //add html h3 element to body
            document.body.appendChild(endNumText);
            //add text
            endNumText.innerText = "Enter a final number";
            //add input field to body
            document.body.appendChild(inputEndNum);
            //add submit button to body
            document.body.appendChild(submitEndNum);
        });

        //on enter button click event do the following:
        submitEndNum.addEventListener('click', () => {
            //set final number to user input value
            endNum = inputEndNum.value;
            //console.log(endNum); //for debug
            //clear page
            document.body.innerHTML = "";
            //call validate function, if it returns true, then display results via calling sweetand salty interactive function
            if (validate(startNum, endNum)) {
                //console.log(startNum, endNum); //for debug
                sweetAndSalty(startNum, endNum);
            }
            //add reset button to body
            document.body.appendChild(submitRestart);
        })

        //on restart button click:
        submitRestart.addEventListener('click', () => {
            //restart program by refreshing page
            location.reload();
        })

        //input validation
        function validate(startNum, endNum) {
            //no negative numbers
            //if starting num or final num is less than 0 then
            if (startNum < 0 || endNum < 0) {
                //add to and display text on page:
                document.body.appendChild(error);
                //assign errors class to element
                error.className = 'errors';
                //add text
                error.innerText = "Enter a number greater than 0";
                //will not run until valid numbers are inputted
                return false;
                //range must be at least 200 apart
            } else if ((endNum - startNum) < 200) {
                //add to and display text on page:
                document.body.appendChild(error);
                //assign errors class to element
                error.className = 'errors';
                //add text
                error.innerText = "Start and final numbers must be more than 200 numbers apart.";
                //will not run until valid numbers are inputted
                return false;
                //range must be no more than 10,000 apart
            } else if ((endNum - startNum) > 10000) {
                document.body.appendChild(error);
                //assign errors class to element
                error.className = 'errors';
                //add text
                error.innerText = "Start and final numbers must be less than 10000 numbers apart.";
                //will not run until valid numbers are inputted
                return false;
                //starting num should be less than ending num
            } else if (endNum <= startNum) {
                //console.log(`${startNum}, ${endNum}`); //for debug
                //add to and display text on page:
                document.body.appendChild(error);
                //assign errors class to element
                error.className = 'errors';
                //add text
                error.innerText = "Starting number must be less than final number.";
                //will not run until valid numbers are inputted
                return false;
            } else {
                //inputs are valid, allow run
                return true;
            }
        } //end of validate function
        //edit bug: only reading first digit of number

        //run sweet and salty
        function sweetAndSalty(startNum, endNum) {
            //initialize count variables to increment
            let sweetCount = 0;
            let saltyCount = 0;
            let sweetNSaltyCount = 0;
            //initialize empty string to concat to
            let str = "";
            
            //while starting num is less than final num, go through each number and determine:
            while (startNum <= endNum) {
                //40 lines per output //need edit
                for (let i = 0; i < 40; i++) {
                    //if num is multiple of 3 and 5
                    if (startNum % 5 === 0 && startNum % 3 === 0) {
                        //then concat sweetnsalty to str with space and increment sweetnsalty count
                        //use span for styling
                        str += "<span>SweetNSalty </span>";
                        sweetNSaltyCount++;
                    //if num is multiple of 3
                    } else if (startNum % 3 === 0) {
                        //then concat sweet to str with space and increment sweet count
                        //use span for styling
                        str += "<span>Sweet </span>";
                        sweetCount++;
                    //if num is multiple of 5
                    } else if (startNum % 5 === 0) {
                        //then concat salty to str with space and increment salty count
                        //use span for styling
                        str += "<span>Salty </span>";
                        saltyCount++;
                    //if num is not a multiple of 3 or 5
                    } else {
                        //then format the number with a comma and concat the number to str with space
                        str += `${startNum.toLocaleString()} `;
                    }
                    //end loop when start num equals final num
                    if (startNum === endNum) {
                        //break out of loop
                        break;
                    }
                    //increment start num so itll eventually increase to endNum
                    startNum++;
                }
            }
                    //display string result utilizing innerHTML so <span> works
                    output.innerHTML = `${str}`;
                    //add p element to output page
                    document.body.appendChild(output);
                    //display sweet/salt/sweensalty final counts
                    document.body.appendChild(sweetFinalCount);
                    sweetFinalCount.innerText = `Sweet: ${sweetCount}`;
                    document.body.appendChild(saltyFinalCount);
                    saltyFinalCount.innerText = `Salty: ${saltyCount}`;
                    document.body.appendChild(sweetNSaltyFinalCount);
                    sweetNSaltyFinalCount.innerText = `SweetNSalty: ${sweetNSaltyCount}`;
        } //end of sweetAndSalty function