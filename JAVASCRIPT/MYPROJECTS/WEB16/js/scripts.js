// Complete

// Function for THEMES in CALCULATOR
function themes(){    
        
    // Element MAIN for style
    let main = document.querySelector("main");

    // Select all INPUT themes & calculator for style
    let themes = document.querySelectorAll(".personalization input")            
    let calculator = document.querySelector(".calculator");
    let btns = document.querySelectorAll(".calculator button");                

    // Functions for themes in calculator 
    function defaultTheme(){        
        calculator.style.background = "#111";        
        for(let i=0; i < btns.length; i+=1){
            if(isNaN(btns[i].textContent) == false || btns[i].textContent == "."){
               btns[i].style.background = "orange";                                                               
            }                        
        }                     
        main.style.background = "linear-gradient(#111,orange)";
        document.querySelector(".calculator").style.border = "10px groove #222";
    }
    defaultTheme();

    function theme1(){
        calculator.style.background = "yellow";        
        for(let i=0; i < btns.length; i+=1){
            if(isNaN(btns[i].textContent) == false || btns[i].textContent == "."){
                btns[i].style.background = "green";
            }
        }                
        main.style.background = "linear-gradient(green,yellow)";        
        document.querySelector(".calculator").style.border = "10px groove rgb(131, 153, 9)";
    }

    function theme2(){
        calculator.style.background = "rgb(10, 23, 97)";        
        for(let i=0; i < btns.length; i+=1){
            if(isNaN(btns[i].textContent) == false || btns[i].textContent == "."){
                btns[i].style.background = "orangered";
            }
        }
        main.style.background = "linear-gradient(orangered,rgb(10,23,97))";        
        document.querySelector(".calculator").style.border = "10px groove rgb(30, 54, 99)";
    }

    function theme3(){
        calculator.style.background = "orange";        
        for(let i=0; i < btns.length; i+=1){
            if(isNaN(btns[i].textContent) == false || btns[i].textContent == "."){
                btns[i].style.background = "#111";
            }
        }
        main.style.background = "linear-gradient(blue,orange)";
        document.querySelector(".calculator").style.border = "10px groove rgb(201, 150, 0)";
    }

    for(let i=0; i < themes.length; i+=1){        
                
        themes[i].style.cursor = "pointer";
        themes[i].addEventListener("click",function(){
            
            // CHECKED INPUTS
            if(themes[0].checked == true){
                defaultTheme();
            
            }else if(themes[1].checked == true){
                theme1();
            
            }else if(themes[2].checked == true){
                theme2();
            
            }else if(themes[3].checked == true){
                theme3();
            }
        })
    }
}
themes();

// Function for EVENTS in CALCULATOR
function events(){
        
    // Select all BUTTONS & INPUT
    let btns = document.querySelectorAll("button");    
    let input = document.querySelector(".calculator input");                        

    for(let i=0; i < btns.length; i+=1){                                    

        // THEME in operator BUTTONS
        if(btns[i].id == "operator"){
            btns[i].style.background = "rgb(55, 156, 63)";
        }

        // Event in ALL BUTTONS
        btns[i].addEventListener("click",function(){                                    

            // Button NUMERIC
            if(isNaN(btns[i].textContent) == false || btns[i].textContent == "."){
                input.value += this.textContent;                              
            
            // Buttons NOT NUMERIC
            }else{                                                

                // DELETE
                if(btns[i].textContent == "DEL"){
                    let size = input.value.length;                    
                    input.value = input.value.slice(0,size - 1);
                
                // CLEAR
                }else if(btns[i].textContent == "CLEAR"){                    
                    input.value = "";
                
                // PARENTHESES(open) 
                }else if(btns[i].textContent == "("){                    
                    input.value += "(";

                // PARENTHESES(close)
                }else if(btns[i].textContent == ")"){
                    input.value += ")";

                // SUM                 
                }else if(btns[i].textContent == "+"){
                    input.value += "+";                    
                
                // SUBTRACTION  
                }else if(btns[i].textContent == "-"){
                    input.value += "-";                    
                
                // MULTIPLICATION                
                }else if(btns[i].textContent == "x"){                    
                    input.value += "*";                    
                
                // DIVISION
                }else if(btns[i].textContent == "÷"){                    
                    input.value += "/";
                    
                // RESULT
                }else if(btns[i].textContent == "="){                                                                                
                                                                                
                    // Error Manipulation & Result operation in INPUT                                        
                    try{                        
                        if(input.value == ""){
                            return                        

                        }else{
                            input.value = eval(input.value);
                            input.animate([
                                {background: "rgb(17, 73, 29)"},{background: "rgb(15, 44, 7)"}
                            ],{
                                duration: 1000
                            })
                        }
                    }
                    catch{
                        input.animate([
                            {background: "rgb(168,8,8)"},{background: "rgb(15, 44, 7)"}                            
                        ],{
                            duration: 1000                            
                        })
                    }
                }
            }           
        })        
    }    
}
events();