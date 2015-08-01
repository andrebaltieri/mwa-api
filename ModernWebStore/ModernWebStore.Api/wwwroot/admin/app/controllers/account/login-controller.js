(function () {
    'use strict';
    angular.module('mwa').controller('LoginCtrl', LoginCtrl);

    LoginCtrl.$inject = ['$location', '$rootScope', 'SETTINGS', 'AccountFactory'];

    function LoginCtrl($location, $rootScope, SETTINGS, AccountFactory) {
        var vm = this;
        vm.login = {
            email: '',
            password: ''
        };
        vm.submit = login;

        activate();

        function activate() {

        }

        function login() {
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
    };
})();