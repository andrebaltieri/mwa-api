(function () {
    'use strict';
    angular.module('mwa').controller('LogoutCtrl', LogoutCtrl);

    LogoutCtrl.$inject = ['$rootScope', '$location', 'SETTINGS'];

    function LogoutCtrl($rootScope, $location, SETTINGS) {
        var vm = this;

        activate();

        function activate() {
            $rootScope.user = null;
            $rootScope.token = null;
            sessionStorage.removeItem(SETTINGS.AUTH_TOKEN);
            sessionStorage.removeItem(SETTINGS.AUTH_USER);

            $location.path('/login');
        }
    }
})();