var botaoNovo = document.querySelector("#btnNovo");
var botaoCancelar = document.querySelector("#btnCancelar");
var botaoAdicionar = document.querySelector("#btnAdicionar");
var telaBloqueio = document.querySelector(".bloqueio");
var telaFormulario = document.querySelector("#pnlNovo");
var formulario = document.querySelector("#frmNovo")
var tabela = document.querySelector("#tblAlunos");
var msg = document.querySelector("#msg");

botaoNovo.addEventListener('click', exibirNovoAluno);
botaoCancelar.addEventListener('click', cancelarNovoAluno);
botaoAdicionar.addEventListener('click', adicionarNovoAluno);

function exibirNovoAluno(e){
    e.preventDefault();

    telaBloqueio.classList.remove("escondido");
    telaFormulario.classList.remove("escondido");
}

function cancelarNovoAluno(e){
    e.preventDefault();

    fecharForm();
}

function fecharForm (){
    formulario.txtNome.value="";
    formulario.txtRM.value="";
    formulario.txtNota1.value="";
    formulario.txtNota2.value="";
    telaBloqueio.classList.add("escondido");
    telaFormulario.classList.add("escondido");
}

function adicionarNovoAluno(e){
    e.preventDefault();

    var rm = formulario.txtRM.value;
    var nome = formulario.txtNome.value;
    var nota1 = formulario.txtNota1.value;
    var nota2 = formulario.txtNota2.value;

    // Validações
    if (nome == "") { msg.textContent = "Nome inválido"; nome.textContent = ""; return; }
    if (rm == "") { msg.textContent = "RM inválido"; rm.textContent = ""; return; }
    
    if (nota1 == "") { msg.textContent = "Nota 1 não pode ser branco"; nota1.textContent = ""; return; }
    nota1 = parseFloat(nota1);
    if (nota1 < 0 || nota1 > 10) { msg.textContent = "A nota 1 deve ser entre 0 e 10"; nota1.textContent = ""; return;}

    if (nota2 == "") { msg.textContent = "Nota 2 não pode ser branco"; nota2.textContent = ""; return; }
    nota2 = parseFloat(nota2);
    if (nota2 < 0 || nota2 > 10) { msg.textContent = "A nota 2 deve ser entre 0 e 10"; nota2.textContent = ""; return;}

    msg.textContent = "";

    //Criação de tabela e preenchimento
    var mediaNovoAluno = CalcularMedia(nota1, nota2); 

    var novaLinha = document.createElement("tr");
    novaLinha.classList.add("aluno");

    var celulaRM = document.createElement("td");
    celulaRM.classList.add("info-rm");
    celulaRM.textContent = rm;

    var celulaNome = document.createElement("td");
    celulaNome.classList.add("info-nome");
    celulaNome.textContent = nome.toUpperCase();

    var celulaN1 = document.createElement("td");
    celulaN1.classList.add("info-prova1");
    celulaN1.textContent = FormatarNota(nota1);

    var celulaN2 = document.createElement("td");
    celulaN2.classList.add("info-prova2");
    celulaN2.textContent = FormatarNota(nota2);

    var celulaMedia = document.createElement("td");
    celulaMedia.classList.add("info-media");
    celulaMedia.textContent = FormatarNota(mediaNovoAluno);

    var celulaSituacao = document.createElement("td");
    celulaSituacao.classList.add("info-situacao");

    var celulaRemove = document.createElement("td");
    celulaRemove.classList.add("info-excluir");
    
    var btnExcluir = document.createElement("button");
    btnExcluir.id = "btnExcluir";
    celulaRemove.appendChild(btnExcluir);

    btnExcluir.addEventListener('click', excluirLinha2(btnExcluir));

    //Colocando elementos na nova linha
    novaLinha.appendChild(celulaRM);
    novaLinha.appendChild(celulaNome);
    novaLinha.appendChild(celulaN1);
    novaLinha.appendChild(celulaN2);
    novaLinha.appendChild(celulaMedia);
    novaLinha.appendChild(celulaSituacao);
    novaLinha.appendChild(celulaRemove);

    //Fazendo os cálculos da Nova Linha
    VerificandoSituacao(mediaNovoAluno, 5, novaLinha);

    //Colocando a Nova linha na tabela
    tabela.appendChild(novaLinha);

    colorirLinhas();

    fecharForm();
}

function excluirLinha2(linha) {
    return function(){
        linha.parentNode.parentNode.remove();
    }
}