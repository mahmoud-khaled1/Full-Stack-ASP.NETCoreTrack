/*
Generics are templates that allow the same function to accept arguments of 
various different types. Creating reusable components using generics is better 
than using the any data type, as generics preserve the types of the variables 
that go in and out of them.
*/

// The <T> after the function name symbolizes that it's a generic function.
// When we call the function, every instance of T will be replaced with the actual provided type.

// Receives one argument of type T,
// Returns an array of type T.
// function genericFunc0(argument: any):any[] {    
//   var arrayOfT= [];    // Create empty array of type T.
//   arrayOfT.push(argument);   // Push, now arrayOfT = [argument].
//   return arrayOfT;
// }
// // genericFunc("re");

function genericFunc<T>(argument: T): T[] {
  var arrayOfT: T[] = [];    // Create empty array of type T.
  arrayOfT.push(argument);   // Push, now arrayOfT = [argument].
  return arrayOfT;
}

var arrayFromString = genericFunc<string>("beeb")
console.log(arrayFromString[0]);         // "beep"
console.log(typeof arrayFromString[0])   // String

var arrayFromNumber1 = genericFunc<Number>(42);
var arrayFromNumber = genericFunc(42);
console.log(arrayFromNumber[0]);         // 42
console.log(typeof arrayFromNumber[0])   // number

/////////////////////////////
//Generic Interface, Class
interface KeyPair<T, U> {
  key: T;
  value: U;
}

let kv1: KeyPair<number, string> = { key: 1, value: "Steve" }; // OK
let kv2: KeyPair<number, number> = { key: 1, value: 12345 }; // OK
////
interface KeyValueProcessor<T, U> {
  key: T;
  value: U;
  process: (k: T, v: U) => void; //Method
};

class Dict<T, U> implements KeyValueProcessor<T, U>
{
  key: T;
  value: U;

  process(key: T, val: U): void {
    console.log(`Key = ${key}, val = ${val}`);
  }
}

let d1 = new Dict<number, string>();
let d2 = new Dict<number, number>();




