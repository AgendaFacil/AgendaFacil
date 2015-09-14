app.controller('AgendaCtrl', ['$scope', '$rootScope', function ($scope, $rootScope, $location) {

    $scope.angular = 'AGENDA TESTE ANGULAR 2';
    $scope.lstAgenda = [{ nome: "Thiago Cavalcante", data: "22-09-2015", hora: "as 14:00" }, { nome: "Quartarolo", data: "22-09-2015", hora: "as 16:00" }, { nome: "Flávia", data: "23-09-2015", hora: "as 10:00" }];

    var dataAtual = '';
    $scope.separarDatas = function (item) {

        if (item != dataAtual){
            dataAtual = item;
            return true;
        }
        return false;
    }

}]);