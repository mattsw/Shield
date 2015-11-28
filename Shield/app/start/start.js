(function(angular) {
    angular.
        module('shieldApp').
        controller('startCtrl', StartCtrl);

    StartCtrl.$inject = [];

    function StartCtrl() {
        var vm = this;

        vm.helloText = "Try it out today!";
        
    }
})(window.angular);