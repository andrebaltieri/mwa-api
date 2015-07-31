(function () {
    'use strict';
    angular.module('mwa').controller('CartCtrl', CartCtrl);

    CartCtrl.$inject = ['$rootScope', '$scope'];

    function CartCtrl($rootScope, $scope) {
        var vm = this;
        vm.items = [];
        vm.total = 0;
        vm.updateTotal = updateTotal;

        activate();

        function activate() {
            getItems();
            updateTotal();
        }

        function getItems() {
            angular.forEach($rootScope.cart, function (value, key) {
                vm.items.push({
                    title: value.title,
                    image: value.image,
                    quantity: 1,
                    price: value.price,
                    total: value.price
                });
            });
        }

        function updateTotal() {            
            getTotal();
        }

        function getTotal() {
            var total = 0;
            angular.forEach(vm.items, function (value, key) {                
                total += (value.price * value.quantity);
            });
            vm.total = total;
        }
    }
})();