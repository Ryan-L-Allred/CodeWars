//Function returns the speed of cockroach
//It takes in speed in km per hour and return it in cm per second
/* 
Multiply kilometers by 100000 to find amount in centimeters per hour
and divide that answer by 3600.
*/
//Round answer down to nearest integer.
const cockroachSpeed = (s) => {
    const speed = (s * 100000) / 3600
    return Math.floor(speed)
}

console.log(cockroachSpeed(2))//expected output: 55