
// Utilizando método
let obj={
    your_name: "Kesley",
    name: function(){
        console.log("Your name is: " + this.your_name);
    } 
};

obj.name();

/* 
*  A instrução this utiliza o 
*  valor de uma propriedade
*/

// Atribuindo valor a uma propriedade 
let people={
    name:"Kesley",
    age: 20,
    add_age: function(){
        this.age += 1;
    }
};

people.add_age() // Executando propriedade add_age
console.log(people.age);
