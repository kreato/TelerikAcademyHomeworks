(function makeCopy() {

	function deepCopy(copy){
        return JSON.parse(JSON.stringify(copy));
    }

	var game = 'GTAV',
		gameCopy = deepCopy(game),
		gameSpotReview = {score: 9, adjective: 'Superb'},
		gameSpotReviewCopy = deepCopy(gameSpotReview);
		generes = ['Third-Person', 'Shooter', 'Open-World', 'First-Person', 
					'Adventure', 'Action', '3D'],
		generesCopy = deepCopy(generes);

	gameCopy = 'GTAIV';
	gameSpotReviewCopy.score = 10;
	gameSpotReviewCopy.adjective = 'Essential';
	generesCopy = [];
	generesCopy[0] = 'Action';
	generesCopy[1] = 'Adventure';

	console.log(game);
    console.log(gameSpotReview);
    console.log(generes);
    console.log(gameCopy);
    console.log(gameSpotReviewCopy);
    console.log(generesCopy);
}());
