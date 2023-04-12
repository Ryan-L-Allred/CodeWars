//Given an array of numbers, return the additive inverse of each number.

const invert = (array) => {
    return array.map(num => num * -1)
}

const numbers = [4, -6, 89, -100]
console.log(invert(numbers)) //expected output: [-4, 6, -89, 100]

// function invert(array) {
//     var newArr = [];
//     for(var i = 0; i < array.length; i++){
//       newArr.push(-array[i]);
//     }
//      return newArr;
//   }
