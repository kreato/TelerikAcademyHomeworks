function calculateDistance(point1, point2) {
	var distance = Math.sqrt(
		Math.abs(point2.x - point1.x) * Math.abs(point2.x - point1.x) + 
		Math.abs(point2.y - point1.y) * Math.abs(point2.y - point1.y));

	return distance.toFixed(2);
}

function planarCoordinates() {
var x1 = document.getElementById("x1").value,
	y1 = document.getElementById("y1").value,
	x2 = document.getElementById("x2").value,
	y2 = document.getElementById("y2").value,
	x3 = document.getElementById("x3").value,
	y3 = document.getElementById("y3").value;
x1 *= 1;
x2 *= 1;
x3 *= 1;
y1 *= 1;
y2 *= 1;
y3 *= 1;
var	point1 = {x: x1 , y: y1},
	point2 = {x: x2 , y: y2},
	point3 = {x: x3 , y: y3},
	lines = [calculateDistance(point1, point2), 
				calculateDistance(point2, point3), 
				calculateDistance(point1, point3)];

	document.getElementById("result").value = 'Distance: '+ calculateDistance(point1, point2)
	+ '\r\n' + lines
	+ '\r\nCan form a triangle?:' + ((lines[0]*1 + lines[1]*1) > lines[2]*1);
}