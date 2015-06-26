function Person(firstname, lastname, age, gender) {
	this.firstname = firstname;
	this.lastname = lastname;
	this.age = age;
	this.gender = !gender ? 'male' : 'female';
}

function groupPeople() {
	var people = [
		new Person('Marko', 'Balabanov', 30, false),
		new Person('Anna', 'Ahmatova', 25, true),
		new Person('Ivan', 'Borimechkata', 26, false),
		new Person('Sofia', 'Avramova', 40, true),
		new Person('Andrey', 'Lyapchev', 50, false),
		new Person('Angel', 'Karaliychev', 17, false),
		new Person('Mara', 'Buneva', 15, true),
		new Person('Nikola', 'Petkov', 10, false)
	];

	var result = people.reduce(function(obj, item) {
    	if (obj[item.firstname[0]]) {
        	obj[item.firstname[0]].push(item);
    	} else {
        	obj[item.firstname[0]] = [item];
    	}
    	return obj;
	}, {});

	console.log(result);
}