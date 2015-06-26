function checkYoungest (arr) {
	var i,
		len,
		index = 0,
    	minAge = arr[0].age;
    for (i = 1, len = arr.length; i < len; i+=1) {
        if (arr[i].age < minAge) {
            minAge = arr[i];
            index = i;
        }
    }

    return arr[index].firstname + ' ' + arr[index].lastname;
}

function youngestPerson() {
	var people = [{
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
}, {
    firstname: 'Bay',
    lastname: 'Ivan',
    age: 81
}, {
    firstname: 'Minka',
    lastname: 'Georgieva',
    age: 20
}];
    console.log("Youngest person:" + checkYoungest(people));
    document.getElementById("result").value = checkYoungest(people);
}