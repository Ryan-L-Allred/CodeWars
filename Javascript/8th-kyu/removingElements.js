

var originalArray = ["cat", "dog", "cat", "rat", "human", "lizard"]


const removeEveryOther = (arr) => {

    for (var i = 1; i < arr.length; i++) {
        arr.splice(i, 1)
    }
    return arr
}

// output: ["cat", "cat", "human"]
console.log(removeEveryOther(originalArray))