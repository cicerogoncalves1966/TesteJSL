﻿function GravarPedido() {
    debugger;

    var data = $("#DataPedido").val();
    var cliente = $("#IdCliente").val();
    var total = $("#TotalPedido").val();
    var status = $("#Status").val();

    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var tokenadr = $('form[action="/Pedidos/Create"] input[name="__RequestVerificationToken"]').val();
    //var headers = {};
    //var headersadr = {};
    //headers['__RequestVerificationToken'] = token;
    //headersadr['__RequestVerificationToken'] = tokenadr;
    var headers = { __RequestVerificationToken: $('input[name="__RequestVerificationToken"]').val() };

    // Bloco de gravação do pedido
    var url = "/Pedidos/Create";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headers
        , pedido: { Id: 0, IdCliente: cliente, DataPedido: data, TotalPedido: total, Status: status }
        , success: function (pedido) {
            if (data.Resultado > 0) {
                debugger;
                ListarItens(pedido.Result);
            }
        }
    })
}

function ListarItens(idPedido) {
    var url = "/PedidoItens/ListarItensPedido";

    $.ajax({
        url: url
        , type: "get"
        , datatype: "html"
        , data: { Id: idPedido }
        , success: function (data) {
            var divItens = $("#divItens");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    })
}

function GravarItens(idPedido) {
    var pedido = $("#PedidoId")
    var quantidade = $("#Quantidade").val();
    var produto = $("#ProdutoId").val();
    var valorUnitario = $("#ValorProduto").val();
    var valorTotal = $("#ValorTotal").val();

    var url = "/PedidoItens/GravarItensPedido";

    $.ajax({
        url: url
        , type: "get"
        , datatype: "html"
        , data: { idPedido: pedido, idProduto: produto, quantidade: quantidade, vlrUnitario: valorUnitario, vlrTotal: valorTotal }
        , success: function (data) {
            if (data.Resultado > 0) {
                debugger;
                ListarItens(idPedido);
            }
        }
    })
}

