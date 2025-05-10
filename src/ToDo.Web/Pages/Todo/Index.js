$(function () {
    var l = abp.localization.getResource('ToDo');
    var inputFilter = function (requestData, dataTableSettings) {
        return {
            status: $('#Status').val(),
                priority: $('#Priority').val(),
                    from: $('#From').val(),
                        to: $('#To').val()
};
    }
    var responseCallback = function (result) {

        // your custom code.

        return {
            recordsTotal: result.totalCount,
            recordsFiltered: result.totalCount,
            data: result.items
        };
    };
    var createModal = new abp.ModalManager(abp.appPath + 'Todo/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Todo/EditModal');
    var progressModal = new abp.ModalManager(abp.appPath + 'Todo/ProgressModal');
    var dataTable = $('#TasksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(toDo.toDo.services.todo.getList, inputFilter, responseCallback),
               
            columnDefs: [
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('Priority'),
                    data: "priority",
                    render: function (data) {
                        return l('Enum:Priority.' + data);
                    }
                },
                {
                    title: l('Status'),
                    data: "status",
                    render: function (data) {
                        return l('Enum:Status.' + data);
                    }
                },
                {
                    title: l('DueDate'),
                    data: "dueDate",
                    dataFormat: "datetime"
                },

                {
                    title: l('CreationTime'), data: "creationTime",
                    dataFormat: "datetime"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('ToDo.Tasks.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('UpdateProgress'),
                                    visible: abp.auth.isGranted('ToDo.Tasks.Progress'),
                                    action: function (data) {
                                        progressModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('ToDo.Tasks.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'TaskDelete',
                                            data.record.title
                                        );
                                    },
                                    action: function (data) {
                                        toDo.toDo.services.todo
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                }
            ]
        })
    );

    

    
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });
    progressModal.onResult(function () {
        dataTable.ajax.reload();
    });
    $('#NewTaskButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});


async function Search() {
    $('#TasksTable').DataTable().ajax.reload();        
    }
