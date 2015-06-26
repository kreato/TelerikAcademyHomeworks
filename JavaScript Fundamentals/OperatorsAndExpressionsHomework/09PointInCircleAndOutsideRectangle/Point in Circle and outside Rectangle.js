function inCircleOutRect() {
	var x = parseFloat(document.getElementById("input1").value),
		y = parseFloat(document.getElementById("input2").value),
		notANumber = 'One of the inputs is not a number',
		insideK = ((x * x) - (2 * x * 1) + (1 * 1)) + ((y * y) - (2 * y * 1) + (1 * 1)) <= 3 * 3,
		outsideR = (x >= -1 && x <= 5) && (y >= -1 && y <= 1),
		result;

	if (isNaN(x || y)) {
		result = document.getElementById("result").value = notANumber;
	}

	if (insideK == true && outsideR == false) {
		result = document.getElementById("result").value = 'yes';
	}

	else {
		result = document.getElementById("result").value = 'no';
	}

	console.log('X: ' + x);
	console.log('Y: ' + y);
	console.log('Inside?: ' + result);
}