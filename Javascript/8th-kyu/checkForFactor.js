//Function tests if base is divisible by factor.
//Returns true if it is a factor and returns false if it is not.
const checkForFactor = (base, factor) => {
    return base % factor == 0 ? true : false
}
console.log(checkForFactor(10, 2))//expected output: true
console.log(checkForFactor(9, 2))//expected output: false