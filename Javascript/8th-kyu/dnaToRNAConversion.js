// create a funcion which returns an RNA sequence from the given DNA sequence.
// Replace every instance of the "T" character with "U"

const DNAtoRNA = (dna) => {
     return dna.replace(/T/g, "U")
}

console.log(DNAtoRNA("ATGDTBBT"))
// Expected output: AUGDUBBU