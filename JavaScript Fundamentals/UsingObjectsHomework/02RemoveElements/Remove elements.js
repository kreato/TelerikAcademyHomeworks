Array.prototype.remove = function () {
    for (var i = 0; i < this.length; i++) {
        if (this[i] === arguments[0]) {
            this.splice(i, 1);
            i--;
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

function removeElements() {
    console.log(arr);
    arr.remove(1);
    document.getElementById("result").value = arr;
    console.log(arr);
}