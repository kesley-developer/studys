// Acessando elementos na página HTML

// Criando ARRAY
var fruits = ["Apple","Banana","Lemon","Orange","Strawberry"];

// Criando o elemento <ul>
var list_html = document.createElement('ul'); 

// Acessando o elemento <body>
var body = document.getElementsByTagName('body'); 

// Imprimindo na tela o <body> do documento HTML
console.log(body[0]); 

// Inserindo a tag <ul> no <body> do documento HTML
body[0].appendChild(list_html); // appendChild - Adiciona um elemento filho, ou seja indentado a dentro

// Mostrando elemento da <ul> no documento HTML
var list_in_body = document.getElementsByTagName('ul');

// Inserindo itens na tag <ul>
for(var i=0;i < fruits.length;i+=1){
    
    // Criando elementos <li> a cada loop no for
    var creat_li = document.createElement('li');
    
    // Pegando os elementos dentro do ARRAY fruits
    var text_li = document.createTextNode(fruits[i]);

    // Adicionando elementos do ARRAY na tag <li>
    creat_li.appendChild(text_li);    
    
    // Adicionando os elementos <li> dentro da <ul>
    list_in_body[0].appendChild(creat_li);
    
    // Imprimindo no console elementos da <li>
    console.log(creat_li);    
}
