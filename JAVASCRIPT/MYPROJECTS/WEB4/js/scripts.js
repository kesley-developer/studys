// Complete

function html_manipulation(){
    
    var items = [["Banana","Morango","Uva","Limão","Laranja","Abacate","Abacaxi"],
                ["Alface","Brócolis","Tomate","Batata","Ervilha","Cenoura","Couve"]
                ];

    
    document.write("<h2>" + "Fruits" + "</h2>")
    for(var i=0;i < items[0].length;i+=1){        
        document.write(items[0][i] + "<br>");
    }
    
    document.write("<h2>" + "Vegetables" + "</h2>")
    for(var i=0;i < items[1].length;i+=1){
        document.write(items[1][i] + "<br>");
    }
}

html_manipulation()