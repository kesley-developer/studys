// Complete

// Visualização geral
console.log(document.querySelector("body"));

// HEADER
function manipulate_header(){
    
    header = document.querySelector("header");    
    var h1 = document.createElement("h1");
    var text = document.createTextNode("My informations");    
    
    h1.appendChild(text);
    header.appendChild(h1);                
};
manipulate_header();

// SECTION
function manipulate_section(){
        
    var section = document.querySelector("section");

    for(let divs=0;divs <= 3;divs += 1){
        
        // Criando elementos
        var div = document.createElement("div");
        var h2 = document.createElement("h2");
        var p = document.createElement("p");
        
        // Criando condições, inserindo texto e classe aos elementos
        if(divs == 0){
            var text = document.createTextNode("Kesley Keven da Silva Dezideiro");
            p.appendChild(text);
            div.classList = "name";
            
            h2.textContent = "Name";            
            div.appendChild(h2);                
        }else{
            if(divs == 1){
                var text = document.createTextNode("20 Years");
                p.appendChild(text);
                div.classList = "age";

                h2.textContent = "Age";            
                div.appendChild(h2);

            }else if(divs == 2){
                var text = document.createTextNode("Programmer");
                p.appendChild(text);
                div.classList = "profession"

                h2.textContent = "Profession";
                div.appendChild(h2);
            
            }else if(divs == 3){
                var text = document.createTextNode("Brazil");
                p.appendChild(text);
                div.classList = "country";

                h2.textContent = "Country";
                div.appendChild(h2);
            }
        }
        
        // Inserindo elementos na DIV e SECTION
        div.appendChild(p);
        section.appendChild(div);
    };
};
manipulate_section();

// FOOTER
function manipulate_footer(){
    
    // Criando elementos, inserindo texto e atributos
    var footer = document.querySelector("footer");
    var div = document.createElement("div");
    
    var p = document.createElement("p");
    p.textContent = "Copyright © 2022 ";

    var link = document.createElement("a");
    link.textContent = "Kesley Developer";
    link.setAttribute("href","https://www.linkedin.com/in/kesley-keven-%C2%A9-18358a1bb/");
        
    p.appendChild(link);
    div.appendChild(p);
    footer.appendChild(div);
}
manipulate_footer();

// CSS - ESTILIZAÇÃO
function css_styles(){    
    
    // BODY
    function body_style(){
        var body = document.querySelector("body");
        body.style.cssText = "padding: 0; margin: 0;";
    };

    // HEADER
    function header_style(){
        var header = document.querySelector("header");
        header.style.cssText = "Background-color: orange; padding: 24px;";
    };

    // SECTION
    function section_style(){
        var section = document.querySelector("section");
        section.style.cssText = "text-align: center; padding: 1% 0 1% 0;";
    };

    // FOOTER
    function footer_style(){
        var footer = document.querySelector("footer");
        footer.style.cssText = "Background-color: orange; color: black; text-align: center; padding: 20px; font-size: 20px; margin-top: 50px";

        // LINK
        var link = document.querySelector("a");
        link.style.cssText = "Color: black;";
    }

    // Retornando funções
    return body_style() & header_style() & section_style() & footer_style();
}
css_styles();