const areYouPlayingBanjo = (name) => {
    // name.startsWith("R") || name.startsWith("r") ? console.log(`${name} plays banjo`) 
    // : console.log(`${name} does not play banjo`)
    
    // if (name[0].toLowerCase() === "r") 

    if (name.startsWith("R") || name.startsWith("r")) {
        return `${name} plays banjo`
    } else {
        return `${name} does not play banjo`
    }
}
        

console.log(areYouPlayingBanjo("Ron"))