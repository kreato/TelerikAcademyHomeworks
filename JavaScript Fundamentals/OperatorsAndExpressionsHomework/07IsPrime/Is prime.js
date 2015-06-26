function isPrime() {
	var input = document.getElementById("input").value,
		notANumber = 'This is not a number',
		prime = true,
		result;

	console.log(input);

	if (isNaN(input)) {
		result = document.getElementById("result").value = notANumber
	}

	else if (input > 1 && input <= 100) {
		for (var i = 2; i <= Math.sqrt(input); i+=1) {
			if (input % i === 0) {
				prime = false;
			}
		}
		result = document.getElementById("result").value = prime;
	}

	else {
		result = document.getElementById("result").value = false;
	}

	console.log(result);
}