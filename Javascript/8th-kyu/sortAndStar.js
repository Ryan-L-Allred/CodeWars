//Given a list of strings, they must be sorted alphabetically, then return the first value.
//The returned string must have "***" between each letter.
//
const twoSorts = (s) => {
    const sorted = s.sort()
    const firstIndex = sorted[0]
    const splitStr = firstIndex.split("")
    return splitStr.join("***")
}

const list = ["ryan", "dildo", "vulva", "zebra"]

console.log(twoSorts(list))//expected output: d***i***l***d***o