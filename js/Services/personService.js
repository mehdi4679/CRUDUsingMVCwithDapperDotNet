 //app.factory('getPersonDate', ['$http', function ($http) {
 //   return $http.get('http://localhost:50236/js/Services/person.json')
 //   .success(function (data) {
 //       return data;
 //   })
 //   .error(function (data) {
 //       return data;
 //   });
 //}])

app.factory('getPersonDate', ['$http', function ($http) {
    return $http.get('/api/PersonApi')
    .success(function (data) {
        return data;
    })
    .error(function (data) {
        return data;
    });
 }])


