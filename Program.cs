// See https://aka.ms/new-console-template for more information
// using EspacioCalculadora;

// Calculadora cal = new Calculadora();
// double op;
// double A,B;
// do{
//     Console.WriteLine("Calculadora");
//     Console.WriteLine("1-Suma");
//     Console.WriteLine("2-Resta");
//     Console.WriteLine("3-Multiplicacion");
//     Console.WriteLine("4-Division");
    
//     Console.WriteLine("5-Salir");
//     Console.WriteLine("Opcion:");

//     op = IngresarOption();
//     if(op != 9999){
//         switch (op)
//         {
//             case 1:
//                 Console.WriteLine("Ingrese su primer valor a sumar:");
//                 A = IngresarOption();
//                 Console.WriteLine("Ingrese su segundo valor a sumar:");
//                 B = IngresarOption();
//                 if(A != 9999 && B != 9999){
//                     cal.Suma(A);
//                     cal.Suma(B);
//                     Console.WriteLine("El valor de la suma es: "+cal.Resultado);
//                     cal.Limpiar();
//                 }else{
//                     Console.WriteLine("Error.");
//                 }
                
//                 break;
//             case 2:
//                 Console.WriteLine("Ingrese su primer valor a restar:");
//                 A = IngresarOption();
//                 Console.WriteLine("Ingrese su segundo valor a restar:");
//                 B = IngresarOption();
//                 if(A != 9999 && B != 9999){
//                     cal.Suma(A);
//                     cal.Restar(B);
//                     Console.WriteLine("El valor de la resta es: "+cal.Resultado);
//                     cal.Limpiar();
//                 }else{
//                     Console.WriteLine("Error.");
//                 }
                
//                 break;
//             case 3:
//                 Console.WriteLine("Ingrese su primer valor a multipilcar:");
//                 A = IngresarOption();
//                 Console.WriteLine("Ingrese su segundo valor a multiplicar:");
//                 B = IngresarOption();
//                 if(A != 9999 && B != 9999){
//                     cal.Suma(A);
//                     cal.Multiplicar(B);
//                     Console.WriteLine("El valor de la multiplicacion es: "+cal.Resultado);
//                     cal.Limpiar();
//                 }else{
//                     Console.WriteLine("Error.");
//                 }
                
//                 break;
//             case 4:
//                 Console.WriteLine("Ingrese su valor a divir:");
//                 A = IngresarOption();
//                 Console.WriteLine("Ingrese su divisor:");
//                 B = IngresarOption();
//                 if(A != 9999 && B != 9999 && B != 0){
//                     cal.Suma(A);
//                     cal.Dividir(B);
//                     Console.WriteLine("El valor de la division es: "+cal.Resultado);
//                     cal.Limpiar();
//                 }else{
//                     Console.WriteLine("Error.");
//                 }
                
//                 break;
//             default:
//                 Console.WriteLine("Valor erroneo, ingrese nuevamente la opcion.");
//                 break;
//         }
//     }
    
// }while(op < 5);

// double IngresarOption(){
//     double op;
//     if(double.TryParse(Console.ReadLine(), out op)){
//         return op;
//     }else{
//         Console.WriteLine("Error");
//         return 9999;
//     }
// }

using EspacioEmpleado;
//Cargar en un arreglo la memoria que se necesite
Empleado[] empleados = new Empleado[3];
//Cargar datos en el vector
for (int i=0; i<3;i++)
{   //CArgar datos en el vector
    Console.WriteLine("Ingrese el nombre del empleado: ");
    string nombreE = Console.ReadLine();
    Console.WriteLine("Ingrese el Apellido del empleado: ");
    string apellidoE = Console.ReadLine();
    Console.WriteLine("Ingrese fecha de nacimiento del empleado(y,m,d): ");
    int year = IngresarOption();
    int mes = IngresarOption();
    int dia = IngresarOption();
    DateTime fechaN = new DateTime(year,mes,dia);
    string estadoCivil; 
    do{
        Console.WriteLine("Ingrese el estado civil del empleado (Casado=S)(Soltero=N):");
        estadoCivil = Console.ReadLine();
    }while(estadoCivil != "S" && estadoCivil != "N" );
    string genero;
    do{
        Console.WriteLine("Ingrese el genero del empleado (Varon=M y Mujer=F):");
        genero = Console.ReadLine();
    }while(genero!="M" && genero !="F");

    Console.WriteLine("Ingrese fecha de Ingreso a la empreza del empleado(y,m,d): ");
     year = IngresarOption();
     mes = IngresarOption();
     dia = IngresarOption();
    DateTime fechaI = new DateTime(year,mes,dia);

    Console.WriteLine("Ingrese sueldo basico del empleado:");
    double sueldoB= IngresarOption();
    int op;

    do{
        Console.WriteLine("Ingrese el cargo del empleado:");
        Console.WriteLine("0-Auxuliar");
        Console.WriteLine("1-Administrativo");
        Console.WriteLine("2-Ingeniero");
        Console.WriteLine("3-Especialista");
        Console.WriteLine("4-Investigador");
        Console.WriteLine("Ingresar opcion:");
        op = IngresarOption();
    }while(op>5);
    switch(op){
        case 0: //Para cada uno de los valores en vector hay q reversar memoria 
            empleados[i]= new Empleado(nombreE,apellidoE,fechaN,estadoCivil[0],genero[0],fechaI,sueldoB, Cargo.Auxiliar);
            break;
        case 1:
            empleados[i]= new Empleado(nombreE,apellidoE,fechaN,estadoCivil[0],genero[0],fechaI,sueldoB, Cargo.Administrativo);
            break;
        case 2:
           empleados[i]= new Empleado(nombreE,apellidoE,fechaN,estadoCivil[0],genero[0],fechaI,sueldoB, Cargo.Ingeniero);
            break;
        case 3:
            empleados[i]= new Empleado(nombreE,apellidoE,fechaN,estadoCivil[0],genero[0],fechaI,sueldoB, Cargo.Especialista);
            break;
        case 4:
            empleados[i]= new Empleado(nombreE,apellidoE,fechaN,estadoCivil[0],genero[0],fechaI,sueldoB, Cargo.Investigador);
            break;
    }
    
}
Console.ReadKey();
//Calculo del valor de salarios a pagar
double salarioTotal=0;
for(int i=0; i<3;i++){
    salarioTotal += empleados[i].Salario();
}

Console.WriteLine("El valor del salario total pagado a los tres empleados es de: "+salarioTotal);

//Inverstigar cual valor de juvilacion es menor
Console.ReadKey();
Console.WriteLine("Empleado con fecha mas proxima a juvilarse:");
    if(empleados[0].Antiguedad() < empleados[1].Antiguedad()){
        if(empleados[0].Antiguedad() < empleados[2].Antiguedad()){
            //cargar datos de 0
            MostrarDatos(empleados[0]);
        }else{
            //cargar 2
            MostrarDatos(empleados[2]);
        }
    }else{
        if(empleados[1].Antiguedad() < empleados[2].Antiguedad()){
            //cargo 1
            MostrarDatos(empleados[1]);
        }else{
            //Cargo 2
            MostrarDatos(empleados[2]);
        }
    }

//Funcion que me carga datos a una variable
int IngresarOption(){
     int op;
     if(int.TryParse(Console.ReadLine(), out op)){
        return op;
     }else{
         Console.WriteLine("Error");
         return 9999;
     }
 }
//Funcion mostrar datos
 void MostrarDatos(Empleado ver){
    Console.WriteLine("Nombre del empleado: "+ ver.Nombre);
    Console.WriteLine("Apellido del empleado: "+ ver.Apellido);
    Console.WriteLine("Fecha de nacimiento del empleado: "+ ver.Fechanacimiento);
    Console.WriteLine("Estado civil: "+ ver.Estadocivil);
    Console.WriteLine("Genero: "+ver.Genero);
    Console.WriteLine("Fecha de ingeso a la empresa "+ ver.Fechaingreso);
    Console.WriteLine("Sueldo basico: "+ ver.Sueldobasico);
    Console.WriteLine("Cargo: "+ ver.Cargo);
    Console.WriteLine("Edad: "+ ver.Edad());
    Console.WriteLine("Salario: "+ ver.Salario());
    Console.WriteLine("Años para juvilarse: "+ ver.Juvilacion());
 }