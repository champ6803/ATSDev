var app = angular.module("myapp", []); 
app.controller("RegisterFormController", function($scope , $http){
    $scope.registerForm = null;
$scope.sendData= function(e){
    debugger;
    alert(e);
    // var req ={
    //     url="",
    //     data = e
    // }
    // $http.post(req).then(function(response){
    //     if(response.data){
    //         alert('บันทึกสำเร็จค่ะ');
    //     }else{
    //         alert('บันทึกไม่สำเร็จค่ะ');
    //     }
    // },function(response){
    //         alert('fail');
    // });
}
});