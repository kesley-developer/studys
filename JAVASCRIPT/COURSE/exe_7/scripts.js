// Operadores condicionais

// if
console.log("Testing if")

if(true){ // Criando a condicional
    
    console.log("Hello World!");
    console.log("Conditional IF is true");
}

/* 
*  O código da condicional será executado entre as chaves "{}",
*  e entre as barras "()" será informada a instrução, caso for
*  true(verdadeira) a condicional será executada
*/

var my_age = 20;   
if(my_age >= 20){  // Se a variável my_age for maior ou igual a 20, o bloco será executado
    console.log("Aprovado");
}

// else if
console.log("testing else if")

var my_name = "kesley"; // Variável que será usada para comparação
if(my_name == "kesley"){ // Se a variável my_name tiver o valor "kesley" este bloco será executado
    console.log("Your name is kesley!");
}

else if(my_name != "kesley"){ // Caso o if não for válido, e o else if for verdadeiro este bloco será executado
    console.log("Your name not is kesley!");
}

// else
console.log("testing else");

var number = 10;
if(number == 8){
    console.log("Your number is 8");
}

else if(number == 9){
    console.log("Your number is 9");
}

else{
    console.log("Your number not is 8 or 9!")
}


