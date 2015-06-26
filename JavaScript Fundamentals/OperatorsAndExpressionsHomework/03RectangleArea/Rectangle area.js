function areaOfRectangle() {
	var input1 = parseFloat(document.getElementById("input1").value),
		input2 = parseFloat(document.getElementById("input2").value),
		notANumber = 'One of the inputs is not a number',
		checkIfPositive = 'One of the inputs is not a positive number',
		result;

	if (isNaN(input1 || input2)) {
		result = document.getElementById("result").value = notANumber;
	}
	
	else if (input1 <=0 || input2 <=0) {
		result = document.getElementById("result").value = checkIfPositive;
	}

	else {
		result = document.getElementById("result").value = input1 * input2;
	}

	console.log('width: ' + input1);
	console.log('height: ' + input2);
	console.log('area: ' + result);
}

// Console test. Try this with node.js or your browser's console:

function rectangleArea(width, height) {
	var area = width * height;
	return 'width: ' + width + ' height: ' + height + ' Rectangle\'s area is: ' + area;
}

console.log(rectangleArea(3, 4));
console.log(rectangleArea(2.5, 3));
console.log(rectangleArea(5, 5));