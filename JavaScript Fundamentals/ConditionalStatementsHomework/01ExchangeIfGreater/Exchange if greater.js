function exchIfGreater() {
	var a = document.getElementById("input-a").value,
		b = document.getElementById("input-b").value,
		c,
		result;

	console.log('First number: ' + a);
	console.log('Second number: ' + b);

	if (a > b) {
		c = a;
		a = b;
		b = c;
	}

	result = document.getElementById("result").value = a + ' ' + b;
	console.log('Result: ' + result);
}