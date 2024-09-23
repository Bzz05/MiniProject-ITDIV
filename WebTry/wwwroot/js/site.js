// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function openPopup() {
    var popup = document.getElementById("popup");
    popup.style.display = "flex";
}

function closePopup() {
    var popup = document.getElementById("popup");
    popup.style.display = "none";
}

function openPopup1() {
    var popup = document.getElementById("popup1");
    popup.style.display = "flex";
}

function closePopup1() {
    var popup = document.getElementById("popup1");
    popup.style.display = "none";
}

function openPopup2() {
    var popup = document.getElementById("popup2");
    popup.style.display = "flex";
}

function closePopup2() {
    var popup = document.getElementById("popup2");
    popup.style.display = "none";
}

function refreshPage() {
    location.reload();
}

var hoverArea = document.getElementsByClassName('rotate-container');
var dropdown = document.getElementsByClassName('dropdown');

hoverArea.addEventListener('mouseenter', function () {
    dropdown.style.display = 'block';
});

hoverArea.addEventListener('click', function () {
    dropdown.style.display = 'block';
});

function refreshPage() {
    location.reload();
}