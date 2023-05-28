// Estruturas de repetição

// while
console.log("count from 0 - 10: ");
var number = 0;
while(number <= 10){ // Enquanto a variável number for menor e igual a 10
    console.log("This is number = " + number);
    
    // Incrementador, adicionando +1 a cada loop
    number+=1;
}

console.log("letters in my name: ")
var my_name = "KESLEY";
var count = 0;
while(count <= 5){
    console.log(my_name[count]);

    count+=1;
}

/* 
*  Quando a estrutura não estiver mais sob a instrução passada,
*  o loop irá se encerrar
*/ 

// for
console.log("count to 10 in 1 - 1: "); 
for(var num0=0; num0 <= 10; num0+=1){ // Quando a variável num0 atingir o valor 10 o loop encerrará
    console.log(num0);             
}

console.log("count to 20 in 2 - 2: ");
for(var num1=0; num1 <= 20; num1+=2){ // Quando a variável num1 atingir o valor 20 o loop encerrará 
    console.log(num1);
}

console.log("count to 30 in 3 - 3: ")
var num2 = 0; // Criando variável para passar na estrutura
for(num2; num2 <= 30; num2+=3){ // Quando a variável num2 atingir o valor 30 o loop encerrará
    console.log(num2);
}

var my_name_is = "KESLEY";
var acess = 0;
console.log("letters in my name: ");
for(acess; acess <= 5; acess+=1){ // Acessando cada caractére da variavel my_name_is
    console.log(my_name_is[acess]);
}

/* 
*  Definimos a variável dentro ou fora do for
*  e aplicamos o seu limite de loops e atribuição
*  a variável
*/ 

