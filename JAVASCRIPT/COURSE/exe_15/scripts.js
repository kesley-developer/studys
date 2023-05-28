// Escopo global
var name = "My name is Kesley";

function my_function(){
    console.log(name);    
}
my_function();

/*
*  A variável NAME é global, sendo assim poderá ser 
*  usada em toda linha de código
*/

// Escopo local
function my_functionV2(){
    var age = "20 Years";
    console.log(age);
}
my_functionV2();

/* 
*  A variável AGE é local, portanto só poderá ser
*  usada dentro de seu escopo
*/