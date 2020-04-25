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

//http://www.javascriptkit.com/script/script2/combodescrip1.shtml used to help give us an idea of the boxes for
//the combobox to populating items.
var title = ["Group1", "Group2", "Group3"]; // Possible Values
var shortcut = document.combowithtext;
var descriptions = [];
var currentGroupItems = [];
var currentGroupItemDescNum = [];


function listGroups() {
	var sel = document.getElementById('mydropdown') // find the drop down
	for (var i in title) { // loop through all elements
		var opt = document.createElement("option"); // Create the new element
		opt.value = title[i]; // set the value
		opt.text = title[i]; // set the text
		sel.appendChild(opt); // add it to the select
	}
}

//function addGroup() {
//	var sel = document.getElementById('mydropdown') // find the drop down
//	var length = sel.options.length;
//	for (i = length - 1; i >= 0; i--) {
//		sel.options[i] = null;
//	}

//	var i = title.length + 1;
//	title[title.length] = "Group" + i;
//	listGroups();
//}


function addItem() {
	var grpForItem = title[shortcut.mydropdown.selectedIndex];

	var i = descriptions.length + 1;
	descriptions[descriptions.length] = grpForItem + ", Item " + i + " description...";

	showtext();
}

function showtext() {
	//var currentGroupItems = [];
	var grpForItem = title[shortcut.mydropdown.selectedIndex];

	var i;
	var j = 0;
	for (i = 0; i < descriptions.length; i++) {
		var str = descriptions[i];
		var n = str.indexOf(",");
		var grpNum = str.substr(0, n);
		var rest = str.substr(n + 1);
		if (grpNum == grpForItem) {
			currentGroupItems[j] = rest;
			currentGroupItemDescNum[j] = i;
			j++;
		}

	}
	for (j + 1; j < descriptions.length; j++) {
		currentGroupItems[j] = null;
		currentGroupItemDescNum[j] = null;
	}

	shortcut.text00.value = currentGroupItems[0];
	shortcut.text01.value = currentGroupItems[1];
	shortcut.text02.value = currentGroupItems[2];
	shortcut.text10.value = currentGroupItems[3];
	shortcut.text11.value = currentGroupItems[4];
	shortcut.text12.value = currentGroupItems[5];
}


function updateText(itemId) {
	var grpForItem = title[shortcut.mydropdown.selectedIndex];

	//var groupItem = grpForItem + "," + itemId + "," + shortcut.text00.value;

    //Send to the server. The group id, item id, and the text area content.

	if (itemId == 1) {
	    var groupItem = grpForItem + "," + itemId + "," + shortcut.text00.value;
	}
	else if (itemId == 2) {

		var groupItem = grpForItem + "," + itemId + "," + shortcut.text01.value;
	}
	else if (itemId == 3) {

		var groupItem = grpForItem + "," + itemId + "," + shortcut.text02.value;
	}
	else if (itemId == 4) {

		var groupItem = grpForItem + "," + itemId + "," + shortcut.text10.value;
	}
	else if (itemId == 5) {

		var groupItem = grpForItem + "," + itemId + "," + shortcut.text11.value;
	}
	else if (itemId == 6) {

		var groupItem = grpForItem + "," + itemId + "," + shortcut.text12.value;
	}

	connection.invoke("ItemUpdated", groupItem).catch(function (err) {
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

	var str = updatedItemInfo;
	var n = str.indexOf(",");
	var grpNum = str.substr(0, n);
	var rest = str.substr(n + 1);

	var n1 = rest.indexOf(",");
	var itemId = rest.substr(0, n1);
	var message = rest.substr(n1 + 1);

	document.getElementById(itemId).innerHTML = message;

	alert("Woohoo, I received this updateItem message from server: Group: " + grpNum + " Item Id: " + itemId + " message: " + message);
    
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