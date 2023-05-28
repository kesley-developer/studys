
// Criando elemento para substituir
var el = document.createElement("h3");

// Adicionando classe ao elemento
el.classList = "my-class";

// Criando texto para o elemento
var text = document.createTextNode("Este elemento foi alterado");

// Inserindo texto criado ao elemento
el.appendChild(text);

console.log(el);

// Selecionando elemento a ser substituido
var other_el = document.querySelector("#title");

// Selecionando elemento pai
var select_dad = other_el.parentNode;

// Trocando os elementos
select_dad.replaceChild(el,other_el); // Informamos o elemento a ser colocado e o substituido

console.log(document.querySelector("body"));
