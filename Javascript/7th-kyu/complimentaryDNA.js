const compDNA = {
    "A" : "T",
    "T" : "A",
    "G" : "C",
    "C" : "G"
}

const DNAstrand = (dna) => {
   return dna.replace(/A|T|G|C/g, char => compDNA[char])
}

console.log(DNAstrand("GCTA"))
