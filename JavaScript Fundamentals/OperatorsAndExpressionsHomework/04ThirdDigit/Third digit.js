function isThirdDigit7() {
	var input = document.getElementById("input").value,
	    result = document.getElementById("result").value = input[input.length - 3] === '7';
	    console.log('input: ' + input);
	    console.log('Third digit 7?: ' + result);
}