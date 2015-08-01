(function () {
    'use strict';
    angular.module('mwa').controller('CategoryCtrl', CategoryCtrl);

    CategoryCtrl.$inject = ['CategoryFactory'];

    function CategoryCtrl(CategoryFactory) {
        var vm = this;
        vm.categories = [];
        vm.category = {
            id: 0,
            title: ''
        };
        vm.saveCategory = saveCategory;
        vm.loadCategory = loadCategory;
        vm.cancel = cancel;
        vm.removeCategory = removeCategory;

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

        function saveCategory() {
            if (vm.category.id == 0) {
                addCategory();
            } else {
                updateCategory();
            }
        }

        function addCategory() {
            CategoryFactory.post(vm.category)
                 .success(success)
                 .catch(fail);

            function success(response) {
                vm.categories.push(response);
            }

            function fail(error) {
                toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
            clearCategory();
        }

        function updateCategory() {
            CategoryFactory.put(vm.category)
                 .success(success)
                 .catch(fail);

            function success(response) {
                toastr.success('Categoria <strong>' + response.title + '</strong> alterada com sucesso', 'Sucesso');
            }

            function fail(error) {
                toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }
            clearCategory();
        }

        function removeCategory(category) {
            loadCategory(category);
            CategoryFactory.remove(vm.category)
                 .success(success)
                 .catch(fail);

            function success(response) {
                toastr.success('Categoria <strong>' + response.title + '</strong> removida com sucesso', 'Sucesso');
                var index = vm.categories.indexOf(category);
                vm.categories.splice(index, 1);
            }

            function fail(error) {
                toastr.error('Sua requisição não pode ser processada', 'Falha na Requisição');
            }

            clearCategory();
        }

        function loadCategory(category) {
            vm.category = category;
        }

        function cancel() {
            clearCategory();
        }

        function clearCategory() {
            vm.category = {
                id: 0,
                title: ''
            };
        }
    };
})();