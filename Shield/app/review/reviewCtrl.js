(function (angular) {
    angular.
        module('shieldApp').
        controller('reviewCtrl', ReviewCtrl);

    ReviewCtrl.$inject = ['reviewDataService', 'reviewModel'];

    function ReviewCtrl(reviewDataService, reviewModel) {
        var vm = this;
        vm.hasProcessed = false;
        vm.processingErrors = [];
        vm.reviewModel = reviewModel.data;

        vm.submitReview = submitReview;

        function submitReview() {
            reviewDataService.submitReview(vm.reviewModel).
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