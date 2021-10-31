/*
  BOM [Browser Object Model]
  - Introduction
  --- Window Object Is The Browser Window
  --- Window Contain The Document Object
  --- All Global Variables And Objects And Functions Are Members Of Window Object
  ------ Test Document And Console
  - What Can We Do With Window Object ?
  --- Open Window
  --- Close Window
  --- Move Window
  --- Resize Window
  --- Print Document
  --- Run Code After Period Of Time Once Or More
  --- Fully Control The URL
  --- Save Data Inside Browser To Use Later
*/
window.document.title = "Hello JS";
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - alert(Message) => Need No Response Only Ok Available
  - confirm(Message) => Need Response And Return A Boolean
  - prompt(Message, Default Message) => Collect Data
*/

// Alert : the three type of alert is the same
window.alert("Hello 1");
alert("Hello 2");
this.alert("Hello 3");

// Confirm
let confirmMsg = confirm("Are You Sure?"); //return true if click yes and no if other

if (confirmMsg === true) {
  console.log("Item Deleted");
} else {
  console.log("Item Not Deleted");
}

//prompt
let promptMsg = prompt("Good Day To You?", "Write Day With 3 Characters"); //allow user to write anything and return it

console.log(promptMsg);
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - setTimeout(Function, Timeout, Additional Params)
  - clearTimeout(Identifier)
*/
setTimeout;
//Ex) After 3 sec Msg will appear in the console
setTimeout(function () {
  console.log("Msg");
}, 3000);

//Ex) after 3 sec will call function and pass parameter to it
setTimeout(sayMsg, 3000, "mahmoud");

function sayMsg(userName) {
  console.log(`Hello ${userName}`);
}

//clearTimeout if i use it will stop work of setTimeout

//Ex) if i press button stop then setTimeout will stop
let btn = document.querySelector("button");

let counter = setTimeout(sayMsg, 3000, "Mahmoud", 38);
function sayMsg(user, age) {
  console.log(`Iam Message For ${user} Age Is : ${age}`);
}
btn.onclick = function () {
  clearTimeout(counter); //stop
};
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - setInterval(Function, Milliseconds, Additional Params) do the same of setTimeout but here loop every specific time 
  - clearInterval(Identifier)
*/

//Ex) every 1 sec Msg will execute in the console
setInterval(function () {
  console.log(`Msg`);
}, 1000);

//Ex) every 1 sec Msg will execute in the console
setInterval(sayMsg, 1000);
function sayMsg() {
  console.log(`Iam Message`);
}
//Ex) every 3 sec will call function and pass parameter to it
setInterval(sayMsg, 3000, "Mahmoud", 38);
function sayMsg(user, age) {
  console.log(`Iam Message For ${user} His Age Is: ${age}`);
}

//Ex) make function that   read the number inside the div and decrease it by 1
let div = document.querySelector("div");

function countDown() {
  div.innerHTML -= 1;
  if (div.innerHTML === "0") {
    clearInterval(counter);
  }
}
let counter = setInterval(countDown, 1000);
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - location Object
  --- href Get / Set [URL || Hash || File || Mail]
  --- host
  --- hash
  --- protocol
  --- reload()
  --- replace()
  --- assign()
*/
console.log(location.href); //http://127.0.0.1:5500/index.html

location.href = "https://google.com"; // go to google
location.href = "/#sec02"; // go to div sec02 in our page

console.log(location.host); //127.0.0.1:5500
console.log(location.hostname); //127.0.0.1

console.log(location.protocol); //http:
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - open(URL [Opt], Window Name Or Target Attr [Opt], Win Features [Opt], History Replace [Opt])
  - close()
  - Window Features
  --- left [Num]
  --- top [Num]
  --- width [Num]
  --- height [Num]
  --- menubar [yes || no]

  Search
  - Window.Open Window Features
*/

//Ex) open facebook after 5 sec
setTimeout(function () {
  window.open("https://www.facebook.com");
}, 5000);

//Ex) Open google after 2 sec in specific width and height
setTimeout(function () {
  window.open(
    "https://google.com",
    "_blank",
    "width=400,height=400,left=200,top=10"
  );
}, 2000);

window.close(); //will close the tab
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - History API
  --- Properties
  ------ length
  --- Methods
  ------ back()
  ------ forward()
  ------ go(Delta) => Position In History

  Search [For Advanced Knowledge]
  - pushState() + replaceState()
*/
console.log(history);
console.log(history.length); //get number of page we visited
history.back(); //return to previous page
history.forward(); // go to forward page
history.go(1); //take number of page we want to go
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  - stop()
  - print()
  - focus()
  - scrollTo(x, y || Options)
  - scroll(x, y || Options)
  - scrollBy(x, y || Options)
*/

window.stop(); //Stop loading of page
window.print(); //save page in any format

let myNewWindow = window.open("https://google.com", "", "width=500,height=500");

//Scroll to specific position
window.scrollTo({
  left: 500,
  top: 200,
  behavior: "smooth",
});
/*
  BOM [Browser Object Model]
  - Practice => Scroll To Top
  - scrollX [Alias => PageXOffset]
  - scrollY [Alias => PageYOffset]
*/

//Ex) make button to go to up when we down
let btn = document.querySelector("button");

window.onscroll = function () {
  if (window.scrollY >= 600) {
    btn.style.display = "block";
  } else {
    btn.style.display = "none";
  }
};

btn.onclick = function () {
  window.scrollTo({
    left: 0,
    top: 0,
    behavior: "smooth",
  });
};
//---------------------------------------------------
/*
  BOM [Browser Object Model]
  Local Storage
  - setItem
  - getItem
  - removeItem
  - clear
  - key

  Info
  - No Expiration Time
  - HTTP And HTTPS
  - Private Tab
*/

// Set
window.localStorage.setItem("color", "#F00");
window.localStorage.fontWeight = "bold";
window.localStorage["fontSize"] = "20px";
// Get
console.log(window.localStorage.getItem("color"));
console.log(window.localStorage.color);
console.log(window.localStorage["color"]);
// Remove One
window.localStorage.removeItem("color");
// Remove All
window.localStorage.clear();

// Get Key
console.log(window.localStorage.key(0));

// Set Color In Page
document.body.style.backgroundColor = window.localStorage.getItem("color");

console.log(window.localStorage);
console.log(typeof window.localStorage);

/*
  BOM [Browser Object Model]
  Local Storage Practice
*/
let lis = document.querySelectorAll("ul li");
let exp = document.querySelector(".experiment");

if (window.localStorage.getItem("color")) {
  // If There Is Color In Local Storage
  // [1] Add Color To Div
  exp.style.backgroundColor = window.localStorage.getItem("color");
  // [2] Remove Active Class From All Lis
  lis.forEach((li) => {
    li.classList.remove("active");
  });
  // [3] Add Active Class To Current Color
  document
    .querySelector(`[data-color="${window.localStorage.getItem("color")}"]`)
    .classList.add("active");
}

lis.forEach((li) => {
  li.addEventListener("click", (e) => {
    // console.log(e.currentTarget.dataset.color);
    // Remove Active Class From all Lis
    lis.forEach((li) => {
      li.classList.remove("active");
    });
    // Add Active Class To Current Element
    e.currentTarget.classList.add("active");
    // Add Current Color To Local Storage
    window.localStorage.setItem("color", e.currentTarget.dataset.color);
    // Change Div Background Color
    exp.style.backgroundColor = e.currentTarget.dataset.color;
  });
});
/*
//---------------------------------------------------
  BOM [Browser Object Model]
  Session Storage
  - setItem
  - getItem
  - removeItem
  - clear
  - key

  Info
  - New Tab = New Session
  - Duplicate Tab = Copy Session
  - New Tab With Same Url = New Session
*/

window.localStorage.setItem("color", "red");
window.sessionStorage.setItem("color", "blue");

document.querySelector(".name").onblur = function () {
  // console.log(this.value);
  window.localStorage.setItem("input-name", this.value);
};
