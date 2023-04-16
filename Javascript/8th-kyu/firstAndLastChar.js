//Function must remove the first and last characters of a string
//Isolate the first and last index of the string
//Use methods to remove them.
const removeChar = (str) => {
    return str.slice(1, -1)
}
console.log(removeChar("Ryan"));