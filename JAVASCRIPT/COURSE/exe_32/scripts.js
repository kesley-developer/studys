
function result(num){ // Função para CALLBACK
    console.log("THE RESULT IS = "+num);
}

function sum(x,y,callback){ // Criando parâmetro de CALLBACK
    var operation = x+y; 
    callback(operation);
}

function multiplication(x,y,cb){ // Podemos também chamar de CB
    var operation = x*y;    
    cb(operation);
}

function subtraction(x,y,cb){
    var operation = x-y;   
    cb(operation)
}

sum(5,7,result); // Usando a função de CALLBACK nas outras funções
multiplication(2,5,result);
subtraction(9,8,result);

/* 
*  Callback caracteriza-se em passar uma função
*  dentro de outra, assim evitando repetições
*  de uma mesma função ou similar a outra
*/


