'use strict'
app.factory('tratamentoService', ['$http', function ($http) {

	
	var listaServiceFactory = {};

	var _getTratamentos = function () {

		return $http.get( 'api/tratamento').then(function (results) {
			return results;
		});
	};

	var _gravarTratamento = function (c) {
	    
	   var data = JSON.stringify({value:2});
		return $http.post('api/tratamento', data, { headers: { 'Content-Type': 'application/json' } });
	};



	listaServiceFactory.getTratamentos = _getTratamentos;
	listaServiceFactory.gravarTratamento = _gravarTratamento;
	return listaServiceFactory;

}]);