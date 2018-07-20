var app = angular.module("myapp", []); 
app.controller("EmployeeFormController", function($scope , $http){

    $scope.employeeform ={
        location:'',
        salary:'',
        position:''
    };

$scope.submit= function(e){
    debugger;
    alert(e);
    // var req ={
    //     url="",
    //     data = e
    // }
    // $http.post(req).then(function(response){
    //     if(response.data){
    //         alert('เข้าสู่ระบบสำเร็จ');
    //     }else{
    //         alert('เข้าสู่ระบบไม่สำเร็จ');
    //     }
    // },function(response){
    //         alert('fail');
    // });
}
});