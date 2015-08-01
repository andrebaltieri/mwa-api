(function () {
    'use strict';

    angular.module('mwa').constant('SETTINGS', {
        'VERSION': '0.0.1',
        'CURR_ENV': 'dev',
        'AUTH_TOKEN': 'mwa-token',
        'AUTH_USER': 'mwa-user',
        'SERVICE_URL': '/'
        // 'SERVICE_URL': 'http://minhaapi.azurewebsites.net/'
    });

    angular.module('mwa').run(function ($rootScope, $location, SETTINGS) {
        var token = sessionStorage.getItem(SETTINGS.AUTH_TOKEN);
        var user = sessionStorage.getItem(SETTINGS.AUTH_USER);

        $rootScope.user = null;
        $rootScope.token = null;
        $rootScope.header = null;

        if (token && user) {
            $rootScope.user = user;
            $rootScope.token = token;
            $rootScope.header = {
                headers: {
                    'Authorization': 'Bearer ' + $rootScope.token
                }
            }
        }

        $rootScope.$on("$routeChangeStart", function (event, next, current) {
            if ($rootScope.user == null) {
                $location.path('/login');
            }
        });
    });
})();