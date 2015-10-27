(function (angular) {
    angular.
        module('shieldApp').
        service('reviewDataService', ReviewDataService);

    ReviewDataService.$inject = ['$http'];

    function ReviewDataService($http) {

        var service = {
            getReviewModel: getReviewModel,
            submitReview: submitReview
        };

        function getReviewModel() {
            return $http.get('api/reviews');
        }

        function submitReview(reviewToSubmit) {
            return $http.post('api/reviews', reviewToSubmit);
        }

        return service;
    }

})(window.angular);