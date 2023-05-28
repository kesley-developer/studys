// Complete

function eventMath(){
    
    // Select values in INPUTS 
    var value0 = document.querySelector("#value0");
    var value1 = document.querySelector("#value1");                

    // Select options in BUTTONS    
    var btnOptions = document.querySelectorAll("button");            

    // Select INPUT for result
    var inputResult = document.querySelector("#result");

    for(let i=0; i < btnOptions.length; i+=1){                                        
        
        btnOptions[i].addEventListener("click",function(){
            
            // If no values in INPUT
            if(value0.value == "" || value1.value == ""){                
                inputResult.value = "";
                inputResult.style.background = "#fff";
                window.alert("INFORME OS VALORES CORRETAMENTE!");
            }

            // Operations 
            else{                
                if(btnOptions[i].textContent == "Somar +"){ 
                    inputResult.value = parseInt(value0.value) + parseInt(value1.value);                
                
                }else if(btnOptions[i].textContent == "Subtrair -"){
                    inputResult.value = parseInt(value0.value) - parseInt(value1.value);                                    
                
                }else if(btnOptions[i].textContent == "Multiplicar x"){
                    inputResult.value = parseInt(value0.value) * parseInt(value1.value);                
                
                }else if(btnOptions[i].textContent == "Dividir ÷"){
                    inputResult.value = parseInt(value0.value) / parseInt(value1.value);
                }                
                
                inputResult.style.background = "orangered";
            }                        
        })                
    }    
}
eventMath();