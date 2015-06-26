function areaOfTrapezoid() {
	var input1 = parseFloat(document.getElementById("input1").value),
		input2 = parseFloat(document.getElementById("input2").value),
		input3 = parseFloat(document.getElementById("input3").value),
		notANumber = 'One of the inputs is not a number',
		checkIfPositive = 'One of the inputs is not a positive number',
		result;

	if (isNaN(input1 || input2 || input3)) {
		result = document.getElementById("result").value = notANumber;
	}
	
	else if (input1 <=0 || input2 <=0 || input3 <=0) {
		result = document.getElementById("result").value = checkIfPositive;
	}

	else {
		result = document.getElementById("result").value = (input1 + input2) * input3 / 2;
	}

	console.log('a: ' + input1);
	console.log('b: ' + input2);
	console.log('h: ' + input3);
	console.log('area: ' + result);
}