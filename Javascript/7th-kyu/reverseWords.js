//The function should reverse each word in a string.
//The sentence is still in order but each words is reversed.
//Use split() to divide string into an array.
//Loop through array and reverse each word.
const reverseWords = (str) => {
    const result = []
    let splitStr = str.split(" ")

    for (let i = 0; i < splitStr.length; i++){
        const splitWord = splitStr[i].split("")
        const reverseWord = splitWord.reverse()
        const rejoinedStr = reverseWord.join("")
        result.push(rejoinedStr)
    }
    return result.join(" ")
}

console.log(reverseWords("Ryan is queefy"))