var app = angular.module('myapp',['ngRoute']);
 
app.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateurl: '/Views/Person/viewp.cshtml',
        controller: 'Personalctl'
    })
    .otherwise({
        templateurl: '/Views/Person/viewp.cshtml'
    });

});



 



