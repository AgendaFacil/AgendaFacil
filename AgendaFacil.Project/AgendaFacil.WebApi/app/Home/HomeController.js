app.controller('HomeCtrl', function ($scope,$rootScope, $location) {

    $rootScope.activetab = $location.path();
    $scope.labels = ["Download Sales", "In-Store Sales", "Mail-Order Sales"];
    $scope.data = [300, 500, 100];


    $scope.labels2 = ["January", "February", "March", "April", "May", "June", "July"];
    $scope.series2 = ['Series A', 'Series B'];
    $scope.data2 = [
      [65, 59, 80, 81, 56, 55, 40],
      [28, 48, 40, 19, 86, 27, 90]
    ];

});
