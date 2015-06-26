/*Problem 1. Odd or Even

 Write an expression that checks if given integer is odd or even.*/

var button = document.getElementById('next');
var problemCounter = 0;

var submit = document.getElementById('submit');

var input1 = document.getElementById('input1');
var input2 = document.getElementById('input2');
var input3 = document.getElementById('input3');
var input4 = document.getElementById('input4');
var label = document.getElementById('label');

button.onclick = problemSwitch;

function incorrectInput() {
    jsConsole.writeLine('Incorrect input data!')
}

function solutionText() {
    jsConsole.writeLine('');
    jsConsole.writeLine('------------------------------------------------------------');
    jsConsole.writeLine('');
    jsConsole.writeLine('Solution: ');
    jsConsole.writeLine('');
}

function resetInputFields() {
    input1.style.display = 'none';
    input1.value = '';
    input2.style.display = 'none';
    input2.value = '';
    input3.style.display = 'none';
    input3.value = '';
    label.style.display = 'none';
}

function problemSwitch() {
    resetInputFields();
    problemCounter += 1;
    switch (problemCounter) {
        case 1:
            problem_1();
            break;
        case 2:
            problem_2();
            break;
        case 3:
            problem_3();
            break;
        case 4:
            problem_4();
            break;
        case 5:
            problem_5();
            break;
        case 6:
            problem_6();
            break;
         case 7:
            problem_7();
            break;
        case 8:
            problem_8();
            break;
        case 9:
            problem_9();
            break;
        case 10:
            problem_10();
            break;
        case 11:
            problem_11();
            break;
        case 12:
            problem_12();
            break;
        default :
            problem_1();
            problemCounter = 1;
    }
}

function problem_1() {



    jsConsole.clearConsole();

    input1.style.display = 'inline-block';
    input1.placeholder = 'Enter "text"';

    jsConsole.writeLine('Problem 1. Reverse string');
    solutionText();
    submit.onclick = function () {
        var input=input1.value;

        jsConsole.writeLine("Result: ->  "+reverseString(input));
        function reverseString(input){
            var result=input.split("").reverse().join("");

            return result;
        }
    }
}

function problem_2() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Enter "text"';


    jsConsole.writeLine('Problem 2. Correct brackets');
    solutionText();
    submit.onclick = function () {

        var input=input1.value;

        jsConsole.writeLine('Brackets are correct: '+checkForBrackets(input));
        function checkForBrackets(input)
        {
            var opendBracketCount=0;

            for(var i= 0, l= input.length; i<l; i+=1){
                if(input[i]==='('){
                    opendBracketCount +=1;
                }
                if(input[i]===')'){
                    opendBracketCount -=1;
                }

                if(opendBracketCount<0){
                    return false
                }
            }

            if(opendBracketCount!==0){
                return false;
            } else{
                return true;
            }
        }
    }
}

function problem_3() {

    jsConsole.clearConsole();

    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    input2.style.display = 'inline-block';
    input2.placeholder = 'Substring';


    jsConsole.writeLine('Problem 3. Sub-string in text');
    solutionText();
    submit.onclick = function () {
        var text=input1.value;
        var subString=input2.value;

        jsConsole.writeLine('Substring is repeated: '+subStrRepetition(text,subString)+' times');

        function subStrRepetition(text, subStr){

            var re= new RegExp(subStr, 'gi');
            var input=text.replace(re,'');

            return (text.length-input.length)/subStr.length;
        }
    }
}

function problem_4() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    jsConsole.writeLine('Problem 4. Parse tags');
    solutionText();
    submit.onclick = function () {
        var input=input1.value;
        var bO1='<'+'upcase>';
        var bO2='<'+'lowcase>';
        var bO3='<'+'mixcase>';

        var bC1='<'+'/upcase>';
        var bC2='<'+'/lowcase>';
        var bC3='<'+'/mixcase>';

        jsConsole.writeLine(MainFn(input));


        function exTractTagContetn(tagO,tagE,text,type){
            var endIndex=text.lastIndexOf(tagE);
            var temp=text.substring(0,endIndex);
            var startIndex=temp.lastIndexOf(tagO)+tagO.length;
            //jsConsole.writeLine(temp);
            var result;

            var what=text.substring(startIndex+1,endIndex);
            //jsConsole.writeLine(what);
            switch(type){
                case 1:
                    result= replaceBetween(text,temp.lastIndexOf(tagO),text.lastIndexOf(tagE)+tagE.length, what.toUpperCase() );
                    return result;
                    break;
                case 2:
                    result= replaceBetween(text,temp.lastIndexOf(tagO),text.lastIndexOf(tagE)+tagE.length, what.toLowerCase() );
                    return result;
                    break;
                case 3:
                    result= replaceBetween(text,temp.lastIndexOf(tagO),text.lastIndexOf(tagE)+tagE.length, mixed(what) );
                    return result;
                    break;
            }

            return result;
        }

        function MainFn(text) {
            var condition= text.indexOf(bO1)>=0 || text.indexOf(bO2)>=0 || text.indexOf(bO3)>=0;
            var index=[];
            var first;
            var temp;
            var result=text;


            while(condition){

                index[0]=result.indexOf(bC1);
                index[1]=result.indexOf(bC2);
                index[2]=result.indexOf(bC3);

                first=0;

                for(var i= 1; i<3; i+=1){
                    if((index[i]<index[first] && index[i]!==-1) || index[first]<0 ){
                        first=i;
                    }
                }


                switch (first){
                    case 0:
                        result=exTractTagContetn(bO1,bC1,result,1);
                        break;
                    case 1:
                        result=exTractTagContetn(bO2,bC2,result,2);
                        break;
                    case 2:
                        result=exTractTagContetn(bO3,bC3,result,3);
                        break;
                    default:
                        break;
                }
                //jsConsole.writeLine(result);
                condition= result.indexOf(bC1)>=0 || result.indexOf(bC2)>=0 || result.indexOf(bC3)>=0;
           }
            return result;
        }

       function replaceBetween (texti,start, end, what) {
            //jsConsole.writeLine('Done');
            return texti.substring(-1, start) + what + texti.substring(end);
        }

        function mixed(str){
            var result='',
                id;
            for(var i in str){
                id=Math.random()*2;

                if(id>0.7){
                    result=result+str[i].toUpperCase();
                } else {
                    result=result+str[i].toLowerCase();
                }
            }

            return result;
        }
    }
}


function problem_5() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';


    jsConsole.writeLine('Problem 5. Youngest person');
    solutionText();
    submit.onclick = function () {

        var input=input1.value;

        jsConsole.writeLine(Replacement(input," "));

        jsConsole.writeLine('"&nbsp;" is the equivalent of space in text');

        function Replacement(text, subStr){

            var re= new RegExp(subStr, 'gi');
            var inputa=text.replace(re,'&nbsp;');

            return inputa;
        }


    }
}

function problem_6() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    jsConsole.writeLine('Problem 6. Extract text from HTML');
    solutionText();
    submit.onclick = function () {var input = input1.value,
        toBeReplaced = '<[^>]*>',
        replaceWith = '',
        result;

        result = replaceStrings(input, toBeReplaced, replaceWith);

        input = replaceStrings(input, '<', '&lt;');
        input = replaceStrings(input, '>', '&gt;');

        printResult(input, result, toBeReplaced, replaceWith);

        function replaceStrings(input, toBeReplaced, replaceWith) {
            var pattern = new RegExp(toBeReplaced, 'g');
            return input.replace(pattern, replaceWith);
        }

        function printResult(input, result, toBeReplaced, replaceWith) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Original text -> "' + input + '"');
            jsConsole.writeLine('');
            jsConsole.writeLine('To be replaced -> "' + toBeReplaced + '"');
            jsConsole.writeLine('Replaced with -> "' + replaceWith + '"');
            jsConsole.writeLine('');
            jsConsole.writeLine('Result text  -> "' + result + '"');
            playWhat();
        }
    }
}

function problem_7() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    jsConsole.writeLine('Problem 7. Parse URL');
    solutionText();
    submit.onclick = function () {


        var input = input1.value,
            correctInput;

        jsConsole.writeLine('');
        jsConsole.writeLine(input);

        correctInput = (/^((http[s]?|ftp):\/)+?\/?([^:\/\s]+)((\/\w+)*)*/).test(input);

        if (correctInput) {

            var jsonObj = {
                protocol: '',
                server: '',
                resource: '',
                toString: function () {
                    return 'Protocol: ' + this.protocol + '<br/>' +
                        'Server: ' + this.server + '<br/>' +
                        'Resource: ' + this.resource;
                }
            };

            var matches = input.match(/^((http[s]?|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*)*/);

            jsonObj.protocol = matches[2];
            jsonObj.server = matches[3];
            jsonObj.resource = matches[4];

            jsConsole.writeLine(jsonObj);

            playWhat();
        }
        else {
            incorrectInput();
        }


    }
}

function problem_8() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    jsConsole.writeLine('Problem 8. Replace tags');
    solutionText();
    submit.onclick = function () {

        var input = input1.value,
            result;

        // It's very specific but for the case of homework but it works :D
        result = input.replace(/<\/a>/g, '[/URL]');
        result = result.replace(/<\s*a+?\s*href="/g, '[URL=');
        result = result.replace(/("\s*>)\s*/g, ']');

        // Now some more replaces so the whole texts can be displayed on the web page

        input = input.replace(/</g, '&lt;');
        input = input.replace(/>/g, '&gt;');

        result = result.replace(/</g, '&lt;');
        result = result.replace(/>/g, '&gt;');

        jsConsole.writeLine('Input: ');
        jsConsole.writeLine(input);
        jsConsole.writeLine('');
        jsConsole.writeLine('After replace: ');
        jsConsole.writeLine(result);

    }
}

function problem_9() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Text';

    jsConsole.writeLine('Problem 9. Extract e-mails');
    solutionText();
    submit.onclick = function () {

        var matches,
            input = input1.value;

        matches = input.match(/[a-zA-Z\.0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9A-Z\.!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g);

        jsConsole.writeLine('');
        jsConsole.writeLine('In the text: ');

        if (matches) {
            jsConsole.writeLine(input);
            jsConsole.writeLine('');
            jsConsole.writeLine('E-mails:');
            matches.forEach(function (mail) {
                jsConsole.writeLine(mail)
            })
        } else {
            jsConsole.writeLine('');
            jsConsole.writeLine('No e-mails found!!');
        }


    }
}

function problem_10() {
    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Enter some text';



    solutionText();

    submit.onclick = function () {

        var i,
            len,
            length,
            isPalindrome,
            input = input1.value,
            words = input.split(/[ ,\.\-!\?'"=]/g).filter(function (i) {
                if (i !== '') {
                    return i
                }
            }),
            palindromes = [];

        words.forEach(function (word) {

            isPalindrome = true;

            for (i = 0, length = word.length, len = length / 2; i < len; i += 1) {
                if (word[i] !== word[length - i - 1]) {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome) {
                palindromes.push(word);
            }
        });

        printResult(input, palindromes);

        function printResult(input, palindromes) {
            jsConsole.writeLine('');
            jsConsole.writeLine('');
            jsConsole.writeLine('In text -> ' + input);
            jsConsole.writeLine('');
            if (palindromes.length > 0) {
                jsConsole.writeLine('Palindromes :' + palindromes);
            } else {
                jsConsole.writeLine('No palindromes found!');
            }
            playWhat();
        }
    }
}

function problem_11() {

    jsConsole.clearConsole();


    jsConsole.writeLine('Problem 11. String format');
    jsConsole.writeLine(' - Write a function that formats a string using placeholders.');
    jsConsole.writeLine(' - The function should work with up to 30 placeholders and all types.');

    solutionText();

    submit.onclick = function () {

        var frmt = '{0}, {1}, {0} text {2}',
            itmA = 1,
            itmB = 'Pesho',
            itmC = 'Gosho',
            str = stringFormat(frmt, itmA, itmB, itmC);

        printResult(frmt, itmA, itmB, itmC, str);

        function stringFormat() {
            var i,
                len,
                string,
                index,
                pattern,
                placeholders,
                placesholePosition,
                matches,
                args = Array.prototype.slice.call(arguments);

            if (args.length < 2) {
                throw new Error('What the..');
                return;
            }

            string = args[0];

            matches = string.match(/{[0-9]}/g);

            for (i in matches) {
                placesholePosition = matches[i].replace(/\{/, '');
                placesholePosition = parseInt(placesholePosition);
                pattern = '\\{' + placesholePosition + '\\}';
                pattern = new RegExp(pattern, 'g');
                placesholePosition += 1;
                console.log('args - ' + placesholePosition);
                string = string.replace(pattern, args[placesholePosition]);
            }
            return string;
        }

        function printResult(str, a, b, c, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('String -> ' + str);
            jsConsole.writeLine('Placeholders -> ' + a + ', ' + b + ', ' + c);
            jsConsole.writeLine('Formated string -> ' + result);
            jsConsole.writeLine('');
            jsConsole.writeLine('More at ../strings-scripts.js');
            jsConsole.writeLine('');

        }
    }
}

function problem_12() {
    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'name';
    input2.style.display = 'inline-block';
    input2.placeholder = 'age';


    jsConsole.writeLine('Problem 12. Generate list');
    jsConsole.writeLine(' - Write a function that creates a HTML &lt;ul&gt; using a template for every HTML &lt;li&gt;..');
    jsConsole.writeLine(' - The source of the list should be an array of elements.');
    jsConsole.writeLine(' - Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.');
    solutionText();

    submit.onclick = function () {

        // generate the HTML element
        var tempDiv = document.createElement('div');
        tempDiv.setAttribute('id', 'list-item');
        tempDiv.setAttribute('data-type', 'template');
        tempDiv.style.display = 'none';
        tempDiv.innerHTML = '<strong>-{name}-</strong> <span>-{age}-</span>';

        var name = input1.value,
            age = +input2.value,
            templ = tempDiv.innerHTML,
            people = [
                {name: '1-sat ' + name  , age: age},
                {name: '2-nd ' + name  , age: age},
                {name: '3-rd ' + name  , age: age},
                {name: '4-th ' + name , age: age},
                {name: 'n-th ' + name , age: age}
            ];

        var peopleList = generateList(people, templ);

        function generateList(list, template) {
            var output = '<ul>',
                pattern = new RegExp(),
                currLI = '';

            for (var i = 0, len = list.length; i < len; i += 1) {

                currLI += '<li>' + template + '</li>';
                for (var item in list[i]) {
                    pattern = new RegExp('-\\{' + item + '\\}-', 'g');

                    currLI = currLI.replace(pattern, list[i][item]);
                }
                output += currLI;
                currLI = currLI.replace(/-\{[a-zA-Z]*\}-/g, '');// "DELETE" unused placeholders if such exists
                currLI = '';
            }
            output += '</ul>';
            return output; // return the result as string ready for HTML visualisation
        }

        jsConsole.writeLine('Real UL represented by jsConsole');
        jsConsole.writeLine(peopleList);

        peopleList = peopleList.replace(/</g, '&lt;');
        peopleList = peopleList.replace(/>/g, '&gt;');

        jsConsole.writeLine('Converted to see the tags');
        jsConsole.writeLine(peopleList);
    }
}




