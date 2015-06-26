function hasProperty (obj,string) {
	hasProp = false;
	for (var prop in obj) {
		if (prop === string) {
			hasProp = true;
		}
	}
	return string + ': ' + hasProp;
}

function check(){
	var input = document.getElementById("input").value,
		game = {
		title: 'GTAV',
		developer: 'Rockstar North',
		publisher: 'Rockstar Games',
		score: 9,
		adjective: 'Superb',
		price: 34.45,
		currency: '$',
		generes: ['Third-Person', 'Open-World']
	};

	console.log(hasProperty(game, input));
	document.getElementById("result").value = hasProperty(game, input);
}