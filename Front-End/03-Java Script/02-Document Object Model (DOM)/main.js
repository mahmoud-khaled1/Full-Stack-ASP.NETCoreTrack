/*
  DOM :- Document Object Model 
  - DOM Selectors
  --- Find Element By ID
  --- Find Element By Tag Name
  --- Find Element By Class Name
  --- Find Element By CSS Selectors
  --- Find Element By Collection
  ------ title
  ------ body
  ------ images
  ------ forms
  ------ links
*/

// Access Elements By Id
let myIdElement = document.getElementById("my-div");
console.log(myIdElement); //<div id="my-div">Hello Div</div>

//Access Elements By Class Name
let myClassElement = document.getElementsByClassName("my-span");
console.log(myClassElement); //HTMLCollection [span.my-span]

//Access Elements By TagName
let myTagElements = document.getElementsByTagName("p"); // return all elements of type p
console.log(myTagElements); //HTMLCollection(2) [p, p]
console.log(myTagElements[1]); //<p>Hello Paragraph 2</p>  (read second paragraph)
myTagElements[1].innerHTML = "Test"; //Here we change paragraph 2 content to Test

// Access any Element with any Type
let myQueryElement = document.querySelector(".special"); // get first element match that
let myQueryElement2 = document.querySelector("#my-div");
let myAllQueryElement = document.querySelectorAll(".my-span"); //get all elements that match that
console.log(myQueryElement); //<span class="my-span special">my span special</span>

// Access abstraction Elements in our HTML Document
console.log(document.title); //Dom
console.log(document.body); //get all body content
console.log(document.forms[0].one.value); //Hello
console.log(document.links[1].href); //http://facebook.com

// -----------------------------------------------------------------------------------------------
/*
  DOM [Get / Set Elements Content And Attributes]
  - innerHTML
  - textContent
  - Change Attributes Directly
  - Change Attributes With Methods
  --- getAttribute
  --- setAttribute
*/

//innerHTML VS textContent
let myElement = document.querySelector(".js");

console.log(myElement.innerHTML); // JavaScript<span>Div</span> &lt;span&gt;
console.log(myElement.textContent); //JavaScriptDiv <span>

myElement.innerHTML = "Text From <span>Main.js</span>File"; //change element to this
myElement.textContent = "Text From <span>Main.js</span>File"; //Just change content only in the element

//Change Attributes Directly
document.images[0].src = "/Egypt Flag.jpg";
document.images[0].title = "egypt flag";
document.images[0].id = "egyptFlag";

//Change Attributes With Methods
let myLink = document.querySelector(".linkk");

console.log(myLink.getAttribute("class")); //linkk

myLink.setAttribute("class", "link"); //Here we changed class Name from linkk to link
// -----------------------------------------------------------------------------------------------
/*
  DOM [Check Attributes]
  - Element.attributes
  - Element.hasAttribute
  - Element.hasAttributes
  - Element.removeAttribute
*/

//Show All Attributes
console.log(document.getElementsByTagName("p")[0].attributes); // show all attributes of first paragraph

//Check if an element has specific attribute
let myP = document.getElementsByTagName("p")[0];
if (myP.hasAttribute("data-src")) {
  //Found
}

// remove specific Attribute
if (myP.hasAttribute("data-src")) {
  //Found then remove it
  myP.removeAttribute("data-src");
}
// -----------------------------------------------------------------------------------------------
/*
  DOM [Create Elements]
  - createElement
  - createComment
  - createTextNode
  - createAttribute
  - appendChild
*/

//createElement
let myElement = document.createElement("div"); //Create Empty div
let myAttr = document.createAttribute("data-custom"); //Create attribute data-custom for append later
let myText = document.createTextNode("Product One"); // create text for append later
let myComment = document.createComment("This Is Div"); // create comment for append later

myElement.className = "product"; // add class name product to div
myElement.setAttributeNode(myAttr); // add attribute to div
myElement.setAttribute("data-test", "Testing");

// Append Comment To Element
myElement.appendChild(myComment);

// Append Text To Element
myElement.appendChild(myText);

// Append Element To Body
document.body.appendChild(myElement);

console.log(myElement);
//<div class="product" data-custom="" data-test="Testing"><!--This Is Div-->Product One</div>

/*
  DOM [Create Elements]
  - Practice Product With Heading And Paragraph
*/
//Create out Elements
let myMainElement = document.createElement("div");
let myHeading = document.createElement("h2");
let myParagraph = document.createElement("p");

//Create Out Texts
let myHeadingText = document.createTextNode("Product Title");
let myParagraphText = document.createTextNode("Product Description");

// Add Heading Text
myHeading.appendChild(myHeadingText);

// Add Heading To Main Element
myMainElement.appendChild(myHeading);

// Add Paragraph Text
myParagraph.appendChild(myParagraphText);

// Add Paragraph To Main Element
myMainElement.appendChild(myParagraph);

myMainElement.className = "product";

document.body.appendChild(myMainElement);

console.log(myMainElement);
//<div class="product"><h2>Product Title</h2><p>Product Description</p></div>
// -----------------------------------------------------------------------------------------------
/*
  DOM [Deal With Children]
  - children
  - childNodes
  - firstChild
  - lastChild
  - firstElementChild
  - lastElementChild
*/
let myElement = document.querySelector("div");

console.log(myElement);
console.log(myElement.children); //HTMLCollection(2)
console.log(myElement.children[0]); //<p>Hello P</p>
console.log(myElement.childNodes); //NodeList(6)0: comment 1: text 2: p 3: span 4: comment 5: textlength: 6 [[Prototype]]: NodeList
console.log(myElement.childNodes[0]);
console.log(myElement.firstChild);
console.log(myElement.lastChild);

console.log(myElement.firstElementChild); //<p>Hello P</p>
console.log(myElement.lastElementChild); //<span>Hello Span</span>
// -----------------------------------------------------------------------------------------------
/*
  DOM [Events]
  - Use Events On HTML
  - Use Events On JS
  --- onclick
  --- oncontextmenu
  --- onmouseenter
  --- onmouseleave

  --- onload
  --- onscroll
  --- onresize

  --- onfocus
  --- onblur
  --- onsubmit
*/
let myBtn = document.getElementById("btn");

myBtn.onclick = function () {
  console.log("Clicked");
};

myBtn.onmouseleave = function () {
  console.log("Clicked");
};

window.onscroll = function () {
  console.log("Scrolling ");
};
window.onresize = function () {
  console.log("Scroll");
};
// -----------------------------------------------------------------------------------------------
/*
  - Validate Form Practice
  - Prevent Default
*/

let userInput = document.querySelector("[name='UserName']");
let ageInput = document.querySelector("[name='Age']");

document.forms[0].onsubmit = function (event) {
  let userValid = false;
  let ageValid = false;

  if (userInput.value !== "" && userInput.value.length <= 10) {
    userValid = true;
  }
  if (ageInput.value !== "") {
    ageValid = true;
  }
  if (userValid === false || ageValid === false) {
    event.preventDefault(); // not allow form to submit
  }
};
// -----------------------------------------------------------------------------------------------
/*
  DOM [Events Simulation]
  - click
  - focus
  - blur
*/

let one = document.querySelector(".one");
let two = document.querySelector(".two");

// Ex) Focus on second input when page start
window.onload = function () {
  two.focus();
};
//Ex) when exit the input click the link
one.onblur = function () {
  document.links[0].click();
};
// -----------------------------------------------------------------------------------------------
/*
  DOM [Class List]
  - classList
  --- length
  --- contains
  --- item(index)
  --- add
  --- remove
  --- toggle
*/
let element = document.getElementById("my-div");

console.log(element.classList); //DOMTokenList(4) 0: "oen" 1: "two"2: "show"3: "test" length: 4
console.log(typeof element.classList); //object
console.log(element.classList.contains("Ahmed")); //false
console.log(element.classList.contains("two")); //true
console.log(element.classList.item("3")); //test

// when click on div will add those to class list
element.onclick = function () {
  //   element.classList.toggle("show"); // if this class exist in classList will remove it ,and if not will add it
  element.classList.add("add-one", "add-two");
};
// -----------------------------------------------------------------------------------------------
/*
   CSS Styling And Stylesheet
*/

let myDiv = document.getElementById("my-div");

// to play with properties in inLine style
//make color of div red
myDiv.style.color = "red";
//make back ground color blue
myDiv.style.backgroundColor = "blue";
//make font bold
myDiv.style.fontWeight = "bold";
// to write all properties in one line
myDiv.style.cssText = "font-weight:bold;opacity:0.9";
// to remove specific property
myDiv.style.removeProperty("color");
// to set specific property
myDiv.style.setProperty("font-size", "40px");

// to play with properties in StyleSheet
// remove property line-height from styleSheet
document.styleSheets[0].rules[0].style.removeProperty("line-height");
// set back ground color from styleSheet
document.styleSheets[0].rules[0].style.setProperty("background-color", "red");
// -----------------------------------------------------------------------------------------------
/*
  DOM [Deal With Elements]
  - before [Element || String]
  - after [Element || String]
  - append [Element || String]
  - prepend [Element || String]
  - remove
*/

let element = document.getElementById("my-div");
let createdP = document.createElement("p");

// Append an element before div
element.before("Hello from JS before div ");
// Append an element after div
element.after(createdP);
//Append an element in the end
element.append("Hi in the end ");
//Append an element in top of element
element.prepend("Hi in the first ");
//Remove element
element.remove();
// -----------------------------------------------------------------------------------------------
/*
  DOM [Traversing]
  - nextSibling
  - previousSibling
  - nextElementSibling
  - previousElementSibling
  - parentElement
*/

let span = document.querySelector(".Two");

console.log(span.nextSibling); //<!--comment--> return nextSibling element of span
console.log(span.nextElementSibling); //<span class="Three">Three</span>  return next element sibling
console.log(span.previousElementSibling); //<span class="One">One</span>
console.log(span.parentElement); //return parent element of an element here is div

//Ex) when we click on span 2 we need to remove parent element completely

span.onclick = function () {
  // span.parentElement.style.color = "RED";// Here Change color
  span.parentElement.remove(); //Delete it
};
// -----------------------------------------------------------------------------------------------
/*
  DOM [Cloning]
  - cloneNode(Deep)
*/

let myP = document.querySelector("p").cloneNode(true); //get copy of paragraph
let myDiv = document.querySelector("div");

myP.id = `${myP.id}-clone`; // now id of new myP updated to -clone

myDiv.appendChild(myP);
// -----------------------------------------------------------------------------------------------
/*
  DOM [Add Event Listener]
  - addEventListener
  - Use Without On
  - Attach Multiple Events
  - Error Test

  Search
  - Capture & Bubbling JavaScript
  - removeEventListener
*/

let myP = document.querySelector(".myP");

myP.onclick = one;
myP.onclick = two;

function one() {
  console.log("Message From OnClick 1");
}
function two() {
  console.log("Message From OnClick 2");
}

myP.addEventListener("click", function () {
  console.log("Message From OnClick 1 Event");
});

myP.addEventListener("click", one);
myP.addEventListener("click", two);
