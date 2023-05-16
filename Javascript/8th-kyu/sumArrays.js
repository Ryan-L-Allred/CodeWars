const sum = (numbers) => {
    return numbers.reduce((accumulator, currentValue) => accumulator + currentValue, 0)
}

const array = [5, 5, 5, 5, 5]
console.log(sum(array))