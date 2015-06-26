function numOfElements() {
	var count = document.getElementsByTagName("div").length;
    document.getElementById("result").value = count + ' div elements.';
}