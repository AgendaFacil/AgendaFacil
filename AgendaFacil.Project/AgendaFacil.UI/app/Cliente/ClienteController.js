app.controller('ClienteCtrl', function ($rootScope, $location) {
	$rootScope.activetab = $location.path();
});