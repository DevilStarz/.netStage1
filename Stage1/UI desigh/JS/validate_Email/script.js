function validateEmail(email) {
    //var mailPattern = 
    
    
    var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z-]+(?:\.[a-zA-Z-]+)*$/;
 
   if (email.match(validRegex)) {
 
     return ("Valid email address!");
 
   } else {
 
     return ("Invalid email address!");
    
 }
 }
 
 