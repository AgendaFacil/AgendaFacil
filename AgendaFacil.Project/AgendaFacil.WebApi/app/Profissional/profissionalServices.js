'use strict'
app.factory('profissionalService', ['$http', function ($http) {


	var profissionalServiceFactory = {};

	var _getProfissionais = function () {

		return $http.get('api/profissional').then(function (results) {
			return results;
		});
	};

	var _gravarProfissional = function (c) {

		
		return $http.post('api/profissional', c, { headers: { 'Content-Type': 'application/json' } });
	};



	profissionalServiceFactory.getProfissionais = _getProfissionais;
	profissionalServiceFactory.gravarProfissional = _gravarProfissional;
	return profissionalServiceFactory;

}]);