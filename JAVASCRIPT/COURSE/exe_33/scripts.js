
// setTimeout
setTimeout(function(){ // Passando uma função como parâmetro
    console.log("Hello World!");

},2000); // Informando a quantidade de segundos para execução

// setInterval
setInterval(function(){ 
    console.log("Bye World!");    

},1000) 

/*
*  setTimeout é executada apenas uma
*  vez, diferente de setInterval que 
*  é executada em loop
*/

// Obs: informamos 1 segundo como 1000