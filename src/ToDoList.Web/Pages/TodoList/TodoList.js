$(function () {
  
    var createModal = new abp.ModalManager(abp.appPath + 'TodoList/CreateModal');
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#addbtn').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});