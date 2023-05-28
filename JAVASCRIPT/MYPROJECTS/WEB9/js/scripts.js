// Complete

// Selecionando body
var body = document.querySelector("body");

// Função para selecionar botões
function myEvent(){    
    const btn_green = document.querySelector("#btn-green");
    const btn_red = document.querySelector("#btn-red");
    const btn_blue = document.querySelector("#btn-blue");          

    // Função para o evento
    function eventsBtn(){        
        
        btn_green.addEventListener("click",function(){
            body.style.cssText = "background-color: green;";
            console.log("Color: GREEN");
        });

        btn_red.addEventListener("click",function(){
            body.style.cssText = "background-color: red;";
            console.log("Color: RED");
        });

        btn_blue.addEventListener("click",function(){
            body.style.cssText = "background-color: blue;";
            console.log("Color: BLUE");
        });
    }    
    eventsBtn();
}
myEvent();






