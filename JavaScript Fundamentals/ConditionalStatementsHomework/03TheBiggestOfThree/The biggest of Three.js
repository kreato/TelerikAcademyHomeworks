function biggestOfThree() {
	var a = parseFloat(document.getElementById("input-a").value),
		b = parseFloat(document.getElementById("input-b").value),
		c = parseFloat(document.getElementById("input-c").value),
		biggest,
		notAnumber = 'One of the inputs is not a number',
		result;

	if (isNaN(a) || isNaN(b) || isNaN(c)) {
		result = document.getElementById("result").value = notAnumber;
	}
	else if (a >= b) {
		if (a >= c) {
			result = document.getElementById("result").value = a;
		}
		else {
			result = document.getElementById("result").value = c;
		}
	}
	else if (b >= c) {
		result = document.getElementById("result").value = b;
	}
	else {
		result = document.getElementById("result").value = c;
	}

	console.log('First number: ' + a);
	console.log('Second number: ' + b);
	console.log('Third number: ' + c);
	console.log('Biggest: ' + result);
}