//isSquare function checks if an argument is a perfect square.
//Square root needs to be a whole number.
//If its a perfect square, it will return true, else it will return false
const isSquare = (n) => {
   if (Number.isInteger(Math.sqrt(n))) {
    return true
   } else {
    return false
   }
}

console.log(isSquare(9))