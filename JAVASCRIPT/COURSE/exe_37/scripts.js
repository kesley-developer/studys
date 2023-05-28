
// Selecionando elemento
let h2 = document.querySelector("h2");

// Animando elemento com o método
h2.animate([

    // keyframes - Aki passamos as propriedades e valores durante a animação do elemento
    
    // De
    {background: "black",color:"white"},

    // Para
    {background: "orange",color:"black"}
],{
    // Propriedades da animação - Tempo e outras opções da animação 
    
    duration: 1000,
    iterations: Infinity
}) 