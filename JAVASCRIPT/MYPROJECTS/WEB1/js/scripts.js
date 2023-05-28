// Complete

function multiplication_table(){
    for(var i=1;i <= 10;i+=1){
        for(var x=1;x <= 10;x+=1){
            num = i + " X " + x + " = ";            
            if(i === 1){
                console.log(num + x*1);                                
            }else if(i === 2){
                console.log(num + x*2);
            }else if(i === 3){
                console.log(num + x*3);
            }else if(i === 4){
                console.log(num + x*4);
            }else if(i === 5){
                console.log(num + x*5);
            }else if(i === 6){
                console.log(num + x*6);
            }else if(i === 7){
                console.log(num + x*7);
            }else if(i === 8){
                console.log(num + x*8);
            }else if(i === 9){
                console.log(num + x*9);
            }else if(i === 10){
                console.log(num + x*10);
            }
        }
    }
}

multiplication_table();