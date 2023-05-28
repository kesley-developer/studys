
class Persons{

    // Atributos
    _name
    _age
    _sex
    
    constructor(name,age,sex){
        this._name = name;
        this._age = age;
        this._sex = sex;
    }
    
    // get = pegar ou extrair
    get personName(){
        return (this._name); // Retornando o atributo _NAME 
    }

    // set = editar ou alterar
    set editName(newName){     // Inserindo parâmetro para colocar valor na instância
        this._name = newName; // Alterando o atributo _NAME 
    }

}

// Instânciamento - inserindo os valores aos atributos
let person1 = new Persons("Kesley",20,"Masculine");
let person2 = new Persons("Isabella",29,"Female");

// Antes do SET
console.log(person1.personName);
console.log(person2.personName);

// Inserindo valor ao parâmetro do SET
person1.editName = "Marco";
person2.editName = "Beatriz";

// Depois do SET
console.log(person1.personName);
console.log(person2.personName);



