// Complete

function events(){
            
    // Select body
    const body = document.querySelector("body");

    // Select elements for insert text
    const menu_img = document.querySelector(".menu-image");    

    // Creat container, elements, styles & text for insert
    const div = document.createElement("div");    
    div.setAttribute("class","acess");    
        
    const p = document.createElement("p");    
    const a = document.createElement("a");    
    
    div.style.cssText = "background: rgba(27, 27, 27, 5.384); display: none; border-radius: 10px; padding: 10px; border-right: 10px solid orange; width: 50%;";    
    p.style.cssText = "font-family: monospace; font-size: 24px; color: #fff;";            
    a.style.cssText = "text-decoration: none; color: orange;";            
        
    div.appendChild(p);    
    div.appendChild(a);        
    
    menu_img.appendChild(div);
    
    // Select buttons
    const btn_chars = document.querySelector("#btn-characters");
    const btn_creators = document.querySelector("#btn-creators");
    const btn_games = document.querySelector("#btn-games");
    
    function btnEvents(){

        // Button Events & creat elements for acess
        btn_chars.addEventListener("click",function(){                        
            div.style.display = "inline-block";
                        
            p.textContent = "Veja os personagens";                                        
            a.setAttribute("href","chars.html");
            a.textContent = "Clique aqui e acesse";                                   
        });

        btn_creators.addEventListener("click",function(){                        
            div.style.display = "inline-block";
                        
            p.textContent = "Conheça os criadores da obra";
            a.setAttribute("href","creators.html");
            a.textContent = "Clique aqui e acesse";            
        });

        btn_games.addEventListener("click",function(){
            div.style.display = "inline-block";
            
            p.textContent = "Acesse a guia interativa";
            a.setAttribute("href","games.html");
            a.textContent = "Clique aqui e acesse";
        });
    };
    
    btnEvents();
}
events();
