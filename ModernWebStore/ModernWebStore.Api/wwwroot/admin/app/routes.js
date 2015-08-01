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
            .when('/categories', {
                controller: 'CategoryCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/category/index.html'
            })
            .when('/products', {
                controller: 'ProductListCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/product/index.html'
            })
            .when('/products/create', {
                controller: 'ProductCreateCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/product/create.html'
            })
            .when('/products/edit/:id', {
                controller: 'ProductEditCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/product/edit.html'
            })
            .when('/products/remove/:id', {
                controller: 'ProductRemoveCtrl',
                controllerAs: 'vm',
                templateUrl: 'pages/product/edit.html'
            });
    });
})();