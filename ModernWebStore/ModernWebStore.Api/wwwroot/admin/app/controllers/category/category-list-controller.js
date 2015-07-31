(function () {
    'use strict';
    angular.module('mwa').controller('CategoryListCtrl', CategoryListCtrl);

    CategoryListCtrl.$inject = ['CategoryFactory'];

    function CategoryListCtrl(CategoryFactory) {
        var vm = this;
        vm.categories = [];

        activate();

        function activate() {
            getCategories();
        }

        function getCategories() {
            CategoryFactory.list()
                .success(success)
                .catch(fail);

            function success(response) {
                vm.categories = response;
            }

            function fail(error) {
                console.log(error);
                if (error.status == 401)
                    toastr.error('Você não tem permissão para ver esta página', 'Requisição não autorizada');
                else
                    toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
        }
    }
})();