function smallestAndLargest() {
    var smallest = 'az',
        largest = '',
        result,
        prop;

    for (prop in document) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result = 'Document: smallest: ' + smallest + '; largest: ' + largest + '\r\n';
    console.log('Document: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'az';
    largest = '';

    for (prop in window) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result += 'Window: smallest: ' + smallest + '; largest: ' + largest + '\r\n';
    console.log('Window: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'az';
    largest = '';

    for (prop in navigator) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result += 'Navigator: smallest: ' + smallest + '; largest: ' + largest;
    console.log('Navigator: smallest: ' + smallest + '; largest: ' + largest);
    document.getElementById('result').value = result;
}