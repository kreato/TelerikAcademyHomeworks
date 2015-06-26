function insideCircle() {
	var input1 = parseFloat(document.getElementById("input1").value),
		input2 = parseFloat(document.getElementById("input2").value),
		notANumber = 'One of the inputs is not a number',
		inside = (input1 * input1) + (input2 * input2) <= 5 * 5,
		result;

	if (isNaN(input1 || input2)) {
		result = document.getElementById("result").value = notANumber;
	}

	else {
		result = document.getElementById("result").value = inside;
	}

	console.log('X: ' + input1);
	console.log('Y: ' + input2);
	console.log('Inside?: ' + result);
}