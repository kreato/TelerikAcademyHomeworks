function searchIndex() {
	var arr,
		i,
		len,
		input = document.getElementById("arr").value,
		result = -1;

	arr = input.split(', ').map(Number);

	for (i = 1, len = arr.length - 1; i < len; i+=1) {
		if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
			result = i;
			break;
		}
	}

	document.getElementById("result").value = result;
}