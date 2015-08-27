app.controller('AgendaCtrl', function ($rootScope, $location) {
	$rootScope.activetab = $location.path();
});