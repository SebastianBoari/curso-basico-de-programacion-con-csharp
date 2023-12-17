/*
Curso basico de programacion con C#



¿Por que aprender C#?

Aprender C# es importante debido a su popularidad, versatilidad, facilidad de aprendizaje, 
y su demanda en el mercado laboral.

Es un lenguaje de programación popular y versátil que se utiliza en una variedad de aplicaciones,
incluyendo desarrollo de juegos, aplicaciones de escritorio y móviles, y desarrollo web.

Es un lenguaje de programación de Microsoft, lo que significa que es compatible con una variedad 
de herramientas y tecnologías de Microsoft, como Visual Studio y .NET Framework.

Es un lenguaje de programación moderno que tiene una sintaxis fácil de aprender y ofrece 
características avanzadas, como programación orientada a objetos y manejo automático de memoria.



C# es un lenguaje orientado a objetos, concepto que se ahondara
en el proximo curso de Programacion Orientada a Objetos (POO) con C# 
 


¿Que es .NET?

Es una plataforma de desarrollo, lo que significa que basicamente es un conjunto de lenguajes,
librerias, herramientas, y otras plataformas, .net es todo un ecosistema de desarrollo, es grats y de codigo abierto y con .net podemos desarrollar todo tipo de aplicaciones.

Podemos desarrollar desde aplicaciones moviles, aplicaciones web, machine learning, 
desarrollo de juegos, aplicaciones en la nube, entre otras.

_.NET soporta principalmente 3 lenguajes de programacion, esto significa que podemos 
escribir aplicaciones .net en cualquiera de estos lenguajes.

    VISUAL BASIC

    C#

    F#



¿Qué son los algoritmos?

Un algoritmo es un conjunto de instrucciones que resuelven 
un problema paso a paso y sin ambiguedades.

Por ejemplo para hacer una pizza hay ciertos pasos a realizar y en un cierto orden especifico
para terminar de preparar una pizza.



Instalando Visual Studio 2022

Visual studio es un IDE, vamos a utilizar Visual Studio 2022 en su version 
gratuita Community Edition

Es el IDE por defecto para .NET y nos ofrece multiples herramientas para
que podamos desarrollar lo que queramos de forma sencilla.

Tambien es muy utilizado para el lenguaje de bajo nivel C++ pero tambien nos brinda la posibilidad
de trabajar con lenguajes de alto nivel muy populares como Python y Javascript

Al instalar Visual Studio nos proporciona conjuntos predefinidos de herramientas y recursos
agrupados en lo que se denominan 'cargas de trabajo'.

Estas cargas de trabajo son paquetes especializados que contienen herramientas,
bibliotecas y soporte para diferentes tipos de desarrollo y lenguajes de programación.

Al seleccionar una carga de trabajo específica durante la instalación, garantizamos 
que la instalación incluya todas las herramientas necesarias para desarrollar proyectos
en un ámbito particular, evitando la necesidad de instalar componentes por separado.



Tipos de datos primitivos

Si bien existen mas tipos de datos los mas importantes y que necesitamos
tener presente en la mayoria de casos son los siguientes:

|------------------|------------------------|-------------------|-------------------------------|
|-- Tipo de dato --|-- Espacio en memoria --|--     Rango     --|--         Descripcion       --|
|------------------|------------------------|-------------------|-------------------------------|
|--      int     --|--       4 bytes      --|-- -2147483648 a --|-- Almacena numeros enteros. --|
|                  |                        |     2147483648    |                               |
|------------------|------------------------|-------------------|-------------------------------|
|--     bool     --|--        1 bit       --|--     0 a 1     --|--    verdadero o falso.     --|
|------------------|------------------------|-------------------|-------------------------------|
|--     float    --|--      4 bytes       --|-- 6 a 7 digitos --|--    numeros decimales.     --|
|------------------|------------------------|-------------------|-------------------------------|
|--     double   --|--      8 bytes       --| hasta 15 digitos -|--    numeros decimales.     --|
|------------------|------------------------|-------------------|-------------------------------|
|--     char     --|--      2 bytes       --|-- 1 caracter    --|--    caracter o letra       --|
|------------------|------------------------|-------------------|-------------------------------|
|--    string    --|--2 bytes por caracter--|--  na           --|--   caracteres o letras     --|
|------------------|------------------------|-------------------|-------------------------------|
|--    long      --|--       8 bytes      --|-- +/- 92233720  --|--      Numeros enteros      --|
|                  |                        |  3685477580-7/8   |                               |         
|------------------|------------------------|-------------------|-------------------------------|
|--    unit      --|--       4 bytes      --|-- 0 a 4294967295--|-- Numeros enteros positivos --|        
|------------------|------------------------|-------------------|-------------------------------|


 */
// |-----------------------------------------------------------------------------------|



// Programa que calcula el area de un rectangulo (Lado A x Lado B)

// Declaramos las variables. En C#, el tipado es fuerte, por lo tanto,
// especificar el tipo de dato es obligatorio.

using System.Runtime.InteropServices;

int ladoA;
int ladoB;
int resultado;

// Todas las líneas de código deben finalizar con un punto y coma (;).

// Console.WriteLine muestra el texto que queramos en consola.
Console.WriteLine("Calcula el area de un rectangulo.");

// Obtenemos el lado A.
Console.WriteLine("Ingrese el valor del lado A");
// Leemos la entrada del usuario con "Console.ReadLine()" desde la consola
// y la convertimos a un tipo de dato entero con el metodo que nos facilita C# "Convert.ToInt32()".
ladoA = Convert.ToInt32(Console.ReadLine());

// Obtenemos el lado B.
Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());

// Realizamos la operacion matematica. Los operadores matematicos soportados por C# son:
// + - * /
resultado = ladoA * ladoB;

// Podemos interpolar texto y variables usando un string interpolado.
// Anteponiendo el signo dolar a las comillas y agregando llaves {} a la variable
// que queramos representar en el texto.
Console.WriteLine($"El area del rectangulo es: {resultado}");

// Tambien podemos unir texto y variables como en otros muchos lenguajes de programacion
// utilizando operadores matematicos. (concatenando).
string saludo = "Muchas gracias por todo!!";
Console.WriteLine("Usted ya sabe el area de su rectangulo. " + saludo);


// |-----------------------------------------------------------------------------------|


// VAR

// 'var' se utiliza para inferir el tipo de una variable de manera implícita.

// Al declarar una variable con 'var', es obligatorio inicializarla con un valor, ya que es así como
// C# determina el tipo de dato que tomará la variable.

var ladoA2 = 0;
var ladoB2 = 0;
var resultado2 = 0;

// Una vez que la variable ha sido declarada e inicializada, su tipo no puede cambiar.

// Por ejemplo: ladoA2 = "string";

// Esto generaría un error, ya que al inicializarse con el valor "0", C# infiere que la variable es de tipo entero "int"
// y no puede ser asignada a un tipo de dato diferente, como un string o un char.



// |-----------------------------------------------------------------------------------|


// Programa que calcula el área de un círculo (Pi x radio al cuadrado)


double radio;

// Si deseamos utilizar 'var' y que el tipo de dato que se infiera sea 'double',
// en lugar de dar el valor "0" (que C# interpretaría como entero) o "1.1",
// utilizamos "0d" para asegurar que la variable sea inferida como double. 
var resultado3 = 0d;

double resultado3b;

Console.WriteLine("Calcula el area de un circulo.");

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

// Por defecto C# nos provee la clase Math, la cual nos brinda un valor por defecto del numero PI

// Si ponemos el mouse sobre Math.PI veremos como nos indica que PI es una constante del tipo double
// Las constantes son variables a las que no se le puede volver a reasignar un valor.
const double Pi = 3.14;

// La convencion sobre las constante es que hay que nombrarlas con PascalCase, siempre la primera
// letra es mayuscula y en cada nueva palabra tambien empezarla con mayuscula.

resultado3 = Math.PI * (radio * radio);

resultado3b = Pi * (radio * radio);

// Llegaremos al mismo resultado de esta manera: "Math.PI * radio * radio" (Sin indicar parentesis)
// ya que C# 

Console.WriteLine($"El valor mas cercano al area del circulo es: {resultado3}");

Console.WriteLine($"Pero tambien se puede redondear: {resultado3b}");


// |-----------------------------------------------------------------------------------|


// IMPORTANTE:
// Vieron que VisualStudio utiliza la extension .sln?
// Visual studio llama a sus proyectos como "soluciones" y sln viene de solution.


// Operadores de asignacion

// Los operadores de asignación en C# son símbolos que se utilizan para asignar
// valores a variables. Estos operadores permiten modificar el valor de una 
// variable mediante la asignación de un nuevo valor. Aquí tienes algunos ejemplos de 
// operadores de asignación en C#:


// 1. Asignación básica (=): El operador de asignación básica (=) 
// se utiliza para asignar un valor a una variable. 
// Por ejemplo:

int x = 5; // Asigna el valor 5 a la variable x


// 2. Asignación compuesta (+=, -=, =, /=, %=): Estos operadores combinan una 
// operación aritmética con la asignación.Son atajos para realizar una operación 
// y asignar el resultado a la misma variable. 
// Por ejemplo:

int y = 10;
y += 5; // Equivale a y = y + 5;


// 3. Operadores de incremento y decremento (++ y --): Estos operadores incrementan 
// o decrementan el valor de una variable en una unidad. 
// Pueden ser utilizados como sufijos o prefijos. 
// Por ejemplo:

int z = 8;
z++;


// 4. Operador de asignación condicional (??=): Este operador asigna el valor a una 
// variable solo si la variable es null. 
// Por ejemplo:

string cadena = null;
cadena ??= "valor por defecto";

// Estos son algunos de los operadores de asignación más comunes en C#. 
// Cada uno tiene su propósito y simplifica la escritura de código al combinar la asignación 
// con otras operaciones.


// |-----------------------------------------------------------------------------------|



// Operadores Aritmeticos

// Suma +
int suma1 = 1;
int suma2 = 2;

int suma = suma1 + suma2; // El resultado es 3

// Resta -
int resta1 = 1;
int resta2 = 2;

int resta = resta2 + resta1; // El resultado es 1

// Division /
int division4 = 4;
int division2 = 2;

int division = division4 / division2; // El resultado es 2

// Multiplicacion *
int multiplicacion4a = 4;
int multiplicacion4b = 2;

int multiplicacion = multiplicacion4a * multiplicacion4b; // El resultado es 16

// Resto (nos da el resto de una division) %
int resto4 = 4;
int resto2 = 2;

int resto = resto4 % resto2; // El resutlado es 0

// |-----------------------------------------------------------------------------------|


// Operadores Logicos

// Los operadores lógicos son herramientas clave en programación que permiten combinar 
// condiciones para evaluar expresiones booleanas. 
// En C#, estos operadores ayudan a construir lógica condicional en el código.


// && (AND): Este operador devuelve verdadero (true) si ambas condiciones que conecta 
// son verdaderas. Si una o ambas son falsas, el resultado será falso. 
// Por ejemplo:

// Si queremos comprar pan en el almacen de nuestro barrio tendriamos que considerar
// que el almacen este abierto y que tengamos dinero.
// Estas dos condiciones deben ser verdaderas para que yo pueda ir a comprar el pan.
bool estaAbierto = false;
bool tengoDinero = true;

bool comprarPan = estaAbierto && tengoDinero; // Devuelve false porque el almacen no esta abierto

// || (OR): El operador OR devuelve verdadero si al menos una de las condiciones es verdadera. 
// Si ambas son falsas, el resultado será falso. 
// Por ejemplo:

// Si queremos hacer actividad fisica podriamos salir a caminar o ir al gimnasio
// solo con poder hacer una de las dos actividades ya podemos realizar actividad fisica

bool salirACaminar = true;
bool irAlGimnasio = false;

bool actividadFisica = salirACaminar || irAlGimnasio; // Devuelve true porque al menos una
// condicion es verdadera


// ! (NOT): Este operador invierte la condición booleana. 
// Si una condición es verdadera, el operador NOT la convierte en falsa y viceversa. 
// Por ejemplo:

// Si queremos saber si un restaurante esta cerrado podemos saberlo aplicando la siguiente logica

bool estaAbiertoElRestaurante = false;

bool elRestauranteEstaCerrado = !estaAbiertoElRestaurante; // Será true porque el restaurante
                                                           // no está abierto


// ^ (XOR): El operador XOR devuelve verdadero si una y solo una de las condiciones es verdadera, 
// pero no ambas. 
// Por ejemplo:

// Nos invitan a navegar por el rio el domingo y un amigo nos invita de campamento durante
// todo el fin de semana. Solo podemos aceptar una invitacion.

bool aceptarNavegar = true;
bool aceptarCampamento = true;

bool planesDelFinDeSemana = aceptarNavegar ^ aceptarCampamento; // Será false porque no podemos
// aceptar ambas invitaciones.


bool aceptarNavegar2 = false;
bool aceptarCampamento2 = true;

bool planesDelFinDeSemana2 = aceptarNavegar2 ^ aceptarCampamento2; // Será true porque has aceptado
// solo una invitacion.


// |-----------------------------------------------------------------------------------|


// Operadores Relacionales

// Declaremos las variables que utilizaremos en los ejemplos:
int uno = 1;
int dos = 2;
int tres = 3;
int cuatro = 4;
int cinco = 5;

// Tambien podemos declarar muchas variables en una sola linea:
var (uno1, dos2, tres3, cuatro4, cinco5) = (1, 2, 3, 4, 5);

// Igual a (==)
bool esIgualA = dos == tres; // Será false ya que dos no es igual a tres

// Diferente a (!=)
bool esDiferenteA = dos != tres; // Será true ya que dos es diferente a tres

// Mayor que (>)
bool esMayorQue = dos > tres; // Será false ya que dos no es mayor que tres

// Menor que (<)
bool esMenorQue = uno < cinco; // Será true ya que uno es menor a cinco

// Mayor o igual a (>=)
bool esMayorOIgualQue = dos >= dos; // Será true ya que son iguales 

// Menor o igual a (<=)
bool esMenorOIgualQue = cuatro <= cinco; // Será true porque cuatro es menor a cinco


// |-----------------------------------------------------------------------------------|


// Condicionales

// En la programacion, como en la vida cotidiana, debemos tomar decisiones y evaluar condiciones.
// Por ejemplo:

// Si eres mayor de edad puedes pasar al club
// Si tengo el dinero puedo hacer la compra

// Sentencia IF ELSE

int edad = 39;

if (edad > 18)
{
    Console.WriteLine("Puedes pasar");
}
else
{
    Console.WriteLine("No puedes pasar");
}

double dinero = 43.2;

if (dinero > 999.99) 
{
    Console.WriteLine("Puedes hacer la compra");
}
else
{
    Console.WriteLine("Puedes hacer la compra");
}


// Sentencia Switch

// Si bien se dice mucho que el switch ya no se usa pero aun tiene sus casos de uso
// como por ejemplo las maquinas de estado.


// |-----------------------------------------------------------------------------------|



// |-----------------------------------------------------------------------------------|