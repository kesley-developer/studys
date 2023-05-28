// Operadores de comparação

var number = 10; // Variável para usar como comparação nas condições

if(number == 10){ // Se a variável number for igual a 10
    console.log("Is true");
}

if(number != 5){ // Se a variável number for diferente de 5
    console.log("Is true");
}

if(number > 6){ // Se a variável number for maior que 6
    console.log("Is true");
}

if(number < 11){ // Se a variável number for menor que 11
    console.log("Is true")
}

if(number >= 9){ // Se a variável number for maior ou igual a 9
    console.log("Is true")
}

if(number <= 4){ // Se a variável number for menor ou igual a 4
    console.log("Is true")
}

// O número 0 é considerado false(falso) no JS, portanto a condição não será executada
var number_zero = 0
if(number_zero){
    console.log("Is true")
}