
class Persons{
    
    // Declarando atributos
    _name
    _age
    _sex        
    _email

    // Criando método CONSTRUCTOR
    constructor(name,age,sex,email){ // Adicionando parâmetros
        
        // Inserindo valores aos atributos da classe
        this._name = name;
        this._age = age;
        this._sex = sex;
        this._email = email
    }
}

// Instânciando
let person1 = new Persons("Kesley",20,"Masculine","kesley@gmail.com");
let person2 = new Persons("Isabella",29,"Female","isabela@gmail.com");

console.log(person1);
console.log(person2);

/* 
* Com o método CONSTRUCTOR informamos os
* parâmetros a serem usados nos atributos
* e passamos os seus valores durante a instância
*/ 