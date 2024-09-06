var TodosAluno = document.querySelectorAll(".aluno");

for (var i = 0; i < TodosAluno.length; i++)
{
    let linhaAluno = TodosAluno[i];

    let local_nota_01 = linhaAluno.querySelector(".info-prova1");
    let local_nota_02 = linhaAluno.querySelector(".info-prova2");
    let local_media = linhaAluno.querySelector(".info-media");
    let localSituacao = linhaAluno.querySelector(".info-situacao");

    let mediaAluno = CalcularMedia (local_nota_01.textContent, local_nota_02.textContent);
    VerificandoSituacao(mediaAluno, 5, linhaAluno);
    
    local_nota_01.textContent = FormatarNota(local_nota_01.textContent);
    local_nota_02.textContent = FormatarNota(local_nota_02.textContent);
    local_media.textContent = FormatarNota(mediaAluno);
}

colorirLinhas();