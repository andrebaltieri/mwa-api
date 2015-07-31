(function () {
    'use strict';
    angular.module('mwa').config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'HomeCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/home/index.html'
            })
            .when('/login', {
                controller: 'LoginCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/account/login.html'
            })
            .when('/logout', {
                controller: 'LogoutCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/account/login.html'
            })
            .when('/users', {
                controller: 'UserCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/user/index.html'
            })
            .when('/categories', {
                controller: 'CategoryListCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/category/index.html'
            })
            .when('/categories/edit/:id', {
                controller: 'CategoryEditCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/category/edit.html'
            });
    });
})();