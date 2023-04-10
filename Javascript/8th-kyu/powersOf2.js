// Given that a non-negative integer is passed through as an argument.
// It should return a list of all the powers of 2, with the exponent ranging from 0 to n

const powersOfTwo = (n) => {
    const array = []
    for (let i = 0; i <= n; i++) {
        array.push(2 ** i);
    }
   return array
}

console.log(powersOfTwo(4))
