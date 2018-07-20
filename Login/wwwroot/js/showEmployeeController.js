var app = angular.module("myapp", []); 


app.controller("ShowEmployeeController", function($scope , $http){

    $scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;

$scope.init= function(){
    debugger;
var req ={ 
        method:"GET",
        url:"https://localhost:5001/api/values",
        headers : {
            'Content-Type' : 'application/json'
        }
    }
    $http(req).then(function(response){
        
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