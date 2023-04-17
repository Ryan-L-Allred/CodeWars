//A string should be passed through as an argument.
//The first character of the string is always a number.
//The input may be "1 year old" or "5 years old"
//The getAge function should return the number at the beginning of the string.
const getAge = (inputString) => {
    return parseInt(inputString)

}
console.log(getAge("9 years old"))//expected output: 9