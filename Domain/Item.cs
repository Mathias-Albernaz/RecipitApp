namespace Dominio;

public class Item
{
    public int Cantidad { get; set; }
    public string Descripcion { get; set; }
    public string Identificador { get; set; }

    public override string ToString()
    {
        return Cantidad + "," + Descripcion + "," + Identificador;
    }
}