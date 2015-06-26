function isOdd() {
	var input = document.getElementById("input").value,
        notANumber = 'This is not a number';

    console.log(input);

    if (isNaN(input)) {
    	console.log(document.getElementById("result").value = notANumber);
    }

    else{
    	console.log(document.getElementById("result").value = (input & 1) !== 0);
    }  
}

// Console test. Try this with node.js or your browser's console:
function oddOrEven(number) {
	if (number % 2 === 0) {
		return 'The number is even.';
	}
	else {
		return 'The number is odd.'
	}
}

for (var i = -20; i <= 20; i++) {
	console.log(i + ': ' + oddOrEven(i));
}