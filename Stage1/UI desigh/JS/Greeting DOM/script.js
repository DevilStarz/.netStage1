function display(){
    var name = document.getElementById("sname").value;
    var course = document.getElementById("course").value;
    if(name.length!==0){
        document.getElementById("greet").innerHTML="<p>Hi,"+name+". You have successfully registered for the "+course+" course.</p>";
    }
    else{
        document.getElementById("greet").innerHTML="<p>Name cannot be empty</p>";
    }
}