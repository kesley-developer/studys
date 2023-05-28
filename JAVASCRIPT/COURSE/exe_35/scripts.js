
// onload
window.onload = function(){ // Passando evento onload através de uma função
    console.log("Page loaded! 0");
};
console.log("Page loaded! 1");

// click
var button = document.querySelector("#my-button"); // Selecionando elemento

// Modo de adicionar um evento 
button.addEventListener('click',function(){ // Passando parâmetro CLICK e uma função
    console.log("Thank you");

    // Alterando a propriedade color
    this.style.color = "red"; // THIS se refere a isso ou seja, a variável passada BUTTON    
});

// dblclick
var other_button = document.querySelector("#other-button");

other_button.addEventListener('dblclick',function(){
    console.log("OK! double click!");

    this.style.color = "blue";
});

// mouseover
var btn = document.querySelector("#btn");

btn.addEventListener('mouseover',function(){
    console.log("Thank you");

    this.style.cssText = "Background-color: red;";
});

// mouseout
var other_btn = document.querySelector("#other-btn");

other_btn.addEventListener("mouseout",function(){
    console.log("OK! Active!");

    this.style.cssText = "Background-color: yellow;";
});

// keydown
document.addEventListener("keydown",function(event){ // Passando função para mapear evento como parâmetro
    
    console.log(event.key); // Aplicando a função EVENT e propriedade KEY

    // Validando uma determinada tecla caso verdadeira
    if(event.key === "Enter"){
        console.log("This key is ENTER!");
    }
});

// keyup
document.addEventListener("keyup",function(event){
    
    if(event.key === "Enter"){
        console.log("You pressed ENTER!");
    }
});