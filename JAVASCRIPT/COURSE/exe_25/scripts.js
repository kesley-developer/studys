
// Criando elemento
var new_element = document.createElement("p");

// Criando texto para o elemento anterior
var text = document.createTextNode("This is my text");

// Adicionando texto ao elemento
new_element.appendChild(text);

// Selecionando o elemento BODY do HTML
var body = document.querySelector("body");

// Adicionando o elemento ao BODY
body.appendChild(new_element);