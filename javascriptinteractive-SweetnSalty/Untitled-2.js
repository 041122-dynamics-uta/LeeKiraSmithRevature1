document.getElementById("firstnum").addEventListener("keypress", function(e){ //this eventlistener and function lets user press enter as an alternative to clicking submit
    if (e.key === "Enter")
    {
        e.preventDefault();
        document.getElementById("btn1").click();
    }
})
document.getElementById("secondnum").addEventListener("keypress", function(e){ //this eventlistener and function lets user press enter as an alternative to clicking submit
    if (e.key === "Enter")
    {
        e.preventDefault();
        document.getElementById("btn2").click();
    }
})

var firstInput = document.getElementById("firstNumber");
firstInput.addEventListener("keyup", function (event) {
    if (firstInput.validity.typeMismatch) {
        firstInput.setCustomValidity("Numbers cannot be negative!");
    } else {
        firstInput.setCustomValidity("");
    }
});
}