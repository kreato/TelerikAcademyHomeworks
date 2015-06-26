/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/
function sum(numbers) {
	var i,
		len,
		result = 0;
	if (typeof(numbers[0]) !== 'undefined') {
		for (i = 0, len = numbers.length; i < len; i+=1) {
			if(isNaN(numbers[i])){
				throw new Error;
			}
			var element = numbers[i];
			result += +element;
		}
	} else {
		result = null;
	}
	
		return result;
}

module.exports = sum;