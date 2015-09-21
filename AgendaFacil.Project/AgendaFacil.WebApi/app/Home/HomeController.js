app.controller('HomeCtrl', function ($rootScope, $location) {

    $rootScope.activetab = $location.path();
    $scope.labels = ["Download Sales", "In-Store Sales", "Mail-Order Sales"];
    $scope.data = [300, 500, 100];


});
