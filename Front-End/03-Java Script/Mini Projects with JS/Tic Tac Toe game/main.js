//Set Variables
let music = new Audio("music.mp3");
let turnMusic = new Audio("ting.mp3");
let gameOver = new Audio("gameover.mp3");
let turn = "X";
let isgameover = false;

//Game Logics
music.play();
let boxes = document.getElementsByClassName("box");
Array.from(boxes).forEach((element) => {
  let boxText = element.querySelector(".boxtext");
  element.addEventListener("click", () => {
    if (boxText.innerText === "") {
      boxText.innerText = turn;
      turn = ChangeTurn();
      turnMusic.play();
      checkWin();
      if (!isgameover) {
        document.getElementsByClassName("Info")[0].innerText =
          "Turn For " + turn;
      }
    }
  });
});

//Function To Change Player (Turn)
const ChangeTurn = () => {
  return turn === "X" ? "0" : "X";
};

//Function To Check Who is Winner
const checkWin = () => {
  let boxtext = document.getElementsByClassName("boxtext");
  let wins = [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [2, 4, 6],
  ];
  wins.forEach((e) => {
    if (
      boxtext[e[0]].innerText === boxtext[e[1]].innerText &&
      boxtext[e[2]].innerText === boxtext[e[1]].innerText &&
      boxtext[e[0]].innerText !== ""
    ) {
      document.querySelector(".Info").innerText =
        boxtext[e[0]].innerText + " Won";
      document.querySelector(".Info").style.color = "red";
      isgameover = true;
      //   document
      //     .querySelector(".imgbox")
      //     .getElementsByTagName("img")[0].style.width = "100px";
      document
        .querySelector(".imgbox")
        .getElementsByTagName("img")[0].style.width = "500px";
      boxtext[e[0]].parentElement.style.backgroundColor = "red";
      boxtext[e[1]].parentElement.style.backgroundColor = "red";
      boxtext[e[2]].parentElement.style.backgroundColor = "red";
      // gameOver.play();
      gameOver.play();
    }
  });
};

// To Reset Game
let reset = document.getElementById("reset");
reset.addEventListener("click", () => {
  let boxtexts = document.querySelectorAll(".boxtext");
  Array.from(boxtexts).forEach((element) => {
    element.innerText = "";
    element.parentElement.style.backgroundColor = "white";
  });
  turn = "X";
  isgameover = false;
  document.getElementsByClassName("Info")[0].innerText = "Turn For " + turn;
  document.getElementsByClassName("Info")[0].style.color = "black";
  document.querySelector(".imgbox").getElementsByTagName("img")[0].style.width =
    "0px";
  //   document.querySelector(".imgbox").getElementsByTagName("img")[1].style.width =
  //     "0px";
  gameOver.pause();
});
