//Function takes an array of numbers as an argument
//Must return an array of both the lowest and the highest number
//Isolate both numbers using Math.max() and Math.min()
const minMax = (arr) => {
    const max = Math.max(...arr)
    const min = Math.min(...arr)
    return [min, max]
}

const arrayOfNums = [1, 2, 3, 4, 5, 6]

console.log(minMax(arrayOfNums))//expected output: [1, 6]