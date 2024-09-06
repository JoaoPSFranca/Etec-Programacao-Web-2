var btnBuscar = document.querySelector("#btnBuscar");
var txtBuscar = document.querySelector("#txtFiltro");
var TodosAluno = document.querySelectorAll(".aluno");
var Select = document.querySelector("#situacao");

var Texto = "";

txtBuscar.addEventListener('input', alterarVariavel);
btnBuscar.addEventListener('click', alterarVariavel);
Select.addEventListener('change', alterarVariavel);

function alterarVariavel(e){ 
    e.preventDefault(); 
    
    Texto = txtBuscar.value;
    Texto = Texto.toUpperCase(); 

    let Select2 = Select.value;
    
    if (Texto.trim() == "" || Select2 == "selecionar") {
        removeEscondido(); 
    }
    else{
        removeEscondido();
        pesquisarAluno();
    }
}

function removeEscondido(){
    for (var j = 0; j < TodosAluno.length; j++){
        let linhaAluno = TodosAluno[j];

        linhaAluno.classList.remove("escondido");
    }
}

function pesquisarAluno(){

    for (var i = 0; i < TodosAluno.length; i++)
    {
        let linhaAluno = TodosAluno[i];

        let situacao = linhaAluno.querySelector(".info-situacao");
        let nomeAluno = linhaAluno.querySelector(".info-nome");

        situacao = situacao.textContent;
        situacao = situacao.substring(0, situacao.length - 3);
        situacao = situacao.toUpperCase();

        let Select2 = Select.value;
        Select2 = Select2.toUpperCase();

        if (nomeAluno.textContent.substring(0, Texto.length) != Texto.toUpperCase() || Select2 != situacao){
            linhaAluno.classList.add("escondido");
        }  
    }
}