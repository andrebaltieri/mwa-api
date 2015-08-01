(function () {
    'use strict';
    angular.module('mwa').controller('ProductCreateCtrl', ProductCreateCtrl);

    ProductCreateCtrl.$inject = ['$scope', '$location', 'ProductFactory', 'CategoryFactory'];

    function ProductCreateCtrl($scope, $location, ProductFactory, CategoryFactory) {
        var vm = this;
        vm.categories = [];
        vm.product = {
            title: '',
            category: 0,
            description: '',
            price: 0,
            image: '',
            quantityOnHand: 0
        };
        vm.croppedImage = '';
        vm.save = save;

        activate();

        function activate() {
            getCategories();
        }

        function getCategories() {
            CategoryFactory.get()
                 .success(success)
                 .catch(fail);

            function success(response) {
                vm.categories = response;
            }

            function fail(error) {
                if (error.status == 401)
                    toastr.error('Você não tem permissão para ver esta página', 'Requisição não autorizada');
                else
                    toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
        }

        function save() {
            ProductFactory.post(vm.product)
                .success(success)
                .catch(fail);

            function success(response) {
                toastr.success('Produto <strong>' + response.title + '</strong> cadastrado com sucesso', 'Produto Cadastrado');
                $location.path('/products');
            }

            function fail(error) {
                if (error.status == 401)
                    toastr.error('Você não tem permissão para ver esta página', 'Requisição não autorizada');
                else
                    toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
        }

        var handleFileSelect = function (evt) {
            var file = evt.currentTarget.files[0];
            var reader = new FileReader();
            reader.onload = function (evt) {
                $scope.$apply(function ($scope) {
                    vm.product.image = evt.target.result;
                });
            };
            reader.readAsDataURL(file);
        };
        angular.element(document.querySelector('#file')).on('change', handleFileSelect);
    };
})();