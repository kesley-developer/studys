
// clearTimeout
var x = 0;      // Criando variável

var my_timer = setTimeout(function(){ // Encapsulando setTimeout dentro de uma variável
    console.log("Hello World!");
},1000)

x = 4; // Alterando valor da variável criada

if(x > 0){ // Caso a variável X for maior que 0
    
    clearTimeout(my_timer); // Aplicando método
    console.log("Stopping setTimeout!")
}

// clearInterval
var my_interval = setInterval(function(){
    console.log("Bye World!");
},1000);

setTimeout(function(){
    clearInterval(my_interval); // Aplicando método
    console.log("Stopping setInterval!");    

},3000) // Quando setInterval atingir 3 segundos

/*
*  Precisamos encapsular ou seja, adicionar
*  dentro de uma variável para aplicar os
*  os métodos clearTimeout e clearInterval
*/