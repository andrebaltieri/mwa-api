(function () {
    'use strict';
    angular.module('mwa').factory('CategoryFactory', CategoryFactory);

    CategoryFactory.$inject = ['$http', '$rootScope', 'SETTINGS'];

    function CategoryFactory($http, $rootScope, SETTINGS) {
        return {
            get: get,
            post: post,
            put: put,
            remove: remove
        }

        function get() {
            return $http.get(SETTINGS.SERVICE_URL + 'api/categories', $rootScope.header);
        }

        function post(category) {
            return $http.post(SETTINGS.SERVICE_URL + 'api/categories', category, $rootScope.header);
        }

        function put(category) {
            return $http.put(SETTINGS.SERVICE_URL + 'api/categories/' + category.id, category, $rootScope.header);
        }

        function remove(category) {
            return $http.delete(SETTINGS.SERVICE_URL + 'api/categories/' + category.id, $rootScope.header);
        }
    }
})();