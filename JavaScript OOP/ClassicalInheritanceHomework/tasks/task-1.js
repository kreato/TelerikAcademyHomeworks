/* Task Description */
/*
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {

		function validateString(strings){
			if (strings.length < 3 || strings.length > 20 || !/^[a-zA-Z]+$/.test(strings)){
				throw new Error();
			}
		}

		function validateAge(age){
			if((age * 1) < 0 || (age * 1) > 150 || isNaN(age * 1)){
				throw new Error();
			}
		}

		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function(){
				return this._firstname;
			},
			set: function(name){
				validateString(name);
				this._firstname = name;
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function(){
				return this._lastname;
			},
			set: function(name){
				validateString(name);
				this._lastname = name;
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function(){
				return this._firstname + ' ' + this._lastname;
			},
			set: function(value){
				var fname = value.split(' ');
				this.firstname = fname[0];
				this.lastname = fname[1];
				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function(){
				return this._age;
			},
			set: function(value){
				validateAge(value);
				this._age = value;
				return this;
			}
		});

		Person.prototype.introduce = function(){
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		};

		return Person;
	} ());
	return Person;
}
module.exports = solve;
