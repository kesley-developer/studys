
/* 
* O encapsulamento mais utilizado e comum
* no JS é de nivel private(privado)
*/

class Persons{

    // Aplicando encapsulamento private(privado) aos atributos 
    _name
    _age
    _sex
    _email
}

// Instânciando
let person1 = new Persons();

person1._name = "Kesley";
person1._age = 20;
person1._sex = "Masculine";
person1._email = "kesley@gmail.com";

console.log(person1);
