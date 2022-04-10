function AbrirModal(id) {
    var detalhes = document.getElementById(id);
    var titulo = detalhes.attributes._titulo.nodeValue;
    var descricao = detalhes.attributes._descricao.nodeValue;
    var publicacao = detalhes.attributes._publicacao.nodeValue;
    document.getElementById('h5exampleModalLabel').innerHTML = titulo;
    document.getElementById('modalDescricao').innerHTML = descricao;
    document.getElementById('modalPublicacao').innerHTML = publicacao;
}