function numAsWord() {
    var num = document.getElementById('input').value,
        result;

    if (!isNaN(num) && num !== '' && num * 1 >= 0 && num * 1 <= 999 && ((num * 1) % 1 === 0)) {
        num *= 1;
        var ones = (num % 10),
            tens = (Math.floor(num / 10)) % 10,
            teens = 10 + ones,
        	hundreds = Math.floor(num / 100);

        switch (teens) {
            case 11: teens = "eleven"; break;
            case 12: teens = "twelve"; break;
            case 13: teens = "thirteen"; break;
            case 14: teens = "fourteen"; break;
            case 15: teens = "fifteen"; break;
            case 16: teens = "sixteen"; break;
            case 17: teens = "seventeen"; break;
            case 18: teens = "eighteen"; break;
            case 19: teens = "nineteen"; break;
        }

        switch (hundreds) {
            case 0: hundreds = ""; break;
            case 1: hundreds = "one hundred "; break;
            case 2: hundreds = "two hundred "; break;
            case 3: hundreds = "three hundred "; break;
            case 4: hundreds = "four hundred "; break;
            case 5: hundreds = "five hundred "; break;
            case 6: hundreds = "six hundred "; break;
            case 7: hundreds = "seven hundred "; break;
            case 8: hundreds = "eight hundred ";  break;
            case 9: hundreds = "nine hundred "; break;
        }

        if (num % 100 !== 0 && num >= 100) {
            hundreds = hundreds + 'and ';
        }

        if (tens == 1 && ones > 0) {
            result = hundreds + teens;
            result = result.charAt(0).toUpperCase() + result.substring(1);
            hundreds = tens = ones = "";
            document.getElementById('result').value = result;
            console.log('Number: ' + num);
            console.log('Result: ' + result);
            return;
        }

        switch (tens) {
            case 0: tens = ""; break;
            case 1: tens = "ten"; break;
            case 2: tens = "twenty "; break;
            case 3: tens = "thirty "; break;
            case 4: tens = "fourty "; break;
            case 5: tens = "fifty "; break;
            case 6: tens = "sixty "; break;
            case 7: tens = "seventy "; break;
            case 8: tens = "eighty "; break;
            case 9: tens = "ninety "; break;
        }

        switch (ones) {
            case 1: ones = "one"; break;
            case 2: ones = "two"; break;
            case 3: ones = "three"; break;
            case 4: ones = "four"; break;
            case 5: ones = "five"; break;
            case 6: ones = "six"; break;
            case 7: ones = "seven"; break;
            case 8: ones = "eight"; break;
            case 9:  ones = "nine"; break;
            default: ones = ""; break;
        }

        if (num === 0) {
            result = "Zero";
            hundreds = tens = digits = "";
            document.getElementById('result').value = result;
            console.log('Number: ' + num);
            console.log('Result: ' + result);
            return;
        }

        result = hundreds + tens + ones;
        result = result.charAt(0).toUpperCase() + result.substring(1);
        document.getElementById('result').value = result;
        console.log('Number: ' + num);
        console.log('Result: ' + result);
        return;
    } 
    else {
        document.getElementById('result').value = 'Numbers between 0 and 999 only';
    }
}