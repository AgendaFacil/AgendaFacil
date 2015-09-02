app.controller('TratamentoCtrl', function ($scope, $rootScope, $location) {
    $rootScope.activetab = $location.path();

    $scope.listaTratamento = [
        { nome: 'Thiago Quartarolo', telefone: '(11)9 7382-7002', email: 'thiago.quartarolo@gmail.com' },
        { nome: 'Fabio Testeiro', telefone: '(11)9 7121-7122', email: 'fabio.testeiro@hotmail.com' },
        { nome: 'Maria das Dores', telefone: '(11)9 7688-2472', email: 'maria_1988@gmail.com' },
        { nome: 'Roberto Carlos', telefone: '(13)9 2143-7567', email: 'roberto.carlos@yahoo.com.br' },
        { nome: 'Mariana Assis', telefone: '(11)9 9878-7222', email: 'Mariana19@uol.com.br' }
    ];

});