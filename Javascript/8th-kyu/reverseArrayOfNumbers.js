const digitize = (n) => {
    const stringInt = n.toString()
    const splitInt = stringInt.split("")
    const reverseNumbers = splitInt.reverse()
    return reverseNumbers.map(str => parseInt(str))
}


console.log(digitize(12345))