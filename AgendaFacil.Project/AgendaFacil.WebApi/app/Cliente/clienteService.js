'use strict'
app.factory('clienteService', ['$http', function ($http) {

    var clienteServiceFactory = {};

    var _getClientes = function () {
        return $http.get('api/cliente').then(function (results) {
            return results;
        });
    };

    var _gravarCliente = function (c) {
        return $http.post('api/cliente', c, { headers: { 'Content-Type': 'application/json' } });
    };

    clienteServiceFactory.getClientes = _getClientes;
    clienteServiceFactory.gravarCliente = _gravarCliente;
    return clienteServiceFactory;

}]);