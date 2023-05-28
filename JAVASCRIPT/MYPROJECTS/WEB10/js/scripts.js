// Complete

// Acessando local para inserir digito da tecla
const acess = document.querySelector("#key h2");

// Evento de tecla pressionada
document.addEventListener("keydown",function(event){
    
    if(event.key === " "){
        acess.textContent = "Space";
    }else{
        acess.textContent = event.key;
    }
});

// Evento de tecla solta
document.addEventListener("keyup",function(event){
    acess.textContent = "";
});

