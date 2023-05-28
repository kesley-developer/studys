// let
let x = 1;
x = 2 // Alterando o valor da variável X

if(true){
    let x= 3;    
    console.log(x);
}
console.log(x);

/* 
*  Com let temos a possibilidade de criar uma
*  variável local identica a outra sem afetar
*  os valores da global
*/

// const
const y = 10;

if(true){
    const y = 20;
    console.log(y);
}
console.log(y);

/* 
*  Com const a variável pode ser criada de forma 
*  global e local, mas o seu valor permanece constante,
*  ou seja, o valor não poderá ser alterado
*/



