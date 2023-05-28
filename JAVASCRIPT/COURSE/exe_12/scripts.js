// Comandos break e continue

// break
console.log("stopping counting FOR: ");
for(var count=0; count <= 10; count+=1){ // Criando loop
    console.log(count);
    
    if(count === 5){ // Quando a variável count tiver 5 como valor o loop se encerrará

        console.log("stop in number 5");
        break;
    }    
}

num = 0;
console.log("stopping counting for WHILE:");
while(num <= 10){
    console.log(num);
    num += 1;

    if(num === 5){ // Quando a variável num atingir 5 como valor o loop acabará
        console.log("stop in number 5");
        break;
    }
}

// continue
console.log("adding a word in the condition FOR: ");
for(var count=0; count <= 100; count+=10){
    console.log(count);

    if(count === 50){ // Quando a variável count tiver 50 como valor o mesmo será ignorado
        continue;
    }
}

num = 0;
console.log("adding a word in the WHILE: ");
while(num <= 20){ 
    console.log(num);
    num += 2

    if(num === 10){ // Quando a variável num tiver 10 como valor o mesmo será ignorado
        continue;
    }
}



