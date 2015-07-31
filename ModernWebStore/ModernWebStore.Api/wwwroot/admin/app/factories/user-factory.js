(function () {
    'use strict';
    angular.module('mwa').factory('UserFactory', UserFactory);

    UserFactory.$inject = ['$http', '$rootScope', 'SETTINGS'];

    function UserFactory($http, $rootScope, SETTINGS) {
        return {
            list: list
        };

        function list() {
            return $http.get(SETTINGS.SERVICE_URL + 'api/users', $rootScope.header);
        }
    }
})();