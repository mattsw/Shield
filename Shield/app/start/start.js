(function(angular) {
    angular.
        module('shieldApp').
        controller('startCtrl', StartCtrl);

    StartCtrl.$inject = [];

    function StartCtrl() {
        var vm = this;

        vm.helloText = "Welcome to the site!";

        //TODO Arrange a way for this data to flow from a database or other source
        vm.news = [
            { header: 'Some article', text: 'Something interesting happening in here' },
            { header: 'Some other article', text: 'Something not so interesting' }
        ];

    }
})(window.angular);