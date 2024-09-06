var todosBtn = document.querySelectorAll("#btnExcluir");

for (var i = 0; i < todosBtn.length; i++){
    todosBtn[i].addEventListener('click', excluirLinha(i));
}


function excluirLinha(i) {
    return function(){
        todosBtn[i].parentNode.parentNode.remove();
    }
}