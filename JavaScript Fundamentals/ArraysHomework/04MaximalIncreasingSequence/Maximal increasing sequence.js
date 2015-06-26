function maxIncrSequence() {
	var arr,
		i,
		len,
		maxSequence,
		input = document.getElementById("input").value,
		max = 1;
		currentMax = 1;
		end = 0;
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
		for (i = 1, len = arr.length; i < len; i += 1) {
            if (arr[i] > arr[i - 1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    end = i;
                }
            } 
            else {
                currentMax = 1;
            }
        }
        maxSequence = arr.splice(end - max + 1, max).join(', ');
        document.getElementById('result').value = maxSequence;
	}
	else {
		document.getElementById('result').value = 'Invalid Input';
	}

}