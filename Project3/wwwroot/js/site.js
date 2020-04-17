// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var name;

var groupsCollection;

var group = new function () {
	
}

// connect to signalr
var connection = new signalR.HubConnectionBuilder().withUrl("/groupHub").build();
connection.start().then(function () {
	name = prompt("Please enter your name:");
});


$("#sendButton").on("click", function () {
	connection.invoke("AttemptMethod", array).catch(function (err) {
		return console.error(err.toString());
	})
});

connection.on("writeToPage", function (messages) {
	alert(messages);
});

var array = ["one", "two", "three"]


$("#newItem").on("click", function () {
	console.log(name);
})

