//Given a list of integers, determine wheter the sum of its elements is odd or even.
//Use reduce() method to add the elements together.
//Use conditional to determine whether there is a remainder after divding by two.
const oddOrEven = (array) => {
    const sum = array.reduce((accumulator, currentValue) => accumulator + currentValue)
    return sum % 2 == 0 ? "even" : "odd"
}

const numbers = [2, 4, 7, 8]

console.log(oddOrEven(numbers))//expected output: even

