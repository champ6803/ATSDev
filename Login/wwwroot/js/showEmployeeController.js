var app = angular.module("myapp", []); 
app.config(function($httpProvider) {
    $httpProvider.defaults.useXDomain = true;
    delete $httpProvider.defaults.headers.common['X-Requested-With'];
  });

app.service('dataService', function($http) {
    delete $http.defaults.headers.common['X-Requested-With'];
    this.flickrPhotoSearch = function() {
        return $http({
            method: 'GET',
            url: 'https://localhost:5001/api/values',
            dataType: 'jsonp',
            headers: {'Authorization': 'Token token=xxxxYYYYZzzz'}
         });
     }
});

app.controller("ShowEmployeeController", function($scope , $http , dataService){

    $scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;

$scope.init= function(){
    debugger;
    dataService.flickrPhotoSearch().then(function(dataResponse) {
        $scope.employees = dataResponse;
        console.log($scope.employees);
    });
}
});