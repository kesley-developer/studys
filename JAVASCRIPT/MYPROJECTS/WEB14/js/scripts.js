// Complete

// Function for generate numbers in PAGE & MORE
function allEvents(){

    // Select element ID for insert all
    var content = document.querySelector("#content");        
    console.log(content);

    // DIV for insert numbers in BUTTON
    var divNumbers = document.createElement("div");
    divNumbers.setAttribute("class","BTN-NUMBERS");            
    divNumbers.style.cssText = "padding: 5px 5px 5px 5px;";
    
    content.appendChild(divNumbers);    

    // Create element DIV for insert numbers
    var div0 = document.createElement("div"); // NUMS 1-10
    div0.setAttribute("class","NUMBERS 1-10"); 
    divNumbers.appendChild(div0);

    var div1 = document.createElement("div"); // NUMS 11-20
    div1.setAttribute("class","NUMBERS 11-20"); 
    divNumbers.appendChild(div1);

    var div2 = document.createElement("div"); // NUMS 21-30
    div2.setAttribute("class","NUMS 21-30"); 
    divNumbers.appendChild(div2);

    var div3 = document.createElement("div"); // NUMS 31-40
    div3.setAttribute("class","NUMS 31-40")
    divNumbers.appendChild(div3);

    var div4 = document.createElement("div"); // NUMS 41-50
    div4.setAttribute("class","NUMS 41-50");
    divNumbers.appendChild(div4);

    var div5 = document.createElement("div"); // NUMS 51-60
    div5.setAttribute("class","NUMS 51-60");
    divNumbers.appendChild(div5);    

    // Generate NUMBERS and BUTTONS 1-60 for insert in DIVS
    for(let i=1; i <= 60; i+=1){            
        
        if(i >= 1 && i <= 10){            
            let btns0 = document.createElement("button");                
            btns0.textContent = i;
            div0.appendChild(btns0);
        
        }else if(i >= 11 && i <= 20){            
            let btns1 = document.createElement("button");
            btns1.textContent = i;
            div1.appendChild(btns1);
        
        }else if(i >= 21 && i <= 30){            
            let btns2 = document.createElement("button");
            btns2.textContent = i;
            div2.appendChild(btns2);        
        
        }else if(i >= 31 && i <= 40){
            let btns3 = document.createElement("button");
            btns3.textContent = i;
            div3.appendChild(btns3);
        
        }else if(i >= 41 && i <= 50){
            let btns4 = document.createElement("button");
            btns4.textContent = i;
            div4.appendChild(btns4);
        
        }else{
            let btns5 = document.createElement("button");
            btns5.textContent = i;
            div5.appendChild(btns5);
        }
    }    
    
    // Event for BUTTONS    
    function btnEvents(){                
        var allBtns = document.querySelectorAll("button"); // Select BUTTONS           
        var valuesUser = [];  // ARRAY for insert numbers in BUTTONS                        

        var h3 = document.createElement("h3"); // Element for insert ARRAY                                    
        h3.style.cssText = "background: green; color: #fff; border-radius: 10px; display: inline-block; padding: 5px;";                
        h3.textContent = "FAÇA SUA APOSTA";
        divNumbers.appendChild(h3);                

        for(let i=0; i < allBtns.length; i += 1){
            allBtns[i].style.cssText = "background: #fff; font: 12px bold; color: red; width: 35px; height: 30px; cursor: pointer; border: transparent; border-left: 1px solid red; border-right: 1px solid red; margin: 2px;";        
                                    
            // Event CLICK
            allBtns[i].addEventListener("click",function(){                                                                                                                          

                // Disabled BUTTON & STYLES
                allBtns[i].disabled = true;                
                allBtns[i].style.background = "green";                
                allBtns[i].style.border = "2px groove #fff";
                allBtns[i].style.color = "#fff";
                allBtns[i].style.cursor = "default";                                                
                
                // Insert values in element H3 & ARRAY
                valuesUser.push(parseInt(allBtns[i].textContent));                
                h3.textContent = valuesUser;                
                console.log(valuesUser);                              

                // Limited CHOICES = 6 numbers
                if(valuesUser.length == 6){                                                            

                    // Disabled all BUTTONS
                    for(let i=0; i < allBtns.length; i += 1){                                                
                        allBtns[i].disabled = true; 
                        allBtns[i].style.cursor = "default";                                                                                                   
                    }                    

                    // Confirmate values
                    let p = document.createElement("p");
                    p.textContent = "Confirmar aposta?";
                    divNumbers.appendChild(p);

                    // Button YES
                    let btnYes = document.createElement("button");
                    btnYes.textContent = "SIM";                    
                    btnYes.style.cssText = "background: green; border: transparent; color: #fff; cursor: pointer;";
                    divNumbers.appendChild(btnYes);                                        

                    // Event CLICK in button YES
                    btnYes.addEventListener("click",function(){                                                
                        
                        // Remove elements & Disabled DISPLAY all content
                        content.style.display = "none";                 
                        document.querySelector("#footer").style.display = "none";                         
                        btnYes.remove();
                        btnNo.remove();

                        // Create new DIVS & ELEMENTS for result
                        let p_userValues = document.createElement("p");                                                
                        p_userValues.textContent = "Sua aposta";

                        p.textContent = "Sorteando números...";
                        h3.textContent = valuesUser;
                        h3.style.background = "orange";
                        
                        let newDiv = document.createElement("div");                                                                                                                                                
                        let img = document.createElement("img");
                        img.setAttribute("src","../imgs/logo.jpg","alt","mega sena logo");
                        img.style.cssText = "width: 400px; height: 120px;";
                        let h1 = document.createElement("h1");                        
                        newDiv.style.cssText = "background: green; color: #fff; padding-bottom: 10px;";
                        newDiv.appendChild(img);
                        newDiv.appendChild(p_userValues);
                        newDiv.appendChild(h3);
                        newDiv.appendChild(p);
                        newDiv.appendChild(h1);                                                
                        
                        let section = document.querySelector("section");                        
                        section.style.cssText = "margin-top: 5%; border: 5px double #fff;";
                        section.appendChild(newDiv);

                        // Generate CPU values                        
                        var hitsUser = 0; 
                        var valuesCpu = [];                                                
                        var generateNums = setInterval(function(){                                                                                                                                                                        
                                                        
                            // Conditions for no-repeat numbers
                            var num = Math.floor(Math.random() * 60 + 1);                                                                                                                
                            if(valuesCpu.includes(num) == true){                              
                                return;
                            }
                            
                            // Insert values in ARRAY
                            else{                                
                                valuesCpu.push(num);                                
                                h1.textContent = valuesCpu;
                                console.log(valuesCpu);                                
                                                                
                                // Condition if CPU numbers in USER numbers
                                if(valuesUser.includes(num) == true){
                                    
                                    // Animate H1 - COLOR
                                    h1.animate([
                                        {color: "orange"},
                                        {color: "#fff"}
                                    ],{
                                        duration: 1000                                        
                                    })

                                    // Include +1 in HITS user
                                    hitsUser += 1;
                                }
                            }
                            
                            // Finalize GENERATION
                            if(valuesCpu.length == 6){                                                                                                
                                p.textContent = "Números sorteados";

                                // Element for RESULT
                                let h4 = document.createElement("h4");
                                let p_result = document.createElement("p");                                
                                h4.style.cssText = "color: orange;font-size: 15px;";
                                newDiv.appendChild(h4);
                                newDiv.appendChild(p_result);

                                if(hitsUser == 4){
                                    h4.textContent = "VOCÊ ACERTOU 4 NÚMEROS";
                                    p_result.textContent = "PARABÉNS VOCÊ ACABA DE GANHAR R$1.000,00";
                                    
                                }else if(hitsUser == 5){
                                    h4.textContent = "VOCÊ ACERTOU 5 NÚMEROS";
                                    p_result.textContent = "PARABÉNS VOCÊ ACABA DE GANHAR R$10.000,00";
                                
                                }else if(hitsUser == 6){
                                    h4.textContent = "VOCÊ ACERTOU 6 NÚMEROS";
                                    p_result.textContent = "PARABÉNS VOCÊ ACABA DE GANHAR R$1.000.000,00"
                                
                                }else{
                                    h4.textContent = "NÃO FOI DESSA VEZ!";                                    
                                    p_result.textContent = "BOA SORTE NA PRÓXIMA";
                                }
                                
                                // BUTTON for back
                                let btnBack = document.createElement("button");                            
                                btnBack.textContent = "NOVA APOSTA";
                                btnBack.style.cssText = "background: #fff; color: #111; cursor: pointer; padding: 5px; border: 2px groove #fff ;border-radius: 10px;";
                                newDiv.appendChild(btnBack);
                                
                                // Event MOUSEROVER
                                btnBack.addEventListener("mouseover",function(){
                                    this.style.background = "orange";                                    
                                    this.style.color = "#fff";
                                })                                                                                                                             
                                
                                // Event MOUSEOUT
                                btnBack.addEventListener("mouseout",function(){
                                    this.style.background = "#fff";
                                    this.style.color = "#111";
                                })

                                // Event CLICK
                                btnBack.addEventListener("click",function(){
                                    
                                    // RELOAD page
                                    window.location.reload(true);
                                })
                                
                                clearInterval(generateNums);                                                                
                            }
                        },1000)                                                                                                
                    })

                    // Button NO
                    let btnNo = document.createElement("button");                    
                    btnNo.textContent = "NÃO";
                    btnNo.style.cssText = "background: red; border: transparent; color: #fff; cursor: pointer;";
                    divNumbers.appendChild(btnNo);

                    // Event CLICK in button NO
                    btnNo.addEventListener("click",function(){
                        
                        // Remove elements
                        h3.textContent = "FAÇA SUA APOSTA";
                        p.remove();
                        btnYes.remove();
                        btnNo.remove();                        

                        valuesUser = [];
                        
                        // Enabled all BUTTONS
                        for(let i=0; i < allBtns.length; i += 1){
                            allBtns[i].disabled = false;
                            allBtns[i].style.cssText = "background: #fff; font: 12px bold; color: red; width: 35px; height: 30px; cursor: pointer; border: transparent; border-left: 1px solid red; border-right: 1px solid red; margin: 2px;";        
                        }
                    })
                    
                }                
            })                                                  
        }                                     
    }            
    btnEvents();
}    
allEvents();