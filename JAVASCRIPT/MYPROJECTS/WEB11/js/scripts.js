// Complete

const container_img = document.createElement("div");    // Criando container para imagem
container_img.className = "img-container";  // Definindo classe ao anterior
const el_img = document.createElement("img");   // Criando elemento img
const el_h2 = document.createElement("h2"); // Criando elemento H2
const el_p = document.createElement("p");   // Criando elemento P

// Função para adicionar elementos criados ao pai
function insertElements(){
    content.appendChild(container_img);
    container_img.appendChild(el_img);
    container_img.appendChild(el_h2);
    container_img.appendChild(el_p);
}
insertElements();

// Manipulando eventos
function myEvents(){   
    
    // Selecionando botões
    const btn_out = document.querySelector("#btn-outono");
    const btn_inv = document.querySelector("#btn-inverno");
    const btn_pri = document.querySelector("#btn-primavera");
    const btn_ver = document.querySelector("#btn-verao");            

    // Adicionando eventos ao botões
    btn_out.addEventListener("click",function(){                

        el_img.setAttribute("src","/JAVASCRIPT/frontend/MYPROJECTS/PROGRAM10/imgs/outono_img.jpg");                
        container_img.style.cssText = "display: flex;";
                        
        el_h2.textContent = "Outono";
        el_p.textContent = "Estação onde a paisagem se alaranja e as folhas caem. Se inicia em 22/03 e termina em 21/06.";
    });

    btn_inv.addEventListener("click",function(){
        focus = "inv";

        el_img.setAttribute("src","/JAVASCRIPT/frontend/MYPROJECTS/PROGRAM10/imgs/inverno_img.jpg");
        container_img.style.cssText = "display: flex;";

        el_h2.textContent = "Inverno";
        el_p.textContent = "Momento do ano onde o frio e o gelo se apresentam em muitas paisagens. Se inicia em 21/06 e termina em 23/09.";
    });

    btn_pri.addEventListener("click",function(){
        focus = "pri";        

        el_img.setAttribute("src","/JAVASCRIPT/frontend/MYPROJECTS/PROGRAM10/imgs/primavera_img.jpg");
        container_img.style.cssText = "display: flex;";
        
        el_h2.textContent = "Primavera";      
        el_p.textContent = "Paisagens belas e afloradas são criadas com a primavera. Se inicia em 23/09 e termina em 22/12.";
    });

    btn_ver.addEventListener("click",function(){
        focus = "ver";        
        
        el_img.setAttribute("src","/JAVASCRIPT/frontend/MYPROJECTS/PROGRAM10/imgs/verao_img.jpg");
        container_img.style.cssText = "display: flex;";

        el_h2.textContent = "Verão";
        el_p.textContent = "O verão trás consigo a energia do calor e paisagens para curtir o momento. Se inicia em 22/12 e termina em 22/03.";
    });               
}
myEvents();

