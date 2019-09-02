namespace OpenClosedPrinciple.App.Despues
{
    public interface IDespuesPersonaSolicitante
    {
        string Apellido { get; set; }
        string Nombre { get; set; }
        IDespuesCuentaServicio Proceso { get; set; }
    }
}