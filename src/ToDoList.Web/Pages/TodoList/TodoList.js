$(function () {
  
    var createModal = new abp.ModalManager(abp.appPath + 'TodoList/CreateModal');
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#addbtn').click(function (e) {
        var id = $('#todoid').val();
        e.preventDefault();
        createModal.open({ Id: id });
    });
});