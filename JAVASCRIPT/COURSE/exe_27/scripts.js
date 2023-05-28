
// appendChild - Inserindo elemento filho
var el = document.createElement("div"); // Criando elemento

el.classList = "my-class";  // Definindo uma classe ao elemento criado

var container = document.querySelector("#my-id"); // Selecionando elemento pai para inserir o filho

container.appendChild(el); // Inserindo elemento filho dentro do elemento pai
console.log(container);

// insertBefore - Inserindo elemento antes de outro
var el2 = document.createElement("div");
el2.classList = "my-other-class";

var el3 = document.querySelector("#my-id .my-class"); // Selecionando elementos para referência

container.insertBefore(el2,el3); // Inserindo elemento EL2 entre o elemento EL3



