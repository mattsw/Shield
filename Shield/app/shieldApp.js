﻿(function(angular) {
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
            state('review', {
                url: '/review',
                controller: 'reviewCtrl as vm',
                templateUrl: 'app/review/review.html',
                resolve: {
                    reviewModel: ['reviewDataService', function (reviewDataService) {
                        return reviewDataService.getReviewModel();
                    }]
                }
            });
    }
})(window.angular);