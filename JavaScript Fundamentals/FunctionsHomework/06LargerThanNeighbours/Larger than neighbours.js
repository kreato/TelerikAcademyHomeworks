function checkIfLarger() {
	var arr,
		len,
		input = document.getElementById("arr").value,
		position = document.getElementById("position").value;

	arr = input.split(', ').map(Number);
	len = arr.length - 1;
	position *= 1;
	if (position <= 0 || position >= len) {
		document.getElementById("result").value = 'Invalid Position';
	} else {
		if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1]) {
			document.getElementById("result").value = true;
		} else {
			document.getElementById("result").value = false;
		}
	}
}