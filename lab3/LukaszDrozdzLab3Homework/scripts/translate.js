
//Setup
$(document).ready(function () {
   
    //Listen for user typing
    $("#search").bind('change paste keyup', function(){
        var words = translate();
        display(words);
    });

    //Listen for mode selection change
    $("#mode").change(function (e) { 
        e.preventDefault();
        var words = translate();
        display(words);
    });

    var words = translate();
    display(words);
});


//Longest common substring
function LCS(a, b) {
    var longer = a.length>b.length ? a:b;
    var shorter = a.length>b.length ? b:a;
    var longestSubstring = 0;
    var j = 0;
   for(var i=0;i<longer.length;i++){
        j=0;
        for(;j<shorter.length&&longer[i+j]==shorter[j];j++);
        longestSubstring = j>longestSubstring ? j:longestSubstring;
   }
   return longestSubstring;
}

//Alphabetical comparison
function ALP(a,b){

    if(a==b) return 0;

    var len = a.length>b.length ? b.length : a.length;

    for(var i=0;i<len;i++){
        if(a[i]>b[i]) return 1;
        if(a[i]<b[i]) return -1;
    }

    if(a.length>b.length)return 1;
    else return -1;
}

//Read user input and present him with data
function translate(){
    
    var translations = {};

    var selectedOption = $("#mode").val();

    //Load translation from a JSON file
    if(selectedOption=="0"){
        translations = JSON.parse(translationsCzechJSON);
    }else{
        translations = JSON.parse(translationsPolishJSON);
    }

    //Get user input
    var userInput = $("#search").val();

    //Add words to a list
    var words = [];
    for(var word in translations){
        words.push(word);
    }

    //Sort the words using anonymous function
    words.sort(function(a,b){
        if(LCS(userInput,a)>LCS(userInput,b)) return -1;
        if(LCS(userInput,b)>LCS(userInput,a)) return 1;
        else return ALP(a,b);
    });

    var translatedArray = new Array(words.length);

    //Build a 2D array holding a sorted list of words along with their translations
    for(var i=0;i<words.length;i++){
        var tmp = new Array(2);
        tmp[0] = words[i];
        tmp[1] = translations[words[i]];
        translatedArray[i]=tmp;
    }
    return translatedArray;
}

//Display the data
function display(words){
    var selectedOption = $("#mode").val();
    var polishStyle = 'url("images/poland.png") no-repeat';
    var czechStyle = 'url("images/czech-republic.png") no-repeat';

    //Change the background accordingly
    if(selectedOption=="0"){
        $("#l1").html("Czech");
        $("#l2").html("Polish");
        $("#body").css('background-image', czechStyle);
        //Change the texture of the text
        $("#jozin").removeClass("transparent-polish");
        $("#jozin").addClass("transparent-czech");
    }else{
        $("#l1").html("Polish");
        $("#l2").html("Czech");
        //Change the texture of the text
        $("#body").css('background-image', polishStyle);
        $("#jozin").removeClass("transparent-czech");
        $("#jozin").addClass("transparent-polish");
    }

    //Build new content for the table
    var content = '';
    for(var i=0;i<words.length;i++){
        content+='<tr>';
        content+='<td>'+words[i][0]+'</td>';
        content+='<td>'+words[i][1]+'</td>';
        content+='</tr>';
    }

    //Actually display the result
    $('#results').html(content);
}