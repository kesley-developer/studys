// Tipos de dados em JS

// Number
var number_int = 10;
console.log(number_int);
console.log("O tipo de dado da variável number_int é = " + typeof number_int); // Verificando o tipo de dado contido na variável

var number_float = 5.0;
console.log(number_float);
console.log("O tipo de dado da variável number_float é = " + typeof number_float);

console.log("----------------------");

// String
var string_number = "253";
console.log(string_number);
console.log("O tipo de dado da variável string_number é = " + typeof string_number);

var string_text = "Tudo entre aspas é uma string";
console.log(string_text);
console.log("O tipo de dado da variável string_text é = " + typeof string_text);

var first_name = "Kesley";
var last_name = "Deziderio";
var full_name = first_name + " " + last_name; // Concatenando uma string, ou seja, adicionando algo a ela
console.log(full_name);
console.log("O tipo de dado da variável full_name é = " + typeof full_name);

console.log("----------------------");

// Boolean
var value_true = true;   
console.log("O tipo de dado da variável value_true é = " + typeof value_true);

var value_false = false;
console.log("O tipo de dado da variável value_false é = " + typeof value_false);

console.log(typeof true);
console.log(typeof false); // Se o valor for true(verdadeiro) ou false(falso) ele será considerado boolean

console.log("----------------------");

// Undefined e Null
var value_null = null; // Variável tem como valor nula
console.log(value_null)

var variable_undefined; // Variável sem valor, ou seja retornará o tipo de dado undefined
console.log("O tipo de dado da variável variable_null é = " + typeof variable_undefined)

console.log(variable_undefined); // Está variável não foi definida acima, portanto retornará o tipo de dado undefined
variable_undefined = 100;

console.log("----------------------");

// Objects
var obj = { // Criamos um objeto com chaves "{}"
    name: "kesley",
    profission: "developer",
    age: 20
}
console.log(obj);
console.log("O tipo de dado da variável obj é = " + typeof obj);

// Acessando uma propriedade no objeto
console.log(obj.name);
console.log(obj.age);

// Alterando algumas propriedades do objeto
obj.name = "John";
obj.age = 29;
console.log(obj);

console.log("----------------------");

// Arrays
var my_array0 = ["Kesley",20,{name:"Kesley",age:20},true]; // Criamos um array com colchetes "[]"

my_array0[0] = "John"; // Substituindo o primeiro índice do array
console.log(my_array0[0]); // Acessando o primeiro índice do array
console.log(my_array0);

/* Podemos adicionar qualquer tipo de dado em um array, inclusive objetos, mas o recomendado 
   é trabalhar com apenas um tipo de dado em cada array
*/

var my_array1 = [1,2,3,4,5];
console.log(my_array1[1]);
console.log(my_array1);

console.log("----------------------");






                                

