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
}