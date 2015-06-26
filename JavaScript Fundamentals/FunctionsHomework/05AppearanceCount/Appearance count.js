function appearanceCount() {
	var arr,
		i,
		len,
		input = document.getElementById("arr").value,
		num = document.getElementById("number").value,
		result = 0;

	arr = input.split(', ').map(Number);

	if (!isNaN(num) && num !== '' && input !== '') {
		num *= 1;
		for (i = 0, len = arr.length; i < len; i+=1) {
			if (arr[i] === num) {
				result ++;
			}
		}

		if (result === 1) {
			document.getElementById("result").value = result + ' time';
		} else {
			document.getElementById("result").value = result + ' times';
		}
	} else {
		document.getElementById("result").value = 'Invalid Inputs';
	}
}