function digitAsWord() {
	var digit = parseFloat(document.getElementById("input").value),
		notAdigit = 'not a digit',
		result;

	switch (digit) {
		case 0: result = document.getElementById("result").value = 'zero'; break;
		case 1: result = document.getElementById("result").value = 'one'; break;
		case 2: result = document.getElementById("result").value = 'two'; break;
		case 3: result = document.getElementById("result").value = 'three'; break;
		case 4: result = document.getElementById("result").value = 'four'; break;
		case 5: result = document.getElementById("result").value = 'five'; break;
		case 6: result = document.getElementById("result").value = 'six'; break;
		case 7: result = document.getElementById("result").value = 'seven'; break;
		case 8: result = document.getElementById("result").value = 'eight'; break;
		case 9: result = document.getElementById("result").value = 'nine'; break;
		default: result = document.getElementById("result").value = notAdigit; break;
	}

	console.log('Digit: ' + digit);
	console.log('Digit as word: ' + result);
}