function CalcularMedia (n1, n2) {
    n1 = parseFloat(n1);
    n2 = parseFloat(n2);
    return (( n1 + n2 ) / 2);
}

function VerificandoSituacao (notaFinal, notaAprovacao, linha) {
    let local = linha.querySelector(".info-situacao");
    if (notaFinal >= notaAprovacao) {
        local.textContent = "Aprovado(a)";
    }
    else{
        local.textContent = "Reprovado(a)";
        linha.classList.add("reprovado");
    }
}

function FormatarNota(nota){
    nota = parseFloat(nota);
    return nota.toFixed(1).toString().replace(".",",");
}

function colorirLinhas(){
    var TodosAluno = document.querySelectorAll(".aluno");

    for (var i = 0; i < TodosAluno.length; i++)
    {
        let linhaAluno = TodosAluno[i];

        if  ( (i + 1) % 2 != 0 ){
            linhaAluno.classList.add("linhaImpar");
        }
    }
}