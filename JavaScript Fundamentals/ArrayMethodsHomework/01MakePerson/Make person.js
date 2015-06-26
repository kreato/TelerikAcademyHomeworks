function Person(fname, lname, age, gender) {
	this.fname = fname;
	this.lname = lname;
	this.age = age;
	this.gender = !gender ? 'male' : 'female';
}

function makePerson() {
	var people = [
		new Person('Marko', 'Balabanov', 30, false),
		new Person('Anna', 'Ahmatova', 25, true),
		new Person('Ivan', 'Borimechkata', 26, false),
		new Person('Sofia', 'Avramova', 40, true),
		new Person('Andrey', 'Lyapchev', 50, false)
		];

	console.log(people);

	people.forEach(function (item) {
    console.log(JSON.stringify(item));
	});
}