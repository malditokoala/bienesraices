function addNumbers(num1, num2) {
  return num1 + num2;
}

console.log(addNumbers(2, 2, 2));

function calculateTotal() {
  let total = 0;
  for (let i = 0; i < arguments.length; i++) {
    total += arguments[i];
  }
  return total;
}

let x;
console.log(x); // output: undefined

let y = z + 1; // ReferenceError: z is not defined
