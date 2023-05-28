// Complete

function multiplication_table(){
    for(var i=1;i <= 10;i+=1){        
        document.write("<br>")
        
        for(var x=1;x <= 10;x+=1){                        
            var y = i+" X "+x+" = ";
            
            if(i === 1){
                document.write("<p>" + y+x*i +"</p>" );                
            }else if(i === 2){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 3){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 4){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 5){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 6){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 7){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 8){
                document.write("<p>" + y+x*i + "</p>");
            }else if(i === 9){
                document.write("<p>" + y+x*i + "</p>");
            }else{
                document.write("<p>" + y+x*i + "</p>");
            }
                
        }
    }
}

multiplication_table();

