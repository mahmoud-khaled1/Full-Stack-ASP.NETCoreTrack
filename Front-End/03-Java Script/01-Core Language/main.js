/* Some JS concept */

window.alert("Hello From Js File");

document.write("<h3 style=color:red;>Hello from JS File !!</h3>");

console.log("Hello From Js File to Console !");

console.error("Error From Js file to Console !")

console.table(["mahmoud","khaled","mohamed"]);

console.log("Hello again from %cJs file to Console !","color:red;")

//------------------------------------------------------------------------------

/*  Data Types  */

console.log( typeof"mahmoud Khaled"); //String
console.log( typeof (100)); //Number
console.log( typeof (100.5));//Number
console.log( typeof [10,5,6,5]);//Array => object
console.log( typeof {name:"mahmoud",age:23,country:"Egypt"}); //Object
console.log( typeof true);//boolean
console.log( typeof null); //object
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

const pi = 3.14

pi = 1
//cannot do this becuase with const you cannot change the value

//___________________

//Let --> is block level

for(let i = 0; i < 3; i++) {
console.log(i) //--> it will console here
}
console.log(i)// ---> Not here

//----------------------

//Var is for variables available to the entire function

for(var j = 0; j < 3; j++) {
console.log(j)// --> it will console here
}
console.log(j) //---> it will console here

//------------------------------------------------------------------------------

/*String Syntax And Character Escape Sequence*/

console.log("mahmoud"); //valid
console.log('mahmoud'); //valid
console.log('mahmoud 'khaled''); //invalid
console.log("mahmoud 'khaled'"); //valid
console.log('mahmoud "khaled"'); //valid
console.log('mahmoud \'khaled\''); //valid
console.log("mahmoud \
khaeld \
mohamed");
console.log("What is your name \n mahmoud ?"); //(\n) new line
var namee="mahmoud";
var lastName="khaled";
console.log(namee+" "+lastName); //Concatenation
console.log(`${namee} ${lastName}`); //Concatenation also

let markUp=`
<div class="card">
    <div class="child">
        <h2>${namee}</h2>
        <p>${lastName}</p>
    </div>
</div>
;`
document.write(markUp);

let ti="ElAero",de="ElZero Web School",da="25/10";

var markUp=`
<div>
    <h3>${ti}</h3>
    <p>${de}</p>
    <span>${da}</span>
</div>
`
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
console.log(+false);//0
console.log(true); //true
console.log(typeof -"100"); //number
console.log(-"-100"); //100
console.log(Number("88")); //88  , convert string to number
console.log(false-true);//0-1=-1
console.log(20+true);//21
//------------------------------------------------------------------------------

/* Number */

console.log(1000000);//1000000
console.log(1_000_000)//1000000
console.log(1e6);//1000000
console.log(10**6); //1000000
console.log(2**2);//4
console.log(Math.pow(2,3));//8
console.log(Number.MAX_SAFE_INTEGER); // max safe number you can use .

console.log(typeof (100).toString()); //string
console.log(typeof 100..toString()); //string

console.log(100.555.toFixed(1)); //100.6 (as string)

console.log(typeof parseInt("120")); // number
console.log( parseInt("120 mahmoud ")); // 120

console.log(Number.isInteger(100));// true
//------------------------------------------------------------------------------

/* Math  */

console.log(Math.round(99.2)); //99
console.log(Math.ceil(99.2)); //100
console.log(Math.floor(99.2));//99
console.log(Math.max(1,25,88,9,9,9,6,66244545,-58));//66244545
console.log(Math.min(1,25,88,9,9,9,6,66244545,-58));//-58
console.log(Math.pow(2,4));//16
console.log(Math.random());// get random number
console.log(Math.trunc(99.2));//99 get number without ant floating points
//------------------------------------------------------------------------------

/* String Methods */

let arr=[1,5,7,8];
let str="mahmoud";

console.log(str[0]); //m
console.log(arr);//1 5 7 8
console.log(arr[1]);//5
console.log(str.charAt(1));//a
console.log(str.length);//7
console.log(str.toUpperCase());//MAHMOUD

let str2="  mahmoud  ";
console.log(str2.trim());//mahmoud  (Remove Spaces from first and end of string )
console.log(str2.trim().charAt(3).toUpperCase()); //M ==>remove spaces and make char at index 3 is upper case
console.log(str.indexOf('d')); // 6 ==> if found it return index if not return -1
console.log(str.indexOf('r'));// -1
console.log(str.indexOf("mo"))//3
console.log(str.indexOf('a',4))//-1 ==> start from index 4 to search about char a
console.log(str.lastIndexOf('m')); // 3 ==> if found it return index of last m in string  if not return -1
console.log(str.slice(2,4));//hm
console.log(str.slice(-2));//ud
console.log(str.repeat(3));//mahmoudmahmoudmahmoud

let str3="mahmoud,khaled,mohamed";
console.log(str3.split(','));//(3) ['mahmoud', 'khaled', 'mohamed']

console.log(str.substring(2,5));//hmo
console.log(str.substr(0,2));//ma
console.log(str.includes("mah"));//true
console.log(str.startsWith("mah"));//true
console.log(str.startsWith("mah",2));//false ==> check if from index 2 if string is start with mah
console.log(str.endsWith("mah"));//false
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

console.log(10=="10");//true ==>compare value only
console.log(10!="10");//false ==>compare value only

console.log(10===10);//true ==> compare value and type
console.log(10==="10");//false ==> compare value and type
console.log(10!=="10");//true  ==> compare value and type

console.log(typeof"mahmoud"  == typeof"khaled");//True
//------------------------------------------------------------------------------

/* Comparison Operators  */

/*
  ! Not 
  && And 
  || Or
*/

console.log(true); //true
console.log(!true); // false
console.log(!(10=="10"));//false

console.log((10==10)&&(10=="10"));//true
console.log((10==10)&&(10==="10"));//false

console.log((10==10)||(10==="10"));//true
console.log((10==10)||(10=="10"));//true
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
console.log(price??200);//200 ==> if price is null or undefined then print 200.
//------------------------------------------------------------------------------

