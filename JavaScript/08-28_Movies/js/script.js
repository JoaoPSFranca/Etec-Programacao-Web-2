$("h1").addClass("filmes");

$(".filmes").click(mostrarDados);

function mostrarDados(){
    $(this).next().slideToggle(750);
};