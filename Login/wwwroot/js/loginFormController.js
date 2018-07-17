var app = angular.module("myapp", []); 
app.controller("LoginFormController", function($scope , $http){

    $scope.loginForm =null;

$scope.login= function(e){
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