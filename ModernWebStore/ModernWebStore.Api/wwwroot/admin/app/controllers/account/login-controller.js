(function () {
    'use strict';
    angular.module('mwa').controller('LoginCtrl', LoginCtrl);

    LoginCtrl.$inject = ['$rootScope', '$location', 'AccountFactory', 'SETTINGS'];

    function LoginCtrl($rootScope, $location, AccountFactory, SETTINGS) {
        var vm = this;

        vm.login = {
            email: "",
            password: ""
        };

        vm.submit = submit;

        activate();

        function activate() {

        }

        function submit() {
            AccountFactory.login(vm.login)
                .success(success)
                .catch(fail);

            function success(response) {
                $rootScope.user = vm.login.email;
                $rootScope.token = response.access_token;
                sessionStorage.setItem(SETTINGS.AUTH_TOKEN, response.access_token);
                sessionStorage.setItem(SETTINGS.AUTH_USER, $rootScope.user);
                $location.path('/');
            }

            function fail(error) {
                toastr.error(error.data.error_description, 'Falha na autenticação');
            }
        }
    }
})();