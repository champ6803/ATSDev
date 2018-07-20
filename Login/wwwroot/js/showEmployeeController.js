var app = angular.module("myapp", []); 
app.controller("ShowEmployeeController", function($scope , $http){

    $scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;

$scope.init= function(){
    debugger;
    var req ={
        url=""
    }
    $http.get(req).then(function(response){
        if(response.data){
            alert('ดึงรายชื่อสำเร็จ');
            $scope.employees = response.data;
        }else{
            alert('ดึงรายชื่อไม่สำเร็จ');
        }
    },function(response){
            alert('fail');
    });
}
});