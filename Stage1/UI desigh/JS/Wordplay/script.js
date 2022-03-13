function wordPlay(number){
    //fill the code
    if(number > 50 ){
    return 'Range is High';
    }
    else if(number < 1){
        return 'Not Valid';
    }
    else if(number>=1 && number<=50){
        
        var i=1;
        var res=" ";
        while (i<=number) {
            if (i%15===0) {
                if(i===number){
                    res+="Jump ";
                }
                else{
                    res+="Jump ";
                }
            }
            else if(i%3===0){
                if(i===number){
                    res+="Tap ";
                }
                else{
                    res+="Tap ";
                }
            }
            else if(i%5===0){
                if(i===number){
                    res+="Clap ";
                }
                else{
                    res+="Clap ";
                }
            }
            else{
                if(i===number){
                    res+=i +" ";
                }
                else{
                    res+=i+ " ";
                }
                
            }
            i++;
        }
       res=res.substring(0,res.length-1);
       return res;
    }
    
}
a = wordPlay(16);
console.log(a);