function compare() {
	var string1len,
        string2len,
        i,
        string1 = document.getElementById('input1').value,
        string2 = document.getElementById('input2').value,
        result = '';

        if (string1 == '' || string2 == '') {
        	document.getElementById("result").value = 'Invalid Input';
        }

        else {
        	for (i = 0, string1len = string1.length, string2len = string2.length;  i < Math.min(string1len,string2len); i+=1) {
	        	if (string1[i] < string2[i]) {
	                result = string1 + ' < ' + string2;
	                break;
	            }
	            if (string1[i] > string2[i]) {
	                result = string2 + ' < ' + string1;
	                break;
	            }
        	}
        	if (result === '') {
	            if (string1len < string2len) {
	                result = string1 + ' < ' + string2;
	            } else if (string1len > string2len) {
	                result = string2 + ' < ' + string1;
	            } else {
	                result = string1 + ' = ' + string2;
	            }
        	}

        	document.getElementById('result').value = result;
        	console.log('Problem 2: ' + result);
        }
}