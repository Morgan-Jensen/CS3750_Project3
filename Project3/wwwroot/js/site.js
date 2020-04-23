// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var name;
var length;

// connect to signalr
var connection = new signalR.HubConnectionBuilder().withUrl("/groupHub").build();
connection.start().then(function () {
	name = prompt("Please enter your name:");
	connection.invoke("FindGroupLength");
});

connection.on("setGroupLength", function (newLength) {
	length = newLength;
});


$("#newGroupButton").on("click", function () {
	connection.invoke("CreateNewGroup").catch(function (err) {
		return console.error(err.toString());
	})
})

//function addGroup() {
//	var sel = document.getElementById('mydropdown') // find the drop down
//	var length = sel.options.length;
//	for (i = length - 1; i >= 0; i--) {
//		sel.options[i] = null;
//	}
//	var i = title.length + 1;
//	title[title.length] = "Group" + i;
//	listGroups();
//	//document.getElementById("demo").innerHTML = length;
//}


connection.on("createGroup", function () {
	var sel = document.getElementById('mydropdown') // find the drop down
	//var length = sel.options.length;
	connection.invoke("FindGroupLength");
	for (i = length - 1; i >= 0; i--) {
		sel.options[i] = null;
	}
	var i = title.length + 1;
	title[title.length] = "Group" + i;
	listGroups();
});

