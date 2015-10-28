(function (angular) {
    angular.
        module('shieldApp').
        controller('ratingCtrl', RatingCtrl);

    RatingCtrl.$inject = ['ratingDataService', 'ratingModel'];

    function RatingCtrl(ratingDataService, ratingModel) {
        var vm = this;
        vm.hasProcessed = false;
        vm.processingErrors = [];
        vm.ratingModel = ratingModel.data;

        vm.submitRating = submitRating;

        function submitRating() {
            ratingDataService.submitRating(vm.ratingModel).
                then(handleSubmitSuccess, handleSubmitError);

            function handleSubmitSuccess(response) {
                vm.hasProcessed = true;
                console.log('Worked!');
            }

            function handleSubmitError(error) {
                vm.hasProcessed = true;
                vm.processingErrors.push('Generic error for now');
                console.log('Error');
            }
        }

        return vm;
    }
})(window.angular);