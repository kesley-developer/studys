
class Persons{

    // Atributos 
    _name
    _age

    // Aplicando atributo STATIC
    static total = 0;

    constructor(name,age){
        this._name = name;
        this._age = age;
        
        // Informando que o atributo STATIC chamado TOTAL receberá +1 a cada objeto criado na instância
        Persons.total += 1;
    }

    // Pegando o atributo STATIC nomeado TOTAL da classe para retornar um valor
    get total(){
        return Persons.total;
    }
}

// Instânciando - criando novos objetos a partir da classe
let person1 = new Persons("Kesley",20);
let person2 = new Persons("Isabella",29);
let person3 = new Persons("Marco",32);
let person4 = new Persons("Mary",40);

console.log(person1,person2,person3,person4);

// Aplicando atributo static a classe
console.log("Total Objects: " + Persons.total);

/*
*   A cada criação de um objeto na instância, o
*   atributo static TOTAL receberá +1 como valor,
*   sendo assim será feita a contagem de quantos 
*   objetos temos na classe, no caso do código
*   acima foram 4 objetos
*/ 