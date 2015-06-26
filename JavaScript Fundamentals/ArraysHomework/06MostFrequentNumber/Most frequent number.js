function mostFrequentNum() {
	var arr,
		i,
		j,
		len,
		mostFrequent,
		current,
		result,
		input = document.getElementById("input").value,
		mostFrequentCounter = 0;
		currentCounter = 0;
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
            current = arr[i];
            currentCounter = 0;
            for (j = i; j < len; j += 1) {
                if (arr[j] === current) {
                    currentCounter += 1;
                    if (currentCounter > mostFrequentCounter) {
                        mostFrequentCounter = currentCounter;
                        mostFrequent = current;
                    }
                }
            }
        }
        result = mostFrequent + ' (' + mostFrequentCounter + ' times)'; 
        document.getElementById('result').value = result;
	}
	else {
		document.getElementById('result').value = 'Invalid Input';
	}

}