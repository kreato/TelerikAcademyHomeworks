function increaseMembers() {
	var i,
		arr = [];

	for (i = 0; i < 20; i+=1) {
		arr[i] = i * 5;
	}

	document.getElementById("result").value = arr.join(', ');
	console.log('Result: ' + arr.join(', '))
}