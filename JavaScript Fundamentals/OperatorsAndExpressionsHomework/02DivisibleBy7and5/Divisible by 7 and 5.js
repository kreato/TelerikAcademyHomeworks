function divisibleBy7And5() {
	var input = document.getElementById("input").value,
		notAnumber = 'This is not a number';

	console.log(input);

	if (isNaN(input)) {
		console.log(document.getElementById("result").value = notAnumber);
	}
	else {
		console.log(document.getElementById("result").value = input % 5 === 0 && input % 7 === 0);
	}
}

// Console test. Try this with node.js or your browser's console:

function divBy7and5(number) {
	if (number % 5 === 0 && number % 7 === 0) {
		return 'true';
	}
	else {
		return 'false'
	}
}

for (var i = 0; i <= 140; i++) {
	console.log(i + ' is divisible by 7 and 5: ' + divBy7and5(i));
}