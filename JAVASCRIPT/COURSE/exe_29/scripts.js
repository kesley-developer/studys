
// Adicionando atributo
var title = document.querySelector("#my-title"); // Selecionando elemento

// Adicionando atributo ao elemento
title.setAttribute("class","my-class"); // Informando o tipo e nome do atributo

console.log(title);

// Removendo atributo
var sub_title = document.querySelector("#my-subtitle");

sub_title.removeAttribute("id");

console.log(sub_title);