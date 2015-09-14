(function(angular) {
    angular.
        module('shieldApp').
        controller('startCtrl', StartCtrl);

    StartCtrl.$inject = [];

    function StartCtrl() {
        var vm = this;

        this.helloText = "Try it out today!";

        return vm;
    }
})(window.angular);