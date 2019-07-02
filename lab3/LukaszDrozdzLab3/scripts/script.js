 
 
 //THEM TRYIN' BOYZ
 var tries = 5;
 //Reaction times
 var reactionTime = [];
 
 //Beginning of the test
 var timeBegin = 0;

 //End of the test
 var timeEnd = 0;

 var trialCounter = 0;

 var randomTimer = 0;

 function ResetTimes(){
     for(var i=0;i<tries;i++){
         reactionTime[i]=0;
     }
 }

 //Rozpoczecie odliczania
 function StartIdle(){
    document.getElementById("button").src = "Images/buttonBlue.png";
    document.getElementById("button").onclick = function(){FalseStart();};
    if(trialCounter>tries-1){
        ResetTimes();
        trialCounter = 0;
        UpdateTable(0);
    }
    trialCounter++;
    randomTimer = Math.floor(Math.random()*1000+500);
    setTimeout(StartTimer, randomTimer);
 }

function StartTimer(){
    document.getElementById("button").src = "Images/buttonGreen.png";
    document.getElementById("button").onclick = function() {
        StopTimer();
    };
    timeBegin = new Date().getTime();
}

//HAALT
function StopTimer(){
    document.getElementById("button").src = "Images/buttonRed.png";
    document.getElementById("button").onclick = function(){
        StartIdle();
    }

    var average = 0;
    trialEnd = new Date().getTime() - timeBegin;
    reactionTime[trialCounter-1] = trialEnd;
    UpdateTable(average);

    if(trialCounter > tries - 1){
        for(var i=0;i<tries;i++){
            average += reactionTime[i];
        }
        average = Math.round(average/tries);
        UpdateTable(average);
        alert("Your average was: " + average + "ms");
    }

}

//Too soon buddy
function FalseStart(){
    trialStart = new Date().getTime() - 1000;
    StopTimer();
}

//Refresh da teiburu
function UpdateTable(average){
    elem = document.getElementById("damnedThing1");

    elem.style = "color:red;";

    elem = document.getElementById("damnedThing2");

    if(elem != null){
        document.getElementById("damnedThing2").id="damnedThing1";
    }
    document.getElementById("resultsTable").innerHTML = "";
    document.getElementById("resultsTable").innerHTML+=
    '<tr>'+
    '<th>Attempt No. </th>'+
    '<th>Reaction time</th>'+
    '</tr>';

    

    for(var i=0;i<tries;i++){
        document.getElementById("resultsTable").innerHTML+=
        '<tr>'+
        '<td> Attempt' + (i+1) +'</td>'+
        '<td>'+
        reactionTime[i]+
        'ms </td>'+
        '</td>';
    }

    document.getElementById("resultsTable").innerHTML += 
    '<tr>' +
    '<td> Average </td>'+
    '<td>'+average+' ms</td>'+
    '</tr>';
}