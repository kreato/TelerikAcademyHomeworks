function reverseNumber() {
	var i,
		reversed = '',
		input = document.getElementById("input").value;

	if(input !== '' && !isNaN(input)) {

		for (i = input.length - 1; i >= 0; i-=1) {
			reversed += input[i];
		}

		document.getElementById("result").value = reversed;
	} else {
		document.getElementById("result").value = 'Invalid Input';
	}
}