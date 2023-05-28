// Complete

// Function for EVENTS
function eventIMC(){        

    // Select ELEMENTS for div RESULT
    let resultDiv = document.querySelector(".result");
    let btn = document.querySelector("#btn-confirm");
    
    // Select all INPUTS & LI
    let allInputs = document.querySelectorAll("input");                    
    let li = document.querySelectorAll("li");        
    
    // Event press ENTER in INPUTS
    for(let i=0; i < allInputs.length; i+=1){
        allInputs[i].addEventListener("keydown",function(event){
            if(event.key == "Enter"){
                btn.focus();
            }
        })
    }

    // Event in WEIGHT - Validate MAX DIGITS
    allInputs[1].addEventListener("keydown",function(){
        if(this.value.length > 5){
            this.value = "";
        }
    })

    // Event in HEIGHT - Validate MAX DIGITS
    allInputs[2].addEventListener("keydown",function(){
        if(this.value.length > 5){
            this.value = "";
        }
    })

    // Function for calculate IMC
    function imc(weight=allInputs[1].value,height=allInputs[2].value){                
        
        // IMC
        let calculateIMC = weight / (height * height);
        allInputs[3].value = calculateIMC.toFixed(2);

        // Condition IMC
        if(calculateIMC < 18.50){            
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";                                
            }
            li[0].style.color = "orange";                                   
        
        }else if(calculateIMC <= 24.99){        
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";
            }
            li[3].style.color = "orange";            
        
        }else if(calculateIMC <= 29.99){
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";
            }
            li[4].style.color = "orange";        
        
        }else if(calculateIMC <= 34.99){
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";
            }
            li[5].style.color = "orange";                        

        }else if(calculateIMC <= 39.99){
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";
            }
            li[6].style.color = "orange";            
        
        }else if(calculateIMC >= 40){
            for(let i=0; i < li.length; i+=1){
                li[i].style.color = "#fff";
            }
            li[7].style.color = "orange";            
        }                                  
        
        // Remove values in INPUTS 
        for(let i=0; i < allInputs.length - 1; i+=1){
            allInputs[i].value = "";
        }

        // SCROLL in page
        window.scroll({
            top: 100,            
            behavior: "smooth"
        })
    }        
    
    // BUTTON event
    btn.addEventListener("click",function(){
        
        // Validate NAME
        if(allInputs[0].value == "" || isNaN(allInputs[0].value) == false){                                                
            window.alert("Preencha o nome corretamente!");               
            allInputs[0].value = "";
        }            

        // Validate WEIGHT & HEIGHT
        else if(allInputs[1].value == 0 || allInputs[2].value == 0){
            window.alert("Insira o peso e altura!");
        }

        // Result IMC
        else{
            imc()
            
            // Animation DIV result IMC
            resultDiv.animate([

                {opacity: "0"},{opacity: "100%"}
            ],{
                duration: 1000
            })
            resultDiv.style.opacity = "100%";                        
        }
    })
}
eventIMC();
