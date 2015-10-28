(function (angular) {
    angular.
        module('shieldApp').
        service('ratingDataService', RatingDataService);

    RatingDataService.$inject = ['$http'];

    function RatingDataService($http) {

        var service = {
            getRatingModel: getRatingModel,
            submitRating: submitRating
        };

        function getRatingModel() {
            return $http.get('api/ratings');
        }

        function submitRating(ratingToSubmit) {
            return $http.post('api/rating', ratingToSubmit);
        }

        return service;
    }

})(window.angular);