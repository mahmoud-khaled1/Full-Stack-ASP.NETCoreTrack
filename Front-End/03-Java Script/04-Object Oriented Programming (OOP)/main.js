/*
 Destructuring 
 " is a Java Script expression that allow us to extract data from arrays
   objects , nad maps   and set them  into new , distinct variable ."
*/

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
