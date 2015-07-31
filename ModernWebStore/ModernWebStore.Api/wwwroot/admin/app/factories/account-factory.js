(function () {
    'use strict';
    angular.module('mwa').factory('AccountFactory', AccountFactory);

    AccountFactory.$inject = ['$http', 'SETTINGS'];

    function AccountFactory($http, SETTINGS) {
        return {
            login: login
        };

        function login(data) {
            var dt = "grant_type=password&username=" + data.email + "&password=" + data.password;
            return $http.post(SETTINGS.SERVICE_URL + 'api/security/token', dt, { headers: {'Content-Type': 'application/x-www-form-urlencoded'} });
        }
    }
})();