namespace ET;

public class ET_Productos
{
    public int IdProducto
    {
        get => _idProducto;
        set => _idProducto = value;
    }

    public int IdMarca
    {
        get => _idMarca;
        set => _idMarca = value;
    }

    public string DescripcionPr
    {
        get => _descripcionPr;
        set => _descripcionPr = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int IdUnidMed
    {
        get => _idUnidMed;
        set => _idUnidMed = value;
    }

    public int IdCategoria
    {
        get => _idCategoria;
        set => _idCategoria = value;
    }

    public decimal StockMin
    {
        get => _StockMin;
        set => _StockMin = value;
    }

    public decimal StockMax
    {
        get => _StockMax;
        set => _StockMax = value;
    }

    public decimal Pu_venta
    {
        get => _Pu_venta;
        set => _Pu_venta = value;
    }

    private int _idProducto;
    private int _idMarca;
    private string _descripcionPr;
    private int _idUnidMed;
    private int _idCategoria;
    private decimal _StockMin;
    private decimal _StockMax;
    private decimal _Pu_venta;
    
}