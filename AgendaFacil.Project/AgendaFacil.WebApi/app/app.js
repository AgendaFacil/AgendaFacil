var app = angular.module('app', ['ngRoute', 'ui.bootstrap', 'chart.js']);

app.config(function ($routeProvider, $locationProvider) {

	//$locationProvider.html5Mode(true);

	$routeProvider


	.when('/', {
		templateUrl: 'app/Home/home.html',
		controller: 'HomeCtrl',
	})
	.when('/cliente', {
		templateUrl: 'app/Cliente/cliente.html',
		controller: 'ClienteCtrl',
	})	
	.when('/agenda', {
		templateUrl: 'app/Agenda/agenda.html',
		controller: 'AgendaCtrl',
	})
	.when('/profissionais', {
	    templateUrl: 'app/Profissional/profissional.html',
	    controller: 'ProfissionalCtrl',
	})
    .when('/tratamento', {
    	templateUrl: 'app/Tratamento/tratamento.html',
        controller: 'TratamentoCtrl',
    })
	.otherwise({ redirectTo: '/' });
});