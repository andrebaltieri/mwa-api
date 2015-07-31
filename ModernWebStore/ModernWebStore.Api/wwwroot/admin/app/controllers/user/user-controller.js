(function () {
    'use strict';
    angular.module('mwa').controller('UserCtrl', UserCtrl);

    UserCtrl.$inject = ['UserFactory'];

    function UserCtrl(UserFactory) {
        var vm = this;
        vm.users = [];

        activate();

        function activate() {
            getUsers();
        }

        function getUsers(){
            UserFactory.list()
                .success(success)
                .catch(fail);

            function success(response) {
                vm.users = response;
            }

            function fail(error) {
                console.log(error);
                if(error.status == 401)
                    toastr.error('Você não tem permissão para ver esta página', 'Requisição não autorizada');
                else
                    toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
        }
    }
})();