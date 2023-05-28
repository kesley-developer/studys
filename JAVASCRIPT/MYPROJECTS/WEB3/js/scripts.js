// Complete

function numbers(){    
        
    var result = [[],[]];
    for(var i=1;i <= 100;i+=1){
        if(i % 2 === 0 ){            
            result[0].push(i);
        }else{
            result[1].push(i);
        }
    }

    console.log("PAIR: ");
    console.log(result[0]);

    console.log("ODD: ");
    console.log(result[1]);
}

numbers();
