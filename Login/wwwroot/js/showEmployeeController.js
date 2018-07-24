var app = angular.module("myapp", []);
app.config(['$httpProvider', function($httpProvider) {
    $httpProvider.defaults.withCredentials = true;
  }]);
app.controller("ShowEmployeeController", function($scope , $http){
$scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;
$scope.init= function(){
    debugger;
   
    $http.get("http://localhost:5000/api/generateuser").then(function(response){
        
        if(response.data){
            debugger;
            alert('ดึงรายชื่อสำเร็จ');
            $scope.employees = response.data;
        }else{

            alert('ดึงรายชื่อไม่สำเร็จ');
        }
    },function(response){
            debugger;
            alert('fail');
    });
}
});