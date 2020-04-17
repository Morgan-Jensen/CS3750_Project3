// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


// connect to signalr
var connection = new signalR.HubConnectionBuilder().withUrl("/groupHub").build();
connection.start();

$("#sendButton").on("click", function () {
	connection.invoke("AttemptMethod", array).catch(function (err) {
		return console.error(err.toString());
	})
});

connection.on("writeToPage", function (messages) {
	alert(messages);
});

var array = ["one", "two", "three"]

function createNewGroup(){

    

	var divTag = document.createElement("div");               //Create Tags needed for new group
	var pTag = document.createElement("p");
	var h3Tag = document.createElement("h3");

	var h3Text = document.createTextNode("New Group One");    //Create text for each tag created
	var pText = document.createTextNode("This is the new group that was made from the div groupOne.");

	h3Tag.appendChild(h3Text);                                //Create text and tag together
	pTag.appendChild(pText);
    
	var element = document.getElementById("groupOne");        //Get id for the div going into
	element.appendChild(h3Tag);
	element.appendChild(pTag);
}
