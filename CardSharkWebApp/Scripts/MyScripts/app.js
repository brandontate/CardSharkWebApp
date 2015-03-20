(function () {
    var app = angular.module("CardSharkApp", [])

    app.controller("OrganizationCtrl", ["$scope", function ($scope) {
        $scope.organizations = [
            { name: "WWE" },
            { name: "UFC" }
            ]
    }]);
})();