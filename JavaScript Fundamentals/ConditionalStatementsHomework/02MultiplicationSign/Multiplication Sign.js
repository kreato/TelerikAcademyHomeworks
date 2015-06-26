function multiplicationSign() {
	var a = parseFloat(document.getElementById("input-a").value),
		b = parseFloat(document.getElementById("input-b").value),
		c = parseFloat(document.getElementById("input-c").value),
		notAnumber = 'One of the inputs is not a number',
		result;

	if (isNaN(a) || isNaN(b) || isNaN(c)) {
		result = document.getElementById("result").value = notAnumber;
	}
	else if (a === 0 || b === 0 || c === 0) {
		result = document.getElementById("result").value = 0;
	}
	else if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0)) {
		result = document.getElementById("result").value = '+';
	}
	else if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0)) {
		result = document.getElementById("result").value = '-';
	}
	else if (a < 0 && b < 0 && c < 0) {
		result = document.getElementById("result").value = '-';
	}
	else if (a > 0 && b > 0 && c > 0) {
		result = document.getElementById("result").value = '+';
	}

	console.log('First number: ' + a);
	console.log('Second number: ' + b);
	console.log('Third number: ' + c);
	console.log('Sign: ' + result);
}