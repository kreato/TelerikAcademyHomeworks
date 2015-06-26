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

        default :
            problem_1();
            problemCounter = 1;
    }
}

function problem_1() {



    jsConsole.clearConsole();

    input1.style.display = 'inline-block';
    input1.placeholder = 'Enter "text"';
    input1.value='name: "John", age: 13';
    input2.style.display = 'inline-block';
    input2.placeholder = 'Enter "text"';
    input2.value='My name is #{name} and I am #{age}-years-old';

    String.prototype.format = function (options) {
        // accept options as object
        var result = this,
            pattern,
            prop;

        for (prop in options) {
            pattern = new RegExp('#\\{' + prop + '\\}');
            result = result.replace(pattern, options[prop]);
        }

        return result;
    };

    submit.onclick = function () {
        var input = input1.value.split(','),
            theString = input2.value,
            formatted,
            options = {
                toString: function () { // for visualisation on the web page
                    var output = '';
                    for (var prop in this) {
                        if (prop != 'toString') {
                            output += prop + ': ' + this[prop] + ', ';
                        }
                    }
                    return output;
                }
            };

        // this is just to parse the input as object!!
        for (var i in input) {
            var props = input[i].split(/: /g);
            options[props[0].trim()] = props[1].replace(/[ '"]/g, '');
        }

        // Applying the format function
        formatted = theString.format(options);

        printResult(theString, options, formatted);


        function printResult(string, options, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Options: ' + options);
            jsConsole.writeLine('');
            jsConsole.writeLine('String: ' + string);
            jsConsole.writeLine('');
            jsConsole.writeLine('Formatted: ' + result);
            jsConsole.writeLine('------------------------------------------------------------------');
            jsConsole.writeLine('');
        }
    }
}

function problem_2() {

    jsConsole.clearConsole();
    input1.style.display = 'inline-block';
    input1.placeholder = 'Enter "text"';
    input1.value="name: 'Elena', link: 'http://telerikacademy.com'";
    input2.style.display = 'inline-block';
    input2.placeholder = 'Enter "text"';
    input2.value = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';


    jsConsole.writeLine('Problem 2. Correct brackets');
    solutionText();
    String.prototype.bind = function (options) {
        // accept options as object
        var result = this,
            matches,
            pattern;

        for (var prop in options) {
            pattern = new RegExp('data-bind-[a-z]*="' + prop.trim() + '"', 'g');
            matches = result.match(pattern);//[0].match(/[a-z]*=/gi);
            for (var item in matches) {
                var attribute,

                    attribute = matches[item].match(/[a-z]*=/gi)[0].trim().toLowerCase();
                console.log(attribute);
                if (attribute == 'content=') {
                    result = result.replace(/></, '>' + options[prop].trim() + '<');
                } else {
                    result = result.replace(/" *>/g, '" ' + attribute + '"' + options[prop] + '">');
                }
            }
        }

        return result;
    };


    submit.onclick = function () {
        var input = input1.value.split(','),
            theString = input2.value,
            formatted,
            options = {
                toString: function () { // for visualisation on the web page
                    var output = '';
                    for (var prop in this) {
                        if (prop != 'toString') {
                            output += prop + ': ' + this[prop] + ', ';
                        }
                    }
                    return output;
                }
            };

        // this is just to parse the input as object!!
        for (var i in input) {
            var props = input[i].split(/: /g);
            console.log('Reversed: ' + props[0] + ' ->' + props[1].replace(/['"]/g, ''));
            options[props[0].trim()] = props[1].replace(/[ '"]/g, '');
        }

        // Applying the format function
        formatted = theString.bind(options);

        // Replaces for correct visualisation on the web browser
        theString = theString.replace(/</g, '&lt;');
        theString = theString.replace(/>/g, '&gt;');
        formatted = formatted.replace(/</g, '&lt;');
        formatted = formatted.replace(/>/g, '&gt;');

        printResult(theString, options, formatted);


        function printResult(string, options, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Options: ' + options);
            jsConsole.writeLine('');
            jsConsole.writeLine('String: ' + string);
            jsConsole.writeLine('');
            jsConsole.writeLine('Bind: ' + result);
            jsConsole.writeLine('------------------------------------------------------------------');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}



