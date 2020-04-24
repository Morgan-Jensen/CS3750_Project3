// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var name;
var length;

// connect to signalr
var connection = new signalR.HubConnectionBuilder().withUrl("/groupHub").build();
connection.start().then(function () {
	name = prompt("Please enter your name:");
});


function updateText(numberId) {
	var grpForItem = title[shortcut.mydropdown.selectedIndex];

    //Send to the server. The group id, item id, and the text area content.

	connection.invoke("ItemUpdated", numberId).catch(function (err) {
		return console.error(err.toString());
	});

	if (shortcut.text00.value != "null" || shortcut.text00.value != "undefined") {
		descriptions[currentGroupItemDescNum[0]] = grpForItem + ", " + shortcut.text00.value;
	}
	else {
		shortcut.text00.value = "Error. No item here to edit.";
	}
	if (shortcut.text01.value != "null" || shortcut.text01.value != "undefined") {
		descriptions[currentGroupItemDescNum[1]] = grpForItem + ", " + shortcut.text01.value;
	}
	else {
		shortcut.text01.value = "Error. No item here to edit.";
	}
	if (shortcut.text02.value != "null" || shortcut.text02.value != "undefined") {
		descriptions[currentGroupItemDescNum[2]] = grpForItem + ", " + shortcut.text02.value;
	}
	else {
		shortcut.text02.value = "Error. No item here to edit.";
	}
	if (shortcut.text10.value != "null" || shortcut.text10.value != "undefined") {
		descriptions[currentGroupItemDescNum[3]] = grpForItem + ", " + shortcut.text10.value;
	}
	else {
		shortcut.text10.value = "Error. No item here to edit.";
	}
	if (shortcut.text11.value != "null" || shortcut.text11.value != "undefined") {
		descriptions[currentGroupItemDescNum[4]] = grpForItem + ", " + shortcut.text11.value;
	}
	else {
		shortcut.text11.value = "Error. No item here to edit.";
	}
	if (shortcut.text12.value != "null" || shortcut.text12.value != "undefined") {
		descriptions[currentGroupItemDescNum[5]] = grpForItem + ", " + shortcut.text12.value;
	}
	else {
		shortcut.text12.value = "Error. No item here to edit.";
	}

}

connection.on("receiveUpdatedItemInfo", function (updatedItemInfo) {
    //Parse out the group id and item id and message.
    //Update that item text area with that message. getelementbyid

	alert("Woohoo, I received this updateItem message from server:" + updatedItemInfo);
    
});

connection.on("setGroupLength", function (newLength) {
	length = newLength;
});


$("#newGroupButton").on("click", function () {
	connection.invoke("CreateNewGroup").catch(function (err) {
		return console.error(err.toString());
	})
})


connection.on("createGroup", function () {
	var sel = document.getElementById('mydropdown') // find the drop down
	var length = sel.options.length;
	for (i = length - 1; i >= 0; i--) {
		sel.options[i] = null;
	}

	var i = title.length + 1;
	title[title.length] = "Group" + i;
	listGroups();
});

$('#newItemButton').on("click", function () {
	connection.invoke("CreateNewItem").catch(function (err) {
		return console.error(err.toString());
	});
});

connection.on("createItem", function () {
	var grpForItem = title[shortcut.mydropdown.selectedIndex];

	var i = descriptions.length + 1;
	descriptions[descriptions.length] = grpForItem + ", Item " + i + " description...";

	showtext();
});