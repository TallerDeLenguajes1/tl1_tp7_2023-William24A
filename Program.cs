// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora cal = new Calculadora();
double op;
double A,B;
do{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicacion");
    Console.WriteLine("4-Division");
    
    Console.WriteLine("5-Salir");
    Console.WriteLine("Opcion:");

    op = IngresarOption();
    if(op != 9999){
        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese su primer valor a sumar:");
                A = IngresarOption();
                Console.WriteLine("Ingrese su segundo valor a sumar:");
                B = IngresarOption();
                if(A != 9999 && B != 9999){
                    cal.Suma(A);
                    cal.Suma(B);
                    Console.WriteLine("El valor de la suma es: "+cal.Resultado);
                    cal.Limpiar();
                }else{
                    Console.WriteLine("Error.");
                }
                
                break;
            case 2:
                Console.WriteLine("Ingrese su primer valor a restar:");
                A = IngresarOption();
                Console.WriteLine("Ingrese su segundo valor a restar:");
                B = IngresarOption();
                if(A != 9999 && B != 9999){
                    cal.Suma(A);
                    cal.Restar(B);
                    Console.WriteLine("El valor de la resta es: "+cal.Resultado);
                    cal.Limpiar();
                }else{
                    Console.WriteLine("Error.");
                }
                
                break;
            case 3:
                Console.WriteLine("Ingrese su primer valor a multipilcar:");
                A = IngresarOption();
                Console.WriteLine("Ingrese su segundo valor a multiplicar:");
                B = IngresarOption();
                if(A != 9999 && B != 9999){
                    cal.Suma(A);
                    cal.Multiplicar(B);
                    Console.WriteLine("El valor de la multiplicacion es: "+cal.Resultado);
                    cal.Limpiar();
                }else{
                    Console.WriteLine("Error.");
                }
                
                break;
            case 4:
                Console.WriteLine("Ingrese su valor a divir:");
                A = IngresarOption();
                Console.WriteLine("Ingrese su divisor:");
                B = IngresarOption();
                if(A != 9999 && B != 9999 && B != 0){
                    cal.Suma(A);
                    cal.Dividir(B);
                    Console.WriteLine("El valor de la division es: "+cal.Resultado);
                    cal.Limpiar();
                }else{
                    Console.WriteLine("Error.");
                }
                
                break;
            default:
                Console.WriteLine("Valor erroneo, ingrese nuevamente la opcion.");
                break;
        }
    }
    
}while(op < 5);

double IngresarOption(){
    double op;
    if(double.TryParse(Console.ReadLine(), out op)){
        return op;
    }else{
        Console.WriteLine("Error");
        return 9999;
    }
}