(function () {
    'use strict';
    angular.module('mwa').factory('ProductFactory', ProductFactory);

    ProductFactory.$inject = ['$http', '$rootScope', 'SETTINGS'];

    function ProductFactory($http, $rootScope, SETTINGS) {
        return {
            list: list
        };

        function list(data) {            
            return $http.get(SETTINGS.SERVICE_URL + 'api/products', $rootScope.header);
        }
    }
})();