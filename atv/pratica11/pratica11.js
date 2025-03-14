document.addEventListener('DOMContentLoaded', carregarTarefas);

function carregarTarefas() {
    let tarefas = JSON.parse(localStorage.getItem('tarefas')) || [];
    tarefas.forEach(tarefa => adicionarTarefaNaLista(tarefa.texto, tarefa.completa));
}
function salvarTarefas() {
    let tarefas = [];
    document.querySelectorAll('.list-group-item').forEach(tarefa => {
        tarefas.push({ texto: tarefa.querySelector('.texto-tarefa').textContent, completa: tarefa.classList.contains('completed') });
    });
    localStorage.setItem('tarefas', JSON.stringify(tarefas));
}
function adicionarTarefa() {
    const inputNovaTarefa = document.getElementById('nova-tarefa');
    const textoTarefa = inputNovaTarefa.value.trim();

    if (textoTarefa !== '') {
        adicionarTarefaNaLista(textoTarefa);
        salvarTarefas();
    }
    inputNovaTarefa.value = '';
}
function adicionarTarefaNaLista(textoTarefa, completa = false) {
    const li = document.createElement('li');
    li.className = `list-group-item ${completa ? 'completed' : ''}`;

    const span = document.createElement('span');
    span.className = 'texto-tarefa';
    span.textContent = textoTarefa;

    const btnRemover = document.createElement('button');
    btnRemover.className = 'btn btn-danger btn-sm ml-2';
    btnRemover.textContent = 'Remover';
    btnRemover.onclick = () => {
        li.remove();
        salvarTarefas();
    };
    const btnConcluir = document.createElement('button');
    btnConcluir.className = 'btn btn-success btn-sm ml-2';
    btnConcluir.textContent = 'Concluir';
    btnConcluir.onclick = () => {
        li.classList.toggle('completed');
        salvarTarefas();
    };
    li.append(span, btnConcluir, btnRemover);
    document.getElementById('lista-tarefas').appendChild(li);
}
