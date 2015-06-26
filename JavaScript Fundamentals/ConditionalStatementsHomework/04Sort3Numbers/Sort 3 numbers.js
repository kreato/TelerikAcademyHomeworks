function sortNumbers() {
	var a = parseFloat(document.getElementById("input-a").value),
		b = parseFloat(document.getElementById("input-b").value),
		c = parseFloat(document.getElementById("input-c").value),
		notaANumber = 'One of the inputs is not a number',
		result;

	if (isNaN(a) || isNaN(b) || isNaN(c)) {
		result = document.getElementById("result").value = notaANumber;
	}
	else if (a > b && a > c) {
		if (b > c) {
			result = document.getElementById("result").value = a + ' ' + b + ' ' + c;
		}
		else {
			result = document.getElementById("result").value = a + ' ' + c + ' ' + b;
		}
	}
	else if (b > a && b > c) {
		if (c > a) {
			result = document.getElementById("result").value = b + ' ' + c + ' ' + a;
		}
		else {
			result = document.getElementById("result").value = b + ' ' + a + ' ' + c;
		}
	}
	else if (c > a && c > b) {
		if (b > a) {
			result = document.getElementById("result").value = c + ' ' + b + ' ' + a;
		}
		else {
			result = document.getElementById("result").value = c + ' ' + a + ' ' + b;
		}
	}
	else if (a === b || a === c || b === c) {
		result = document.getElementById("result").value = a + ' ' + b + ' ' + c;
	}

	console.log('First number: ' + a);
	console.log('Second number: ' + b);
	console.log('Third number: ' + c);
	console.log('Sorted: ' + result);
}