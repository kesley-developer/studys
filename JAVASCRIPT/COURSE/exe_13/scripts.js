// Funções(function)

function my_name(){ // Declarando função
    console.log("MY NAME IS KESLEY");
}

my_name() // Chamando função

/* 
*  Podemos adicionar parâmetros nas funções para
*  que a lógica do código funcione melhor
*/

function your_name(name){ // Declarando função com o parâmetro NAME
    console.log("YOUR NAME IS" + name  + "?");
}

your_name("JOHN"); // Chamando a função e passando o valor para o parâmetro NAME
your_name("VICTOR");
your_name("MARCOS");
your_name("MARY");

function sum(x,y){ // Criando função
    var sum = x + y;        // Somando os parâmetros X e Y dentro da função
    return sum;            // Retornando a função SUM que poderá ser usada de forma externa
}
 
var numbers0 = sum(2,7); // Declarando variável com a função SUM e os parâmetros 2 e 7
console.log(numbers0)

