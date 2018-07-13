var app = angular.module("myShoppingList", []); 
app.controller("FormController", function($scope){
    $scope.form = {
        email = '',
        fullname = '',
        skill =''
    }
$scope.sendDatac= function(e){
    alert(e);
}
});