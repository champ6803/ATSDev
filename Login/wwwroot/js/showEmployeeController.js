var app = angular.module("myapp", []);
app.config(['$httpProvider', function($httpProvider) {
    $httpProvider.defaults.withCredentials = true;
  }]);
app.controller("ShowEmployeeController", function($scope , $http){
$scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;
$scope.init= function(){
    debugger;
<<<<<<< HEAD
    var req = {
        //withCredentials: true,
        
    }

    $http.get("http://localhost:5000/api/generateuser").then(function(response){
=======
   
<<<<<<< HEAD
    $http.get("http://localhost:5000/api/generateuser").then(function(response){
=======
    $http.get("https://localhost:5000/api/generateuser").then(function(response){
>>>>>>> 09c8e0ccb8f72c5d4f9ce5cb4677a021a4d88e2b
>>>>>>> 54d390946d840162b4eddcae008664ade8df55fc
        
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