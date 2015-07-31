(function () {
    'use strict';
    angular.module('mwa').controller('HomeCtrl', HomeCtrl);

    HomeCtrl.$inject = ['SETTINGS'];

    function HomeCtrl(SETTINGS) {
        var vm = this;

        activate();

        function activate() {

        }
    }
})();