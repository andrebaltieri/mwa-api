(function () {
    'use strict';
    angular.module('mwa').factory('CategoryFactory', CategoryFactory);

    CategoryFactory.$inject = ['$http', '$rootScope', 'SETTINGS'];

    function CategoryFactory($http, $rootScope, SETTINGS) {
        return {
            list: list
        };

        function list() {
            return $http.get(SETTINGS.SERVICE_URL + 'api/categories', $rootScope.header);
        }
    }
})();