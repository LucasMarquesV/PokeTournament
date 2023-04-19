var selectAllState = true; // estado inicial do botão "Selecione todos"

document.getElementById('select-all').addEventListener('click', function () {
    // selecionar ou desmarcar todos os checkboxes, dependendo do estado atual do botão
    var checkboxes = document.querySelectorAll('.custom-control-input');
    for (var i = 0; i < checkboxes.length; i++) {
        checkboxes[i].checked = selectAllState;
    }

    // alterne o estado do botão
    selectAllState = !selectAllState;
});
