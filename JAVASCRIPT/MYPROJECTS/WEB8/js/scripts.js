// Complete

// Criando função para tarefa
function addTask(){
    
    const taskTitle = document.querySelector("#task-title").value; // VALUE extrai o valor de um elemento

    // Validando se existe valor dentro do elemento selecionado
    if(taskTitle){
        
        // Clonando o template
        const template = document.querySelector(".template");        
        const newTask = template.cloneNode(true);

        // Adicionand titulo
        newTask.querySelector(".task-title").textContent = taskTitle;

        // Removendo classes desnecessarias
        newTask.classList.remove("template");
        newTask.classList.remove("hide");

        // Inserindo tarefa a lista
        const list = document.querySelector("#task-list");
        list.appendChild(newTask);

        // Evento para inserir botão de remoção da tarefa criada
        const removeBtn = newTask.querySelector(".remove-btn").addEventListener("click",function(){
            removeTask(this);
        })

        // Adicionando evento de tarefa concluida
        const doneBtn = newTask.querySelector(".done-btn").addEventListener("click",function(){
            completeTask(this);
        });
        
        // Removendo texto da entrada
        document.querySelector("#task-title").value = ""; 

    }
}

// Função de remoção de tarefa
function removeTask(task){
    
    // Elimando elemento pai
    task.parentNode.remove(true);
}

// Função de tarefa concluida
function completeTask(task){    
    
    // Selecionando elemento pai
    const taskToComplete = task.parentNode;

    // Verificando se a classe DONE está inserida no elemento
    taskToComplete.classList.toggle("done");

    console.log(taskToComplete);
}


// Selecionando o elemento
const addBtn = document.querySelector("#add-btn");

// Criado evento para adicionar tarefa
addBtn.addEventListener("click",function(e){

    e.preventDefault();

    addTask();
});
