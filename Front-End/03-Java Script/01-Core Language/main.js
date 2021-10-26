/* Some JS concept */

window.alert("Hello From Js File");

document.write("<h3 style=color:red;>Hello from JS File !!</h3>");

console.log("Hello From Js File to Console !");

console.error("Error From Js file to Console !");

console.table(["mahmoud", "khaled", "mohamed"]);

console.log("Hello again from %cJs file to Console !", "color:red;");

//------------------------------------------------------------------------------

/*  Data Types  */

console.log(typeof "mahmoud Khaled"); //String
console.log(typeof 100); //Number
console.log(typeof 100.5); //Number
console.log(typeof [10, 5, 6, 5]); //Array => object
console.log(typeof { name: "mahmoud", age: 23, country: "Egypt" }); //Object
console.log(typeof true); //boolean
console.log(typeof null); //object
//------------------------------------------------------------------------------

/*  Variables
    note : Java Script is Loosely typed language so we don't need to specifiy type of variable
*/
/*
  Var
  - Redeclare (Yes)
  - Access Before Declare (Undefined)
  - Variable Scope Drama [Added To Window] ()
  - Block Or Scope Function

  Let
  - Redeclare (No => Error)
  - Access Before Declare (Error)
  - Variable Scope Drama ()
  - Block Or Scope Function

  Const
  - Redeclare (No => Error)
  - Access Before Declare (Error)
  - Variable Scope Drama ()
  - Block Or Scope Function
*/

const pi = 3.14;

pi = 1;
//cannot do this becuase with const you cannot change the value

//___________________

//Let --> is block level

for (let i = 0; i < 3; i++) {
  console.log(i); //--> it will console here
}
console.log(i); // ---> Not here

//----------------------

//Var is for variables available to the entire function

for (var j = 0; j < 3; j++) {
  console.log(j); // --> it will console here
}
console.log(j); //---> it will console here

//------------------------------------------------------------------------------

/*String Syntax And Character Escape Sequence*/

console.log("mahmoud"); //valid
console.log("mahmoud"); //valid
//console.log('mahmoud 'khaled''); //invalid
console.log("mahmoud 'khaled'"); //valid
console.log('mahmoud "khaled"'); //valid
console.log("mahmoud 'khaled'"); //valid
console.log("mahmoud \
khaeld \
mohamed");
console.log("What is your name \n mahmoud ?"); //(\n) new line
var namee = "mahmoud";
var lastName = "khaled";
console.log(namee + " " + lastName); //Concatenation
console.log(`${namee} ${lastName}`); //Concatenation also

let markUp = `
<div class="card">
    <div class="child">
        <h2>${namee}</h2>
        <p>${lastName}</p>
    </div>
</div>
;`;
document.write(markUp);

let ti = "ElAero",
  de = "ElZero Web School",
  da = "25/10";

var markUp = `
<div>
    <h3>${ti}</h3>
    <p>${de}</p>
    <span>${da}</span>
</div>
`;
document.write(markUp.repeat(4)); // repeat it 4 time

//------------------------------------------------------------------------------

/* Unary Plus And Negation Operators */

console.log(100);
console.log("100");
console.log(typeof "100"); // string
console.log(typeof "-100"); //string
console.log(typeof +"100"); //number
console.log(typeof +"0xff"); //number
console.log(+"0xff"); //255
console.log(+true); // 1
console.log(+false); //0
console.log(true); //true
console.log(typeof -"100"); //number
console.log(-"-100"); //100
console.log(Number("88")); //88  , convert string to number
console.log(false - true); //0-1=-1
console.log(20 + true); //21
//------------------------------------------------------------------------------

/* Number */

console.log(1000000); //1000000
console.log(1_000_000); //1000000
console.log(1e6); //1000000
console.log(10 ** 6); //1000000
console.log(2 ** 2); //4
console.log(Math.pow(2, 3)); //8
console.log(Number.MAX_SAFE_INTEGER); // max safe number you can use .

console.log(typeof (100).toString()); //string
console.log(typeof (100).toString()); //string

console.log((100.555).toFixed(1)); //100.6 (as string)

console.log(typeof parseInt("120")); // number
console.log(parseInt("120 mahmoud ")); // 120

console.log(Number.isInteger(100)); // true
//------------------------------------------------------------------------------

/* Math  */

console.log(Math.round(99.2)); //99
console.log(Math.ceil(99.2)); //100
console.log(Math.floor(99.2)); //99
console.log(Math.max(1, 25, 88, 9, 9, 9, 6, 66244545, -58)); //66244545
console.log(Math.min(1, 25, 88, 9, 9, 9, 6, 66244545, -58)); //-58
console.log(Math.pow(2, 4)); //16
console.log(Math.random()); // get random number
console.log(Math.trunc(99.2)); //99 get number without ant floating points
//------------------------------------------------------------------------------

/* String Methods */

let arr = [1, 5, 7, 8];
let str = "mahmoud";

console.log(str[0]); //m
console.log(arr); //1 5 7 8
console.log(arr[1]); //5
console.log(str.charAt(1)); //a
console.log(str.length); //7
console.log(str.toUpperCase()); //MAHMOUD

let str2 = "  mahmoud  ";
console.log(str2.trim()); //mahmoud  (Remove Spaces from first and end of string )
console.log(str2.trim().charAt(3).toUpperCase()); //M ==>remove spaces and make char at index 3 is upper case
console.log(str.indexOf("d")); // 6 ==> if found it return index if not return -1
console.log(str.indexOf("r")); // -1
console.log(str.indexOf("mo")); //3
console.log(str.indexOf("a", 4)); //-1 ==> start from index 4 to search about char a
console.log(str.lastIndexOf("m")); // 3 ==> if found it return index of last m in string  if not return -1
console.log(str.slice(2, 4)); //hm
console.log(str.slice(-2)); //ud
console.log(str.repeat(3)); //mahmoudmahmoudmahmoud

let str3 = "mahmoud,khaled,mohamed";
console.log(str3.split(",")); //(3) ['mahmoud', 'khaled', 'mohamed']

console.log(str.substring(2, 5)); //hmo
console.log(str.substr(0, 2)); //ma
console.log(str.includes("mah")); //true
console.log(str.startsWith("mah")); //true
console.log(str.startsWith("mah", 2)); //false ==> check if from index 2 if string is start with mah
console.log(str.endsWith("mah")); //false
//------------------------------------------------------------------------------

/* Comparison Operators  */

/*
  ==  Equal
  !=  Not Equal

  === Identical
  !== Not Identical

  > Lagrer than
  >= Larger than or equal

  < Smaller than
  <= Smaller than or equal
*/

console.log(10 == "10"); //true ==>compare value only
console.log(10 != "10"); //false ==>compare value only

console.log(10 === 10); //true ==> compare value and type
console.log(10 === "10"); //false ==> compare value and type
console.log(10 !== "10"); //true  ==> compare value and type

console.log(typeof "mahmoud" == typeof "khaled"); //True
//------------------------------------------------------------------------------

/* Comparison Operators  */

/*
  ! Not
  && And
  || Or
*/

console.log(true); //true
console.log(!true); // false
console.log(!(10 == "10")); //false

console.log(10 == 10 && 10 == "10"); //true
console.log(10 == 10 && 10 === "10"); //false

console.log(10 == 10 || 10 === "10"); //true
console.log(10 == 10 || 10 == "10"); //true
//------------------------------------------------------------------------------

/*  If Conditions */

if (10 == 10) {
  console.log("true"); //will execute
} else {
  console.log("false"); //not execute
}

let namee = "mahmoud";
let age = 23;
if (namee == "mahmoud") {
  console.log("Your name is : " + namee);
  if (age > 20) {
    console.log("You are adult man !");
  } else {
    console.log("You are under edge !");
  }
} else if (namee == "aly") {
  console.log("Your name : " + namee);
} else {
  console.log("Not defined");
}

//Conditional Ternary Operator
age > 20 ? console.log("adult") : console.log("under edge ");

age < 20
  ? console.log(20)
  : age > 20 && age < 60
  ? console.log("20 To 60")
  : age > 60
  ? console.log("Larger Than 60")
  : console.log("Unknown");
//------------------------------------------------------------------------------

/* Switch Statemen */

let day = 10;

switch (day) {
  case 0:
    console.log("Saturday");
    break;
  case 1:
    console.log("Sunday");
    break;
  case 2:
    console.log("Monday");
    break;
  default:
    console.log("i don't know ");
}

//------------------------------------------------------------------------------

/*  Nullish Coalescing Operator And Logical Or */

let price;

console.log(price); //undefined
console.log(price || 200); //200 ==> if price is null or undefined or 0 or false or empty string then will print 200.
console.log(price ?? 200); //200 ==> if price is null or undefined then print 200.
//------------------------------------------------------------------------------

/* Array */

let myFriends = [
  "aly",
  "ahmed",
  "mahmoud",
  "asd",
  ["marawan", "Khaled", "Abdo"],
];

console.log(myFriends[1]); //ahmed
console.log(myFriends[0][2]); //y
console.log(myFriends[4]); //(3) ['marawan', 'Khaled', 'Abdo']
console.log(myFriends[4][1]); //khaled
console.log(myFriends[4][1][2]); //a

console.log(myFriends); //(5) ['aly', 'ahmed', 'mahmoud', 'asd', Array(3)]
myFriends[0] = "temp"; //change aly to temp
console.log(myFriends); //(5) ['temp', 'ahmed', 'mahmoud', 'asd', Array(3)]
myFriends[4] = "sameh";
console.log(myFriends); //(5) ['temp', 'ahmed', 'mahmoud', 'asd', 'sameh']
console.log(Array.isArray(myFriends)); //true

console.log(myFriends.length); //4
console.log(myFriends[587]); //undefined
myFriends[5] = "fff";
console.log(myFriends); //(6)[("temp", "ahmed", "mahmoud", "asd", "sameh", "fff")];
myFriends[myFriends.length] = "uuu";
console.log(myFriends); //(7)[("temp", "ahmed", "mahmoud", "asd", "sameh", "fff","uu")];
myFriends.length = 3; //make the array length =3
console.log(myFriends); //(3) ['temp', 'ahmed', 'mahmoud']

let myArray = ["one", "Two", "Three", "Four"];

myArray.unshift("Zero"); //insert new elements in the start of the Array .
console.log(myArray); //(5) ['Zero', 'one', 'Two', 'Three', 'Four']

myArray.push("Five", "Six"); //Add new elements in the end of array
console.log(myArray); //(7) ['Zero', 'one', 'Two', 'Three', 'Four', 'Five', 'Six']

let first = myArray.shift(); //Removes the first element from an array and returns it.
console.log(myArray); //(6) ['one', 'Two', 'Three', 'Four', 'Five', 'Six']

let last = myArray.pop(); //Removes the last element from an array and returns it.
console.log(myArray); //(5) ['one', 'Two', 'Three', 'Four', 'Five']

let myArray2 = [1, 2, 9, 8, 7, 4];

console.log(myArray2.indexOf(9)); //2
console.log(myArray2.indexOf(9, 3)); //-1 ==> start from index 3 to search about number 9 in array

console.log(myArray2.lastIndexOf(9)); //2 ==> search from end to beginning

console.log(myArray2.includes(9)); //true ===>search if number 9 is in array or not

let myArray3 = [1, 5, 4, 87, 10000, 748];
myArray3.sort(); //Sort Array
console.log(myArray3); //(6) [1, 10000, 4, 5, 748, 87]
console.log(myArray3.reverse()); //(6) [87, 748, 5, 4, 10000, 1]

let myArray4 = ["Ahemd", "Mohamed", "Aly", "Mahmoud"];
console.log(myArray4.slice(1, 3)); //(2) ['Mohamed', 'Aly']
console.log(myArray4); //(4) ['Ahemd', 'Mohamed', 'Aly', 'Mahmoud']
console.log(myArray4.slice(-2)); //(2) ['Aly', 'Mahmoud']

myArray4.splice(0, 0, "samer", "samara"); // add the elements from 0 index
console.log(myArray4); //(6) ['samer', 'samara', 'Ahemd', 'Mohamed', 'Aly', 'Mahmoud']

myArray4.splice(0, 2); // start from index 0 and delete two elemet fron it
console.log(myArray4); //(4) ['Ahemd', 'Mohamed', 'Aly', 'Mahmoud']

let arr1 = ["aly", "ahemd", "mohamed"];
let arr2 = ["mahmoud", "khaled", "Moahemd"];

let concatArray = arr1.concat(arr2);
console.log(concatArray); //(6) ['aly', 'ahemd', 'mohamed', 'mahmoud', 'khaled', 'Moahemd']

console.log(concatArray.join("|")); //aly|ahemd|mohamed|mahmoud|khaled|Moahemd

// //------------------------------------------------------------------------------

/* Loop */

let arr = [1, 98, 7, 6, 5, 4];

//For Loop
for (let index = 0; index < arr.length; index++) {
  console.log(arr[index]);
}

let arr2 = ["asd", 1, "Mahmoud", "Aly", 87, 54];
let OnlyNames = [];
for (let index = 0; index < arr2.length; index++) {
  if (typeof arr2[index] === "string") {
    OnlyNames.push(arr2[index]);
  }
}
console.log(OnlyNames); //(3) ['asd', 'Mahmoud', 'Aly']

let products = ["Keyboard", "Mouse", "Pen", "Pad", "Monitor"];
let colors = ["Red", "Green", "Black"];
let models = [2020, 2021];

for (let i = 0; i < products.length; i++) {
  console.log("#".repeat(15));
  console.log(`# ${products[i]}`);
  console.log("#".repeat(15));
  console.log("Colors: ");
  for (let j = 0; j < colors.length; j++) {
    console.log(`- ${colors[j]}`);
  }
  console.log("Models: ");
  for (let k = 0; k < models.length; k++) {
    console.log(`- ${models[k]}`);
  }
}

mainLoop: for (let i = 0; i < products.length; i++) {
  console.log(products[i]);
  nestedLoop: for (let j = 0; j < colors.length; j++) {
    console.log(`- ${colors[j]}`);
    if (colors[j] === "Green") {
      break mainLoop;
    }
  }
}

let showCount = 5;
document.write(
  `<h1>show <label style="color:red;">${showCount}</label> Producs</h1>`
);
for (let i = 0; i < showCount; i++) {
  document.write(`<h3>[${i + 1}] ${products[i]}</h3>`);
  for (let j = 0; j < colors.length; j++) {
    document.write(`<p>${colors[j]}</p>`);
  }
  document.write(`<p>${colors.join(" | ")}</p>`);
}

//While Loop
let index = 0;
while (index < products.length) {
  console.log(products[index]);
  index += 1;
}

//do While Loop
let i = 0;
do {
  console.log(i);
  i++;
} while (i < products.length);

//------------------------------------------------------------------------------

/* Functions */

console.log(typeof console.log); //function

function sayHello() {
  console.log(`Hello Mahmoud`);
}
sayHello(); //Call Function

function sayHelloUser(userName) {
  console.log(`Hello ${userName}`);
  userName = "ASD";
}
sayHelloUser("Mahmoud Khaled");

function printArray(arr) {
  for (let index = 0; index < arr.length; index++) {
    console.log(arr[index]);
  }
}
let arr = [1, 2, 8, 9, 7];
printArray(arr);

function returnSayHello(userName) {
  return `Hello ${userName}`;
}
let ans = returnSayHello("Waleed");
console.log(ans);

function Fun(userName, age) {
  console.log(`Hello ${userName} your age : ${age || "Unknown"}`);
}
Fun("mahmoud", 45); //Hello mahmoud your age : 45
Fun("mahmoud"); //Hello mahmoud your age : Unknown

//Rest param to take unknown number of params
function calc(...numbers) {
  console.log(Array.isArray(numbers)); //true
  let ans = 0;
  for (let index = 0; index < numbers.length; index++) {
    ans += numbers[index];
  }
  return ans;
}
console.log(calc(1, 2, 8, 7, 5, 5, 3)); //31

//note Rest parm should be last param in function parms
function showInfo(
  us = "UnKnown",
  ag = "UnKnown",
  rt = 0,
  show = "Yes",
  ...skills
) {
  document.write("<div>");
  document.write(`<h2>Welcome <span style="color:red;">${us}</span></h2>`);
  document.write(`<p>Age :<span style="color:red">${ag}</span></p>`);
  document.write(`<p>Hour Rate :<span style="color:red">$${rt}</span></p>`);
  if (show === "Yes") {
    document.write("Skills :");
    document.write(`<p style="color:red;">${skills.join(" | ")}</p>`);
  } else {
    document.write(`<p>Skills is Hidden</p>`);
  }
  document.write("</div>");
}
showInfo("mahmoud", 23, 20, "Yes", "HTML", "CSS", "JS", "C#", "ASP.NET Core");

//Anonymous Function
let calculator = function () {
  return 5 + 10;
};
console.log(calculator()); //15

//When We used Anonymous
//Anonymous Function
document.getElementById("show").onclick = function () {
  console.log("Show !!");
};
//Named  Function
document.getElementById("show").onclick = calc;

//After 2sec will show Good at console
setTimeout(function () {
  console.log("Good");
}, 2000);

//nested function
function sayMessage(fName, lName) {
  let message = `Hello`;
  // Nested Function
  function concatMsg() {
    message = `${message} ${fName} ${lName}`;
  }
  concatMsg();
  return message;
}
console.log(sayMessage("Osama", "Mohamed")); //Hello Osama Mohamed

function sayMessage(fName, lName) {
  let message = `Hello`;
  // Nested Function
  function concatMsg() {
    return `${message} ${fName} ${lName}`;
  }
  return concatMsg();
}
console.log(sayMessage("Osama", "Mohamed")); //Hello Osama Mohamed

//Arrow Function : We used it if the block of code in function is one line
let print = () => "Hello From Arrow fun";
console.log(print()); //Hello From Arrow fun

// //------------------------------------------------------------------------------

// /* Higher Order Functions */

/*
  Higher Order Functions
  ---> is a function that accepts functions as parameters and/or returns a function.
*/

/*
- Map
  --- method creates a new array
  --- populated with the results of calling a provided function on every element
  --- in the calling array.

  Syntax map(callBackFunction(Element, Index, Array) { }, thisArg)
  - Element => The current element being processed in the array.
  - Index => The index of the current element being processed in the array.
  - Array => The Current Array

  Notes
  - Map Return A New Array

  Examples
  - Anonymous Function
  - Named Function

*/
let myNums = [1, 2, 3, 4, 5, 6];
let newArray = [];

for (let i = 0; i < myNums.length; i++) {
  newArray.push(myNums[i] + myNums[i]);
}

console.log(newArray);

// Same Idea With Map

let addSelf = myNums.map(function (element, index, arr) {
  return element + element;
}, 10);
console.log(addSelf);

// Same Idea
let addSelf2 = myNums.map((a) => a + a);

console.log(addSelf2);

//Same idea that pass function as parms
function addition(ele) {
  return ele + ele;
}
let add = myNums.map(addition);
console.log(add);

// examples
// ex)Swap Case
let swappingCase = "maHmOuD";

let ans = swappingCase
  .split("")
  .map(function (element) {
    return element === element.toUpperCase()
      ? element.toLocaleLowerCase()
      : element.toLocaleUpperCase();
  })
  .join("");
console.log(ans); //MAhMoUd

//ex) if num if positive make negative and if negative make it positive
let invertedNumber = [1, -7, 878, -12, -9, 66];

let ans2 = invertedNumber.map(function (e) {
  return e * -1;
});
console.log(ans2); //(6) [-1, 7, -878, 12, 9, -66]

//ex)ignore Numbers from string
let ignoreNumber = "ma7moud87";

let ans3 = ignoreNumber
  .split("")
  .map(function (e) {
    return isNaN(parseInt(e)) ? e : "";
  })
  .join("");

console.log(ans3); //mamoud

// same answer with arrow function
let ans4 = ignoreNumber
  .split("")
  .map((e) => (isNaN(parseInt(e)) == true ? e : ""))
  .join("");
console.log(ans4); //mamoud

/*
  - Filter
  --- method creates a new array
  --- with all elements that pass the test implemented by the provided function.

  Syntax filter(callBackFunction(Element, Index, Array) { }, thisArg)
  - Element => The current element being processed in the array.
  - Index => The index of the current element being processed in the array.
  - Array => The Current Array
*/

// Get Friends With Name Starts With A
let friends = ["Ahmed", "Sameh", "Sayed", "Asmaa", "Amgad", "Israa"];

let filterAns1 = friends.filter(function (f) {
  return f.startsWith("A") ? true : false;
});
console.log(filterAns1); //(3) ['Ahmed', 'Asmaa', 'Amgad']

// Get Even Numbers Only
let numbers = [11, 20, 2, 5, 17, 10];

let evenNumbers = numbers.filter(function (el) {
  return el % 2 === 0;
});

console.log(evenNumbers); //(3) [20, 2, 10]

// Filter Words More Than 4 Characters
let sentence = "I Love Foood Code Too Playing Much";

let filterAns2 = sentence
  .split(" ")
  .filter(function (w) {
    return w.length <= 4;
  })
  .join(" ");
console.log(filterAns2); //I Love Code Too Much

// Ignore Numbers
let ignoreNumbers = "Elz123er4o";

let ign = ignoreNumbers
  .split("")
  .filter(function (ele) {
    return isNaN(parseInt(ele));
  })
  .join("");

console.log(ign); //Elzero

// Filter Strings + Multiply
let mix = "A13BS2ZX";

let mixedContent = mix
  .split("")
  .filter(function (ele) {
    return !isNaN(parseInt(ele));
  })
  .map(function (ele) {
    return ele * ele;
  })
  .join("");

console.log(mixedContent); //194
/*
  - Reduce
  --- method executes a reducer function on each element of the array,
  --- resulting in a single output value.

  Syntax
  reduce(callBackFunc(Accumulator, Current Val, Current Index, Source Array) { }, initialValue)
  - Accumulator => the accumulated value previously returned in the last invocation
  - Current Val => The current element being processed in the array
  - Index => The index of the current element being processed in the array.
  ---------- Starts from index 0 if an initialValue is provided.
  ---------- Otherwise, it starts from index 1.
  - Array => The Current Array
*/
let nums = [10, 20, 15, 30];

let add1 = nums.reduce(function (acc, current, index, arr) {
  return acc + current;
});
console.log(add1); //75

// find Longest Word from array

let theBiggest = [
  "Bla",
  "Propaganda",
  "Other",
  "AAA",
  "Battery",
  "Test",
  "Propaganda_Two",
];

let reduceAns1 = theBiggest.reduce(function (acc, curr, index, arr) {
  return acc.length > curr.length ? acc : curr;
});
console.log(reduceAns1); //Propaganda_Two

//remove Chars @
let removeChars = ["E", "@", "@", "L", "Z", "@", "@", "E", "R", "@", "O"];

let reduceAns2 = removeChars.reduce(function (acc, cur, index, arr) {
  return cur != "@" ? acc + cur : acc;
});
console.log(reduceAns2); //ELZERO

/*
  - forEach
  --- method executes a provided function once for each array element.

  Syntax forEach(callBackFunction(Elsement, Index, Array) { }, thisArg)
  - Element => The current element being processed in the array.
  - Index => The index of the current element being processed in the array.
  - Array - The Current Array

  Note
  - Doesnt Return Anything [Undefined]
  - Break Will Not Break The Loop
*/

reduceAns2.split("").forEach((element) => {
  console.log(element);
}); // E L Z E R O
