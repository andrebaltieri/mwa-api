(function () {
    'use strict';
    angular.module('mwa').factory('ProductFactory', ProductFactory);

    ProductFactory.$inject = ['$http', '$rootScope', 'SETTINGS'];

    function ProductFactory($http, $rootScope, SETTINGS) {
        return {
            get: get,
            getById: getById,
            post: post
        }

        function get() {
            return $http.get(SETTINGS.SERVICE_URL + 'api/products', $rootScope.header);
        }

        function getById(id) {
            return $http.get(SETTINGS.SERVICE_URL + 'api/products/' + id, $rootScope.header);
        }

        function post(product) {
            console.log(product);
            return $http.post(SETTINGS.SERVICE_URL + 'api/products', product, $rootScope.header);
        }
    }
})();