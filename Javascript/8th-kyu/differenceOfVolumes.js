//findDifference function takes in two arrays.
//Each array has 3 positive integers.
//Multipy the integers or find the cubic dimensions in each array.
//Find the difference between the two arrays after multiplying them.
const findDifference = (a, b) => {
    const multiplyA = a.reduce((a, b) => a * b)
    const multiplyB = b.reduce((a, b) => a * b)
    return multiplyA > multiplyB ? multiplyA - multiplyB : multiplyB - multiplyA
}

const array1 = [2, 1, 6]
const array2 = [5, 1, 5]

console.log(array1)//expected output: 60
console.log(array2)//expected output: 125
console.log(findDifference(array2, array1))//expected output: 65