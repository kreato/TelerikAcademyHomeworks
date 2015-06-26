function minAndMax() {
	var sequence = document.getElementById("input").value,
		i,
		len,
		arr;

	if (sequence === '') {
		document.getElementById('result').value = 'Invalid input';
	}

	arr = sequence.split(' ').map(Number);

	for (i = 0, len = arr.length; i < len; i+=1) {
		if (isNaN(arr[i])) {
			document.getElementById('result').value = 'Invalid input';
			break;
		}
	}

	max = min = arr[0];

	for (j = 0; j < arr.length; j+=1) {
		if (arr[j] > max) {
			max = arr[j];
		}

		if (arr[j] < min) {
			min = arr[j];
		}

		document.getElementById('result').value = 'Max: ' + max + '; Min: ' + min;
		console.log('Result: Max: ' + max + '; Min: ' + min);
	}
}