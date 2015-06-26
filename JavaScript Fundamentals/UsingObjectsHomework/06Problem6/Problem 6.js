function group(people, key) {
    var associativeArray = {};
    for (var i in people) {
        var assoProperty = people[i][key];
        associativeArray[assoProperty] = [];
        for (var k in people) {
            if (assoProperty === people[k][key]) {
                associativeArray[assoProperty].push(people[k]);
            }
        }
    }
    return associativeArray;
}
    var people = [
        { firstName: "Gosho", lastName: "Petrov", age: 32 },
        { firstName: "Bay", lastName: "Ivan", age: 81 },
        { firstName: "Minka", lastName: "Georgieva", age: 20 },
        { firstName: "Inna", lastName: "Cholakova", age: 49 },
        { firstName: "Branimir", lastName: "Manov", age: 19 },
        { firstName: "Boryana", lastName: "Rozeva", age: 31 }];
    
    var groupedByFname = group(people, 'firstname');
    var groupedByAge = group(people, 'age');

function groupeAnArray() {


    for (var i = 0; i < people.length; i++) {
        console.log(people[i].toString());
    }

    for (var group in groupedByFname) {
        if (group !== 'undefined') {
            console.log(group);
            console.log(groupedByFname[group].toString());
        }

    }
    for (var group in groupedByAge) {
        if (group !== 'undefined') {
            console.log(group);
            console.log(groupedByAge[group].toString());
        }
    }
}