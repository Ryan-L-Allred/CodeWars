/*
    When a string of letters is passed through the funciton, it should
    return a string that shows each character incrementally duplicated based of 
    of the index of the character, with a dash between the characters. The first 
    instance of the character should be captitalized.
*/
//For example, if argument is "abcd", then it should return "A-Bb-Ccc-Dddd"

const accum = (s) => {
  const result = []
  const lowerStr = s.toLowerCase()

  for(let i = 0; i < lowerStr.length; i++) {
    let str = lowerStr[i].toUpperCase()
    for(let j = 0; j < i; j++) {
      str += lowerStr[i]
    }
    result.push(str)
  }

  return result.join("-")
}

console.log(accum("abcd"))