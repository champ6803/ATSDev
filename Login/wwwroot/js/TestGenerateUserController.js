var app = angular.module("myapp", []); 
app.controller("TestGenerateUserController", function($scope , $http){

    $scope.emailGen = typeof emailGen != "undefined" ? emailGen ? emailGen : null : null;

$scope.sendData = function(e){
    debugger;
    alert(e.email);
    $window.open('https://localhost:8000/LoginForm/LoginForm', '_blank');
    var url = "https://localhost:5000/api/generateuser/"+e.email;
    $http.get(url).then(function(response){
        if(response.data){
            alert('สร้างสำเร็จ');
            $window.open('https://localhost:8000/LoginForm/LoginForm', '_blank');
        }else{
            alert('สร้างไม่สำเร็จ');
        }
    },function(response){
            alert('fail');
    });
}
});