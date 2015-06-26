function dec2Bin(dec){
    return (dec >>> 0).toString(2);
}

function thirdBit() {
	var input = document.getElementById("input").value,
		notANumber = 'This is not a number',
		positionOfBit = 3,
		mask = 1 << positionOfBit,
		inputAndMask = input & mask,
		bit = inputAndMask >> positionOfBit,
		result;

	if (isNaN(input)) {
		result = document.getElementById("result").value = notANumber;
		document.getElementById("bitRepresentation").value = notANumber;
	}

	else {
		result = document.getElementById("result").value = bit;
		document.getElementById("bitRepresentation").value = dec2Bin(input);
	}

	console.log('Number: ' + input);
	console.log('Third bit: ' + result);
}