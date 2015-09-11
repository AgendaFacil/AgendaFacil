app.controller('TratamentoCtrl', function ($scope, $rootScope, $location) {
    $rootScope.activetab = $location.path();

    $scope.listaTratamento = [
        { profissional: 'Thiago Quartarolo', tratamento: 'Acupuntura' },
        { profissional: 'Fabio Testeiro', tratamento: 'Pedicure' },
        { profissional: 'Maria das Dores', tratamento: 'Limpeza de Pele' },
        { profissional: 'Roberto Carlos', tratamento: 'Massagem Relaxante' },
        { profissional: 'Mariana Assis', tratamento: 'Limpeza de Pele' }
    ];

});