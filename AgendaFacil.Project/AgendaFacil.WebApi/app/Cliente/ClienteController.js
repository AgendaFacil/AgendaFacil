'use strict';
app.controller('ClienteCtrl', ['$scope', 'clienteService', '$rootScope', function ($scope, clienteService, $rootScope) {


    $scope.cliente = {};
    $scope.listaClientes = {};

    var _carregaLista = function ($scope) {
        clienteService.getClientes().then(function (results) {
            $scope.listaClientes = results.data;
        }, function (error) {
            alert("erro");
        });
    };

    _carregaLista($scope);

    var _salvarDados = function (cliente) {
        var $req;
        $req = clienteService.gravarCliente(cliente);
        $req.success(function (resposta) {
            alert(resposta);
        })
        .error(function () {
            alert('ERRO!');
        });
    };

    $scope.salvarDados = _salvarDados;

}]);