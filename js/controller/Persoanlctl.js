app.controller('Personalctl', ['getPersonDate','$scope',function perosonalctl(getPersonDate,$scope) {
    $scope.name = 'mehdiiiii';
    var main = this;
    this.plist = [];
    getPersonDate.success(function (data) {
        main.plist = data;
    });
 }]);

 
 