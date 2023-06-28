namespace EspacioEmpleado;

public enum Cargo
{
    Auxiliar,
    Administrativo, 
    Ingeniero, 
    Especialista, 
    Investigador
}
public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechanacimiento;
    private char estadocivil;
    private char genero;
    private DateTime fechaingreso;
    private double sueldobasico;
    private Cargo cargo;

    public Empleado(){

    }
    public Empleado(string nombre, string apellido, DateTime fechanacimiento, char estadocivil, char genero, DateTime fechaingreso, double sueldobasico, Cargo cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechanacimiento = fechanacimiento;
        this.estadocivil = estadocivil;
        this.genero = genero;
        this.fechaingreso = fechaingreso;
        this.sueldobasico = sueldobasico;
        this.cargo = cargo;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad(){
        
        return (DateTime.Today.AddTicks(-Fechaingreso.Ticks).Year-1);
    }

    public int Edad(){
        return (DateTime.Today.AddTicks(-Fechanacimiento.Ticks).Year-1);
    }

    public int Juvilacion(){
        if(Genero == 'M' ){
            return (65-(DateTime.Today.AddTicks(-Fechanacimiento.Ticks).Year-1));
        }else{
            return (60-(DateTime.Today.AddTicks(-Fechanacimiento.Ticks).Year-1));
        }
        
    }

    public double Salario(){
        double adicional;
        if(Antiguedad() >= 20){
            adicional = 0.25 * Sueldobasico;
        }else{
            adicional = 0.01 * Sueldobasico * Antiguedad();
        }

        if(Cargo == Cargo.Ingeniero || Cargo == Cargo.Especialista){
            adicional *= 1.5;
        }

        if(Estadocivil == 'S'){
            adicional += 15000;
        }
        return Sueldobasico + adicional ;
    }
}