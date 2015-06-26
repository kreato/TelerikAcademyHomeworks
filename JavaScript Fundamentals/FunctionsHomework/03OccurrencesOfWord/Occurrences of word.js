function occurrencesofWord() {
	var text = document.getElementById("text").value,
		check = document.getElementById("check").checked,
		word = document.getElementById("word").value;

	if (word !== '') {
		if (check) {
            searchWord(text, word, true);
        } else {
            searchWord(text, word);
        }
	} else {
        document.getElementById("result").value = 'Enter a word';
    }
}

function searchWord(text, word, caseSensitive) {
    var search,
        clearText,
        newText;

    if (!caseSensitive) {
        search = new RegExp('(\\b' + word + '\\b)', 'gim');
    } else {
        search = new RegExp('(\\b' + word + '\\b)', 'gm');
    }
    clearText = text.replace(/(->|\/<-)/gim, '');
    newText = clearText.replace(search, '->$1<-');
    document.getElementById("text").value = newText;

    if (clearText === newText) {
        document.getElementById("result").value = word + ' :not found';
    }
}