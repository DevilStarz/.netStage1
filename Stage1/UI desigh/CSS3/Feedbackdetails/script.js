var counter = 1;
const array= [];
function addFeedback()
{
    var text = document.getElementById("feedback");
    array[counter] = text.value;
    counter++;
    document.getElementById("result").innerHTML = "<h1>Feedback Details</h1><h4>Sucessfully Added Feedback Details!</h4>";
    document.getElementById('feedback').value='';
}

function displayFeedback()
{
    var msgCounter = "<h1>Feedback Details</h1>";
    for(var i=1; i < array.length; i++)
    {
        msgCounter+= "Feedback " + i + "<br>" + array[i] + "<br/>";
    }
    document.getElementById("result").innerHTML = msgCounter;
}