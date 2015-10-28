(function(angular) {
    angular.
        module('shieldApp', ['ui.router']).
        config(config);

    config.$inject = ['$locationProvider', '$stateProvider', '$urlRouterProvider'];

    function config($locationProvider, $stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise('start');
        $locationProvider.html5Mode(true);

        $stateProvider.
            state('start', {
                url: '/start',
                controller: 'startCtrl as vm',
                templateUrl: 'app/start/start.html'
            }).
            state('rating', {
                url: '/rating',
                controller: 'ratingCtrl as vm',
                templateUrl: 'app/rating/rating.html',
                resolve: {
                    ratingModel: ['ratingDataService', function (ratingDataService) {
                        return ratingDataService.getRatingModel();
                    }]
                }
            });
    }
})(window.angular);