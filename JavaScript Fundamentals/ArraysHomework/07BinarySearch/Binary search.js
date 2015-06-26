function binSearch() {
	var arr,
		lastIndex,
		input = document.getElementById("input").value,
		element = document.getElementById("number").value,
		firstIndex = 0,
		found = 'element not found';

	arr = input.split(', ').map(Number);
	lastIndex = arr.length - 1;
	
	while(firstIndex <= lastIndex) {
		var mid = firstIndex + (lastIndex - firstIndex) / 2;
		mid = Math.floor(mid);

		if (arr[mid] > element) {
			lastIndex = mid - 1;
		} else if (arr[mid] < element) {
			firstIndex = mid + 1;
		} else {
			found = mid;
			break;
		}
	}

	document.getElementById("result").value = found;

	console.log('Index of element ' + element + ' : ' + found);
}