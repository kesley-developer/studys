// Operadores lógicos

// &&(and)

var name = "kesley";
var age = 18

if(name == "kesley" && age == 18){ // Caso a váriavel name e age tenham os valores passados
    console.log("Autorized!");    
}

else{  // Caso qualquer ou todas as variáveis não tiverem as instrução passada
    console.log("Not autorized!")
}

// ||(or)

var number = 20;
var user = "John";

if(number == 20 || user == "John"){ // Caso a variável number ou user tenham os valores passados
    console.log("Autorized!");    
}

else{ // Caso nenhuma das duas variáveis tiverem as instruções passadas       
    console.log("Not autorized!");
}

// !(not)

var your_name = "Maicon";

// Colocamos a comparação entre parênteses "()"
if(!(your_name == "Maicon")){ // A situação será transformada em false caso true
    console.log("Autorized!");
}

else{
    console.log("Not autorized!");
}

if(!false){ // Invertendo o valor da expressão, se false retornará true
    console.log("Autorized!");
}