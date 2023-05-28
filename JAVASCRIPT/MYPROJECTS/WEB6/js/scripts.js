// Complete

function peoples(x=[],y=[]){
    const names=[["Kesley","Men",20],["Marco","Men",19],["John","Men",45],
                ["Mary","Woman",32],["Isabella","Woman",18],["Beatriz","Woman",16]];
    
    for(let i=0;i < names.length;i+=1){
        document.write("<p>"+"Name: "+names[i][0]+"</p>");
        document.write("<p>"+"Sex: "+names[i][1]+"</p>");
        document.write("<p>"+"Age: "+names[i][2]+"</p>");
        document.write("<p>"+"___________________"+"</p>");
        
        if(i===0){
            x.push(names[i][2]); y.push(names[i][2]);
        }else{
            
            // Maior
            if(names[i][2] > x){
                x.pop(-1);          // Eliminando o ultimo elemento do array X
                x.push(names[i][2]);
            
            // Menor
            }else if(names[i][2] < y){
                y.pop(-1);          // Eliminando o ultimo elemento do array Y
                y.push(names[i][2]);
            }
        }
    }
    document.write("<p>"+"BIGGER AGE IN LIST: " + x[0]+"</p>");
    document.write("<p>"+"SMALLER AGE IN LIST: " + y[0]+"</p>");            
}
peoples();
