objectName.propertyName

var myObj = new Object(),
    str = 'myString',
    rand = Math.random(),
    obj = new Object();

myObj.type                 = 'Sintaxis de puntos';
myObj['fecha de creación'] = 'Cadena con espacios';
myObj[str]                 = 'Valor de cadena';
myObj[rand]                = 'Número aleatorio';
myObj[obj]                 = 'Object';
myObj['']                  = 'Incluso una cadena vacía';

console.log(myObj);

var propertyName = 'make';
myCar[propertyName] = 'Ford';

propertyName = 'model';
myCar[propertyName] = 'Mustang';

function showProps(obj, objName) {
  var result = ``;
  for (var i in obj) {
    // obj.hasOwnProperty() se usa para filtrar propiedades de la cadena de prototipos del objeto
    if (obj.hasOwnProperty(i)) {
      result += `${objName}.${i} = ${obj[i]}\n`;
    }
  }
  return result;
}

myCar.make = Ford
myCar.model = Mustang
myCar.year = 1969
