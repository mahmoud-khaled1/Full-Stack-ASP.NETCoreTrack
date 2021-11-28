// /*
//  Destructuring
//  " is a Java Script expression that allow us to extract data from arrays
//    objects , nad maps   and set them  into new , distinct variable ."
// */

let myFriends = ["Ahmed", "Aly", "Mohamed"];

// Ex)1
let [a, b, c] = myFriends; //Destructuring
console.log(a); //Ahmed
console.log(b); //Aly
console.log(c); //Mohamed

// Ex) 2
let [x, , y] = myFriends;
console.log(x); //Ahmed
console.log(y); //Mohamed
console.log("----------------");
// Ex) 3
let myFriends2 = [
  "Ahmed",
  "Aly",
  "Mohamed",
  ["Shady", "Amr", ["Mahound", "Tamer"]],
];
console.log(myFriends2[3]); //(3) ['Shady', 'Amr', Array(2)]
console.log(myFriends2[3][2]); //(2) ['Mahound', 'Tamer']
console.log(myFriends2[3][2][1]); //Tamer

let aa;
let bb;
[, , , [aa, , [, bb]]] = myFriends2;
console.log(aa); //Shady
console.log(bb); //Tamer
console.log("----------------");
// Ex) 4  ===> Swapping Two Variables
let book = "Video";
let video = "Book";

[book, video] = [video, book];

console.log(video); //Video
console.log(book); //Book
console.log("----------------");
//Ex) 5 ==>Destructuring Objects

const user = {
  name: "Mahmoud",
  age: 23,
  address: "Qena",
  title: "Software engineer",
  theColor: "Black",
  skills: {
    html: 70,
    css: 80,
  },
};
// let theName;
// let theAddress;
// let theAge;
// let theTitle;
const {
  theName,
  theAge,
  theAddress,
  theTitle,
  theColor: co = "red",
  skills: { html, css: cc },
} = user;
console.log(theName); //Mahmoud
console.log(co); //Black
console.log(`my HTML Skill rate :${html}`); //my HTML Skill rate :70
console.log(`my CSS Skill rate :${cc}`); //my CSS Skill rate :80

const { html: skillOne, css: skillTwo } = user.skills;
console.log(`my HTML Skill rate :${skillOne}`); //my HTML Skill rate :70
console.log(`my CSS Skill rate :${skillTwo}`); //my CSS Skill rate :80
console.log("----------------");

//Ex) 6 ==>Destructuring Function Params

showDetails(user);

//normal one
// function showDetails(obj) {
//   console.log(`Your Name :${obj.name}`); //Your Name :Mahmoud
//   console.log(`Your age :${obj.age}`); //Your age :23
//   console.log(`Your address :${obj.address}`); //Your address :Qena
// }

//Destructuring params
function showDetails({ theName, theAge, skills: { css } } = user) {
  console.log(`Your Name :${theName}`); //Your Name :Mahmoud
  console.log(`Your age :${theAge}`); //Your age :23
  console.log(`Css Skill :${css}`); //Css Skill :80
}
//------------------------------------
// OOP
/*
  Defining Object
  [1] Object Literal
*/
let user = {
  // Properties
  firstName: "Mahmoud",
  lastName: "Khaled",
  // Methods
  getFullName: function () {
    return `Full Name ${this.firstName} ${this.lastName}`;
  },
};
// Accessing Object Properties
console.log(user.firstName); // Dot Notation
console.log(user["firstName"]); // Bracket Notation

console.log(typeof user.firstName); // String

// Accessing Object Methods
console.log(typeof user.getFullName); // Function
console.log(user.getFullName()); //Full Name Mahmoud Khaled
//------------------------------------
/*
Dot Notation vs Bracket Notation

*/
let myObj = {
  One: 1,
  "Two!": 2,
};

//Dot Notation
console.log(myObj.One); // 1
// console.log(myObj."One"); // Syntax Error
// console.log(myObj.Two!); // Syntax Error

//Bracket Notation
console.log(myObj["One"]); // 1
console.log(myObj["Two!"]); // 2

let myObj2 = {
  1: "One",
  2: "Two",
};

// console.log(myObj2.1); // Syntax Error
console.log(myObj2["1"]); //One
console.log(myObj2["2"]); //Two

let myVariable = "name";

let myLastObj = {
  name: "mahmoud",
};

console.log(myLastObj.myVariable); // Undefined
console.log(myLastObj[myVariable]); // mahmoud
console.log(myLastObj["name"]); // mahmoud
//------------------------------------
/*
  Defining Object
  [1] Object Literal
  [2] With New Keyword
*/
let user = new Object();
//Add Properties
user.fName = "mahmoud";
user.lastName = "khaled";
user["age"] = 23;

console.log(user.fName); //mahmoud
console.log(user.age); //23

//Add methods
user.getFullName = function () {
  return user.fName + " " + user.lastName;
};
console.log(user.getFullName()); //mahmoud khaled
//------------------------------------
/*
  Defining Object
  [1] Object Literal
  [2] With New Keyword
  [3] With Object.create()
*/
let mainObj = {
  hasDiscount: true,
  showMsg: function () {
    return `You${this.hasDiscount ? "" : " Don't"} Have Discount`;
  },
};
console.log(mainObj.hasDiscount); //true
console.log(mainObj.showMsg()); //You Have Discount

let otherObj = Object.create(mainObj);
console.log(otherObj.hasDiscount); //true
console.log(otherObj.showMsg()); //You Have Discount
otherObj.hasDiscount = false;
console.log(otherObj.hasDiscount); //false
console.log(otherObj.showMsg()); //You Don't Have Discount

let lastObj = Object.create(mainObj);
console.log(lastObj.hasDiscount); //true
console.log(lastObj.showMsg()); //You Have Discount
//------------------------------------
/*
  Defining Object
  [1] Object Literal
  [2] With New Keyword
  [3] With Object.create()
  [4] With Object.assign()
*/
const src1 = {
  prop1: "Value1",
  prop2: "Value2",
  method1: function () {
    return `Method 1`;
  },
};

const src2 = {
  prop3: "Value3",
  prop4: "Value4",
  method2: function () {
    return `Method 2`;
  },
};

const target = {
  prop5: "Value5",
};

Object.assign(target, src1, src2, { prop6: "Value6" });

console.log(target);

const myObject = Object.assign({}, target, { prop7: "Value7" });

console.log(myObject);
console.log(myObject.prop1);
console.log(myObject.prop2);
console.log(myObject.prop6);
console.log(myObject.method1());
console.log(myObject.method2());
//------------------------------------
/*
  Delete Operator
*/
const user = { name: "Mahmoud" };

console.log(user); //{name: 'Mahmoud'}
console.log(user.name); //Mahmoud
delete user.name;
// delete user["name"];
console.log(user);//{}

const username = "Aly";
console.log(username);//Aly
console.log(delete username);//false   cause can't delete const
console.log(username);//Aly

const eObj = {};
Object.defineProperty(eObj, "a", { value: 1, configurable: false });
console.log(eObj);//{a: 1}
console.log(eObj.a);//1

console.log(delete eObj.a);//false

console.log(eObj);//{a: 1}
console.log(eObj.a);//1
//------------------------------------
/*
  For ... In Loop
  Loop Through The Properties Of The Objects
*/
const user = {
  name: "mahmoud",
  country: "Egypt",
  age: 23,
};

let finalData = "";

for (let info in user) {
  console.log(`The ${info} Is => ${user[info]}`);
}
//------------------------------------
/*
  Constructor Function
*/
function Phone(serial, color, price) {
  this.serial = serial;
  this.color = color;
  this.price = price - 100;
}

let phone1 = new Phone(123, "Red", 500);
let phone2 = new Phone(159, "Black", 500);
let phone3 = new Phone(167, "Silver", 500);

console.log(phone1.serial); //123
console.log(phone1.color); //Red
console.log(phone1.price); //400

console.log(phone2.serial); //159
console.log(phone2.color); //Black
console.log(phone2.price); //400

console.log(phone3.serial); //167
console.log(phone3.color); //Silver
console.log(phone3.price); //400

function Phone(serial) {
  // this is The Created Object From The Constrcutor Function
  console.log(this);
  this.serial = `#${serial}`;
}

let phone11 = new Phone(123456);
let phone22 = new Phone(528951);
let phone33 = Phone(125698);
console.log(phone11.serial); //#123456
console.log(phone22.serial); //#528951
console.log(window.serial); //#125698
console.log(phone11 instanceof Phone); //true
console.log(phone22 instanceof Phone); //true
console.log(phone33 instanceof Phone); //false
console.log(phone11.constructor === Phone); //true
console.log(phone22.constructor === Phone); //true
//------------------------------------
/*
  Constructor Function
  Dealing With Properties
*/
function User(fName, lName, age, country) {
  this.fName = fName;
  this.lName = lName;
  this.age = age;
  this.country = country;
  this.fullName = function () {
    return `Full Name: ${this.fName} ${this.lName}`;
  };
  this.ageInDays = function () {
    return `Age In Days: ${this.age * 365}`;
  };
}
// User.country = "Egypt"; Wrong
let user1 = new User("mah", "kha", 37, "Egypt");
let user2 = new User("Ahmed", "Ali", 30, "KSA");

console.log(user1);
console.log(`Full Name: ${user1.fName} ${user1.lName}`);
console.log(user1.fullName());
console.log(user1.ageInDays());
console.log(user2);
console.log(user2.country); //KSA
console.log(user2.ageInDays()); //Age In Days: 10950
//------------------------------------
/*
  Built In Constructors
*/

function User(name) {
  this.name = name;
  this.welcome = function () {
    return `Welcome ${this.name}`;
  };
}

let user1 = new User("asd");
let user2 = new User("Ahmed");

// let obj1 = new Object({ a: 1 });
// let obj2 = new Object({ b: 2 });
let obj3 = { c: 3 };

let num1 = new Number(1);
let num2 = new Number(2);
let num3 = 3;

let str1 = new String("Osama");
let str2 = new String("Ahmed");
let str3 = "Mahmoud";
//------------------------------------
/*
Prototype 
*/
function User(name) {
  this.name = name;
  this.welcome = function () {
    return `Welcome ${this.name}`;
  };
}

let user1 = new User("asd");
let user2 = new User("Ahmed");

console.log(User.prototype);
console.log(user1);

// add new method to User Constructor
User.prototype.addTitle = function () {
  return `Mr. ${this.name}`;
};

console.log(Object.prototype);

console.log(Object.prototype);

// add property mah to Object
Object.prototype.mah = "mahmoud khaled mohamed ";

const myObject = { a: 1, b: 2 };
console.log(myObject.a); //1
console.log(myObject.b); //2
console.log(myObject.mah); //mahmoud khaled mohamed

String.prototype.zFill = function (width) {
  let theResult = this;

  while (theResult.length < width) {
    theResult = `0${theResult}`;
  }

  return theResult.toString();
};

console.log("12".zFill(6)); //000012
console.log("516".zFill(6)); //000516
console.log("3625".zFill(6)); //003625

String.prototype.sayYouLoveMe = function () {
  return `I Love You ${this}`;
};

console.log("mahmoud".sayYouLoveMe()); //I Love You mahmoud
//------------------------------------
/*
  Class
*/

class User {
  constructor(name, email) {
    this.name = name;
    this.email = email;
  }
  sayHello = function () {
    return `Hello ${this.name}`;
  };
  showEmail() {
    return `Your Email Is ${this.email}`;
  }
}

let user1 = new User("mahmoud", "mahmoud@gmail.com");
console.log(user1.email); //mahmoud@gmail.com
//------------------------------------
/*
  Class
  Static Properties & Methods
*/
class User {
  // Static Properties
  static counter = 0;

  constructor(name, email, counter) {
    this.name = name;
    this.email = email;
    this.counter = counter;
    User.counter++;
  }
  sayHello() {
    return `Hello ${this.name}`;
  }
  showEmail() {
    return `Your Email Is ${this.email}`;
  }

  // Static Methods
  static countObjects = function () {
    return `${this.counter} Objects Created.`;
  };
}

let user1 = new User("Osama", "o@nn.sa", 2);
let user2 = new User("Ahmed", "o@nn.sa", 2);
let user3 = new User("Osama", "o@nn.sa", 2);
let user4 = new User("Osama", "o@nn.sa", 2);
// let user2 = User("Ahmed", "a@nn.sa"); // TypeError: Class constructor User

console.log(typeof User); // Function
console.log(User === User.prototype.constructor); // True

console.log(User.countObjects()); //4 Objects Created.
//------------------------------------
/*
  Class
  Inheritance
*/

class User {
  constructor(name, email) {
    this.name = name;
    this.email = email;
  }
  sayHello() {
    return `Hello ${this.name}`;
  }
  showEmail() {
    return `Your Email Is ${this.email}`;
  }
  writeMsg() {
    return `Message From Parent Class`;
  }
}

class Admin extends User {
  constructor(name, email) {
    super(name, email);
  }
  adminMsg() {
    return `You Are Admin`;
  }
  writeMsg() {
    return `Message From Child Class`;
  }
}

let admin1 = new Admin("Osama", "o@nn.sa");
console.log(admin1.writeMsg()); //Message From Child Class
//------------------------------------
/*
  JavaScript Accessors
  Getters & Setters
*/

class User {
  constructor(name, email) {
    this.name = name;
    this.email = email;
  }
  sayHello() {
    return `Hello ${this.name}`;
  }
  get showInfo() {
    return `Name: ${this.name}, Email" ${this.email}`;
  }
  changeName(newName) {
    this.name = newName;
  }
  set changeEmail(newEmail) {
    this.email = newEmail;
  }
}

let user1 = new User("Osama", "o@nn.sa");

console.log(user1.name);
console.log(user1.email);
console.log(user1.showInfo);

user1.changeName("Mahmoud");
console.log(user1.name);
console.log(user1.showInfo);

user1.changeEmail = "oooo@gmail.com";
console.log(user1.name);
console.log(user1.email);
console.log(user1.showInfo);
