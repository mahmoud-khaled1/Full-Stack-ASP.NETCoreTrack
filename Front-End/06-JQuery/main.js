// 1- Syntax of JQuery

// This will execute first when app in run and all resources loaded successfully
$(document).ready(function () {
  //Your Code
  //$("p").hide(); // when app is start load then hide all paragraph .
  // $("p").css("color", "#F00"); // when app is start load make all paragraph color Red
});
// same :This will execute first when app in run and all resources loaded successfully
$(function () {
  //Your Code
});

// -----------------------------------------------------------------------------------------

//2- Events ===> Click / Dblclick / Mouseenter / Mouseleave / Hover

$(function () {
  //Click
  $("button").click(function () {
    // $("p").hide(); // // when i press on button then paragraph will hide
    // $("p").css("color", "#F00"); //change color of paragraph to red
    //$(this).css("color", "#F00"); // change text of this button color to red
  });

  // Dblclick
  $("button").dblclick(function () {
    //$("p").css("color", "#F00"); //change color of paragraph to red when double click
  });

  //Mouseenter
  $("button").mouseenter(function () {
    //$("p").css("color", "#F00"); //change color of paragraph to red when Mouseenter ( when hover button then will become always red)
  });

  //Mouseleave
  $("button").mouseleave(function () {
    //$("p").css("color", "#F00"); //change color of paragraph to red when Mouseenter ( when hover button and leave it  then will become always red)
  });

  //Hover : hover take 2 function as parameters first one when hover and second one when leave it .
  $("button").hover(
    //hover
    function () {
      //$("p").css("color", "#F00"); //change color of paragraph to red when hover button
    },
    //leave
    function () {
      // $("p").css("color", "#00F"); //change color of paragraph to blue when leave button
    }
  );
});

// -----------------------------------------------------------------------------------------

//3- Effects ===> Hide / Show / Toggle

$(function () {
  //Hide : Hide any Element
  $("button").click(function () {
    //hide(speed,callback) ==> hide take 2 parma speed of hide default speed 400ms , callback execute specific function after hide
    //$("p").hide(); //Hide paragraph when click button
    //$("p").hide(2000); //Hide paragraph when click button within 2000ms
    //$("p").hide("slow"); //Hide paragraph when click button slowly
    //$("p").hide("fast"); //Hide paragraph when click button faster
    // $("p").hide("slow", function () {
    //   //after hide the paragraph write Hello in the console
    //   console.log("Hello after hide p");
    // });
  });

  //Show : Show any Element
  //Show(speed,callback) ==> Show take 2 parma speed of Show default speed 400ms , callback execute specific function after Show
  $("button").click(function () {
    // $("p").show(); //show paragraph when click button :note paragraph display:none in css file first
  });

  //Toggle : replace between Hide and Show
  //Toggle(speed,callback) ==> Toggle take 2 parma speed of Show default speed 400ms , callback execute specific function after Toggle
  $("button").click(function () {
    //$("p").toggle(); //show paragraph when click button if paragraph is hide and hide if paragraph is show
  });
});

// -----------------------------------------------------------------------------------------

//4- Effects ===> Fade In / Fade Out / Fade Toggle / Fade To

$(function () {
  //FadeIn
  $("button").click(function () {
    //fadeIn(speed,callback) ==> fadeIn take 2 parma speed of fadeIn default speed 400ms , callback execute specific function after fadeIn
    //$("div").fadeIn(); // like show , if element is hide then will show it ,but here more smoothing
  });

  //FadeOut
  $("button").click(function () {
    //FadeOut(speed,callback) ==> FadeOut take 2 parma speed of FadeOut default speed 400ms , callback execute specific function after FadeOut
    //$("div").fadeOut(); // like Hide , if element is show then will hide it ,but here more smoothing
  });

  //Fade Toggle
  $("button").click(function () {
    //fadeToggle(speed,callback) ==> fadeToggle take 2 parma speed of FadeOut default speed 400ms , callback execute specific function after fadeToggle
    //$("div").fadeToggle(); // like toggle , if element is show then will hide it , and if hide then will show it but here more smoothing
  });

  //Fade To
  $("button").click(function () {
    //fadeTo(speed,opacity,callback) ==> fadeTo take 3 parma speed of FadeOut default speed 400ms , precision of opacity , callback execute specific function after fadeTo
    //$("div").fadeTo(2000, 0.3); // will make fade to specific precision of opacity .
  });
});

// -----------------------------------------------------------------------------------------

//5-Effects - SlideDown / SlideUp / SlideToggle

$(function () {
  //SlideDown
  //when i click on the button then hidden div will show
  //slideDown(speed,callback) ==> slideDown take 2 parma speed of slideDown default speed 400ms , callback execute specific function after slideDown
  $(".open").click(function () {
    // $(".box").slideDown();
  });

  //SlideUp
  //when i click on the button then  div will will be hidden
  //slideUp(speed,callback) ==> slideUp take 2 parma speed of slideUp default speed 400ms , callback execute specific function after slideUp
  $(".open").click(function () {
    // $(".box").slideUp();
  });

  //SlideToggle
  // like toggle , if element is show then will hide it , and if hide then will show it like slide
  //slideToggle(speed,callback) ==> slideToggle take 2 parma speed of slideToggle default speed 400ms , callback execute specific function after slideToggle
  $(".open").click(function () {
    //$(".box").slideToggle();
  });
});

// -----------------------------------------------------------------------------------------

//6-Effects ===> Animate

$(function () {
  //animate parms : .animate({css properties},speed,callback function)
  // make width of div reach to 600 px with animated motion with speed 1000ms ,and then show span
  //   $("div").animate(
  //     {
  //       width: "600px",
  //     },
  //     1000,
  //     function () {
  //       $("span").fadeIn();
  //     }
  //   );
  // div will reach width to 600px and height to 600px and far from left with 400px
  //   $("div").animate(
  //     {
  //       width: "600px",
  //       height: "600px",
  //       left: "400px",
  //     },
  //     1000
  //   );
});

// -----------------------------------------------------------------------------------------

// 7-Effects ===> Stop :used to stop any animation running now
//$(function () {
//.stop(stopAllAnimation,goToEnd)
//when i click on the button the first animation will stop and if press again second one will stop
// if i want to stop all animation when click on button then should make .stop(true);
//   $("button").click(function () {
//     $("div").stop();
//   });

//   $("div").animate(
//     {
//       width: "500px",
//       height: "600px",
//     },
//     2000
//   );
//   //after complete first animation then will be like first look
//   $("div").animate(
//     {
//       width: "300px",
//       height: "100px",
//     },
//     2000
//   );
// });

// -----------------------------------------------------------------------------------------

// 7-Effects  ===>  Chain :make more than one effect in one statement

$(function () {
  //normal one
  //   $("div").slideUp(1000);
  //   $("div").slideDown(1000);
  //   $("div").fadeOut(1000);
  //with chain
  //$("div").slideUp(1000).slideDown(1000).fadeOut(1000);
});

// -----------------------------------------------------------------------------------------
// 8- Html ===> Get / Set Elements And Attributes
$(function () {
  //var content = $("div").text(); // content of div
  //alert(content); // welcome to JQuery
  //$("p").text(content); // copy div content to p content
  //var content = $("div").html(); // content of div include any element inside the div and all style
  //$("p").html(content); //copy all div elements to p

  $("button").click(function () {
    // $("input").val("mahmoud"); // when click on the button input value will be mahmoud
    //$("input").val($("div").text()); // when click on the button input value will be content of div
    //$("input").val($("div").attr("class")); //when click on the button input value will be class attribute of div
    //$("div").attr("class", "mahmoud"); // when click on the button then class of div will be change to mahmoud
  });
});
// -----------------------------------------------------------------------------------------
// 9- Html ===> Append / AppendTo / Prepend / PrependTo / Before / After
