function selectionSort() {
	var arr,
		i,
		j,
		len,
		temp,
		min,
		result,
		input = document.getElementById("input").value,
		validInput = true;

	if (input === '') {
		validInput = false;
	}
	else {
		arr = input.split(', ').map(Number);

		for (i = 0, len = arr.length; i < len; i += 1) {
            if (isNaN(arr[i])) {
                validInput = false;
                break;
            }
        }
	}

	if (validInput) {
		for (i = 0, len = arr.length; i < len; i += 1) {
            for (j = i + 1; j < len; j += 1) {
                if (arr[i] > arr[j]) {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        result = arr.join(', ');
        document.getElementById('result').value = result;
	}
	else {
		document.getElementById('result').value = 'Invalid Input';
	}

}