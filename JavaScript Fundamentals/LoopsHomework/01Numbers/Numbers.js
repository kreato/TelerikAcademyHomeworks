function numbers() {
	var num = document.getElementById("input").value;

	document.getElementById("result").value = '';
	
	if (!isNaN(num) && num !== '' && num * 1 >= 1 && ((num * 1) % 1 === 0)) {
		num *= 1;
		var i = 1;

		for (i ; i <= num; i+=1) {
			console.log(i);
			document.getElementById("result").value += i;
			if (i <= num - 1) {
				document.getElementById("result").value += ', ';
			}
		}
	}
	else {
		console.log(document.getElementById("result").value = 'Enter a positive integer');
	}
}