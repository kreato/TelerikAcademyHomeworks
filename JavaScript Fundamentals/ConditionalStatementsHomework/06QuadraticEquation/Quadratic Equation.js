function quadraticEquation() {
	var a = parseFloat(document.getElementById("input-a").value),
		b = parseFloat(document.getElementById("input-b").value),
		c = parseFloat(document.getElementById("input-c").value),
		formula = Math.sqrt(b * b - 4 * a * c),
		x1 = -b - formula,
		x2 = -b + formula,
		result = 'x1=' + (x1 /= 2 * a) + '; x2=' + (x2 /= 2 * a);

	document.getElementById("result").value = result;
}