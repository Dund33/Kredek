//Some data
var keybuf=[0,0,0,0,0,0,0,0,0,0];
var konami=[38, 38, 40, 40, 37, 39, 37, 39, 66, 65];

$(document).ready(function () {
    fancyEntry(500);
//bind events for dynamic table update
    $("#body").bind("keyup", function(evt){
        keybuf.shift();
        keybuf.push(evt.which);
        doKonami();
    })
});

//Konami :)
function doKonami(){
    for(var i=0;i<10;i++){
        if(keybuf[i]!=konami[i]) return;
    }
    $("#jozin").removeClass("transparent-czech");
    $("#jozin").removeClass("transparent-polish");
    $("#jozin").addClass("rainbow-text");
    console.log("konami");
}

//Fade in everything
function fancyEntry(time){
    $(".container").fadeIn(time);
}

