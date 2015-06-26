function biggestOfFive() {
	var a = parseFloat(document.getElementById("input-a").value),
		b = parseFloat(document.getElementById("input-b").value),
		c = parseFloat(document.getElementById("input-c").value),
		d = parseFloat(document.getElementById("input-d").value),
		e = parseFloat(document.getElementById("input-e").value),
		biggest,
		notANumber = 'One of the inputs is not a number',
		result;

	if (isNaN(a) || isNaN(b) || isNaN(c) || isNaN(d) || isNaN(e)) {
		result = document.getElementById("result").value = notANumber;
	}
	else if (a >= b && a >= c && a >= d && a >= e) {
		biggest = a;
		result = document.getElementById("result").value = biggest;
	}
	else if (b >= a && b >= c && b >= d && b >= e) {
        biggest = b;
		result = document.getElementById("result").value = biggest;
    }
    else if (c >= a && c >= b && c >= d && c >= e) {
        biggest = c;
		result = document.getElementById("result").value = biggest;
    }
    else if (d >= a && d >= b && d >= c && d >= e) {
        biggest = d;
		result = document.getElementById("result").value = biggest;
    }
    else if (e >= a && e >= b && e >= c && e >= d) {
        biggest = e;
		result = document.getElementById("result").value = biggest;
    }

    console.log('First number: ' + a);
    console.log('Second number: ' + b);
    console.log('Third number: ' + c);
    console.log('Fourth number: ' + d);
    console.log('Fifth number: ' + e);
    console.log('Biggest: ' + result);
}