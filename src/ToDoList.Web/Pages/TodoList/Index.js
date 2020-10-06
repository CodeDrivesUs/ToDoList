$(function () {
  

    var dataTable = $('#TodoListTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(toDoList.todoList.todoList.getList),
            columnDefs: [
                {
                    title: 'Tittle',
                    data: "tittle"
                },
                {
                    title: 'Description',
                    data: "description"
                },
                {
                    title: 'UseraId',
                    data: "userId"
                },
                {
                    title: 'CreationTime', data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
});
