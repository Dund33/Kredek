// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var delayMult = 100;
$(document).ready(function () {
    //Drop in all the thumbnails
    $(".meme-thumbnail").hide().each(function (index) {
        $(this).delay(index * delayMult).show("drop");
    });
});
