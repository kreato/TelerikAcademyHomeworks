function digitAsWord() {
	var input = document.getElementById("input").value;

	switch(input[input.length - 1]) {
		case '0': document.getElementById("result").value = 'zero'; break;
		case '1': document.getElementById("result").value = 'one'; break;
		case '2': document.getElementById("result").value = 'two'; break;
		case '3': document.getElementById("result").value = 'three'; break;
		case '4': document.getElementById("result").value = 'four'; break;
		case '5': document.getElementById("result").value = 'five'; break;
		case '6': document.getElementById("result").value = 'six'; break;
		case '7': document.getElementById("result").value = 'seven'; break;
		case '8': document.getElementById("result").value = 'eight'; break;
		case '9': document.getElementById("result").value = 'nine'; break;
		default: document.getElementById("result").value = 'Not a valid input'; break;
	}
}