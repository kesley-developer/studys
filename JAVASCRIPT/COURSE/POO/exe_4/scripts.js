
class Operations{

    // Atributos
    _number0
    _number1
    
    constructor(num0,num1){ 
        this._number0 = num0;
        this._number1 = num1;
    }

    // Métodos específicos - soma, subtração, multiplicação e divisão dos atributos

    // Soma
    sum(){
        return (this._number0 + this._number1);
    }

    // Subtração
    subtraction(){
        return (this._number0 - this._number1);
    }

    // Multiplicação
    multiplication(){
        return (this._number0 * this._number1);
    }

    // Divisão
    division(){
        return (this._number0 / this._number1);
    }
}

// Instânciando - inserindo valores aos atributos da classe
let numbers = new Operations(20,10)

// Aplicando e mostrando resultado dos métodos criados
console.log(numbers.sum());
console.log(numbers.subtraction());
console.log(numbers.multiplication());
console.group(numbers.division());



