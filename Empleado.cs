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

}