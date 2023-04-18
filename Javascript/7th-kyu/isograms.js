//Checks if word is an isogram(word with no repeating letters)
//If word is an isogram, will return true. Else it will return false
//Ignore letter casing
const isIsogram = (str) => {
    
    for(i = 0; i <= str.length; i++)
    {
        let lower = str.toLowerCase()
        if (lower.indexOf(lower[i]) !== lower.lastIndexOf(lower[i])) {
            return false
        } 
    }
    return true
}
console.log(isIsogram("ryan"))//expected output: true
console.log(isIsogram("Ryan"))//expected output: true
console.log(isIsogram("rryan"))//expected output: false
console.log(isIsogram("Rryan"))//expected output: false
console.log(isIsogram("RRyan"))//expected output: false