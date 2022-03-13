function modifyString(str) 
{
    var newStr = "";
    str = str.split(" ").join("");
    for(var i = 0; i < str.length; i++) {
        var code = str.charCodeAt(i);
        if(code >= 65 && code <= 90) {
            code += 32;
        } newStr += String.fromCharCode(code);
    } 
    return newStr;
}

function uniqueCharacters(str)
{
    var newStr=modifyString(str);
    var result="";
    for(var i=0;i<newStr.length;i++)
    {
        var f=0;
        for(var j=0;j<i;j++)
        {
           if(newStr[i]==newStr[j])
           {
              f=1;
              break;
           }
        }
        if(f!=1)
        {
            result = result+newStr[i];
        }
        
    }
    return result;

}
