// Complete

function peoples(x=0,y=0){            
    var arr=[["KESLEY","JOHN","MARCO","MARY","BEATRIZ","GISELE"],            
            [20,42,30,18,20,16],
            ["MALE","MALE","MALE","FEMALE","FEMALE","FEMALE"]
            ];
    
    for(var i=0;i < arr[0].length;i+=1){
        if(arr[1][i] >= 18){
            x += 1;
        }else{
            y += 1;
        }
        console.log("NAME: "+ arr[0][i]);
        console.log("AGE: " + arr[1][i]);
        console.log("SEX: " + arr[2][i]);        
        console.log("-----------------");
    }
    console.log("+18 TOTAL: " + x);
    console.log("-18 TOTAL: " + y);
}

peoples();