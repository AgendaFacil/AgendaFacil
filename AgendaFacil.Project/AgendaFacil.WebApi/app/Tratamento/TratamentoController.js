﻿'use strict';
app.controller('TratamentoCtrl', ['$scope', 'tratamentoService', '$rootScope', function ($scope, tratamentoService, $rootScope) {



    $scope.listaProfissionais = [
        { nome: 'Thiago Quartarolo', telefone: '(11)9 7382-7002', email: 'thiago.quartarolo@gmail.com' },
        { nome: 'Fabio Testeiro', telefone: '(11)9 7121-7122', email: 'fabio.testeiro@hotmail.com' },
        { nome: 'Maria das Dores', telefone: '(11)9 7688-2472', email: 'maria_1988@gmail.com' },
        { nome: 'Roberto Carlos', telefone: '(13)9 2143-7567', email: 'roberto.carlos@yahoo.com.br' },
        { nome: 'Mariana Assis', telefone: '(11)9 9878-7222', email: 'Mariana19@uol.com.br' }
    ];

    var _carregaLista = function ($scope) {
    	profissionalService.getProfissional().then(function (results) {
    		$scope.listaProfissionais = results.data;

    	}, function (error) {
    		alert("erro");
    	});
    };
    _carregaLista($scope);

    var _salvarDados = function () {
  
    	var $req;
    	var c = "teste";
    	$req = profissionalService.gravarProfissional(c);
  
    	$req.success(function (resposta) {

    		alert(resposta);
    	})
        .error(function () {
        	alert('ERRO!');
        });
    };

    $scope.salvarDados = _salvarDados;

}]);