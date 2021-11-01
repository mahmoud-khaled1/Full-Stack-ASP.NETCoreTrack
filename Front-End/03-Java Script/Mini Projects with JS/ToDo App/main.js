// Setting the variables
let input = document.querySelector(".input");
let submit = document.querySelector(".add");
let tasksDiv = document.querySelector(".tasks");
let deleteAll = document.querySelector(".deleteAll");
// Empty Array To Store Tasks
let arrayOfTasks = [];

//Check if There is tasks in local storage
if (localStorage.getItem("tasks")) {
  //if Found any tasks , then will reload them to array of tasks
  arrayOfTasks = JSON.parse(localStorage.getItem("tasks"));
}
getDataFromLocalStorage();

// Add Task
submit.onclick = function () {
  if (input.value !== "") {
    addTaskToArray(input.value); // Add Task To Array Of Tasks
    input.value = ""; // Empty Input Field
  }
};

//Click On Task Element
tasksDiv.addEventListener("click", (e) => {
  //Delete Button
  if (e.target.classList.contains("del")) {
    //Remove Element from Page
    e.target.parentElement.remove();
    //Remove Task From local Storage
    deleteTaskFromLocalStorage(e.target.parentElement.getAttribute("data-id"));
  }
  // Task Element
  if (e.target.classList.contains("task")) {
    //Toggle Completed for the task
    toggleStatusTask(e.target.getAttribute("data-id"));
    //Toggle Cone Class
    e.target.classList.toggle("done");
  }
});
//Delete All Tasks
deleteAll.onclick = function () {
  deleteAllData();
};

function addTaskToArray(taskText) {
  //Task Data
  const task = {
    id: Date.now(),
    title: taskText,
    completed: false,
  };
  //push task to array of tasks
  arrayOfTasks.push(task);
  //Print Array of Tasks in Console
  console.log(arrayOfTasks);
  //Add Tasks To Page
  addElementsToPageForm(arrayOfTasks);
  //Add Tasks To Local Storage
  addDataToLocalStorageFromArrayOfTasks(arrayOfTasks);
}

function addElementsToPageForm(arrayOfTasks) {
  //Empty Tasks Div
  tasksDiv.innerHTML = "";
  //Looping on Array Of Tasks
  arrayOfTasks.forEach((task) => {
    //Create Div for each Task
    let div = document.createElement("div");
    div.className = "task";
    //Check if task is Done
    if (task.completed === true) {
      div.className = "task done";
    }
    div.setAttribute("data-id", task.id);
    div.appendChild(document.createTextNode(task.title));
    //Create delete button for every task
    let span = document.createElement("span");
    span.className = "del";
    span.appendChild(document.createTextNode("Delete"));
    //Append Button to main Div
    div.appendChild(span);
    //Add Task Div to Main Tasks Div
    tasksDiv.appendChild(div);
  });
}

function addDataToLocalStorageFromArrayOfTasks(arrayOfTasks) {
  //First convert array of tasks to Json format "Key":"Value" , then store in local storage
  window.localStorage.setItem("tasks", JSON.stringify(arrayOfTasks));
}

// Get Data From Local Storage
function getDataFromLocalStorage() {
  let data = window.localStorage.getItem("tasks");
  if (data) {
    //Convert Data From Json Format to objects
    let tasks = JSON.parse(data);
    addElementsToPageForm(tasks);
  }
}
function deleteTaskFromLocalStorage(taskId) {
  arrayOfTasks = arrayOfTasks.filter((task) => task.id != taskId);
  addDataToLocalStorageFromArrayOfTasks(arrayOfTasks);
}

function toggleStatusTask(taskId) {
  for (let i = 0; i < arrayOfTasks.length; i++) {
    if (arrayOfTasks[i].id == taskId) {
      arrayOfTasks[i].completed == false
        ? (arrayOfTasks[i].completed = true)
        : (arrayOfTasks[i].completed = false);
    }
  }
  addDataToLocalStorageFromArrayOfTasks(arrayOfTasks);
}
function deleteAllData() {
  tasksDiv.innerHTML = "";
  window.localStorage.removeItem("tasks");
  arrayOfTasks = [];
}
