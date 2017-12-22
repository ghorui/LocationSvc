/// <reference path="lib/angular.js" />

var locationApp = angular.module("locationApp", []);

var locationController = locationApp.controller("locationController", function ($scope, $http) {
    $scope.getLocation = function () {
        $http.get("https://localhost:44373/api/location?cityName=dc").then(function (res) {
            $scope.city = res.data;
        });
    }
});