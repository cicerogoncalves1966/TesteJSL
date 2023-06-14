function GravarPedido() {
    debugger;

    var data = $("#DataPedido").val();
    var cliente = $("#ClienteId").val();
    var total = $("#TotalPedido").val();
    var status = $("#Status").val();

    //var token = $('input[name="__RequestVerificationToken"]', $('#__AjaxAntiForgeryForm')).val();
    //var tokenadr = $('form[action="~/Pedidos/Create"] input[name="__RequestVerificationToken"]').val();
    //var headers = {};
    //var headersadr = {};
    //headers['__RequestVerificationToken'] = token;
    //headersadr['__RequestVerificationToken'] = tokenadr;

    // Bloco de gravação do pedido
    var url = "/Pedidos/Create";

    $.ajax({
        url: url
        //: '@Url.Action("Create")'
        , type: "post"
        , datatype: "json"
        , contentType: "application/json; charset=utf-8"
        , processData: false
        , data: { Id: 0, ClienteId: cliente, DataPedido: data, TotalPedido: total, Status: status } //, __RequestVerificationToken: token }
        , success: function (data) {
            if (data.Result > 0) {
                debugger;
                //ListarItens(data.Result);
            }
        }
    })
}