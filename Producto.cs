namespace PPLabo2_2D
{
    public class Producto
    {
        private EProdcuto tipoDeProducto;
        private float precioPorKilo; //heladera
        private float cantidadDeKilos; //heladera
        private string nombre;
        private static int codigoDeProducto = 0;
        private float cantidadSolicitada;
        private float precioPorCantidad;

        public Producto()
        {

        }
        public Producto(EProdcuto tipoDeProducto, float precioPorKilo, float cantidadDeKilos, string nombre)
        {
            this.tipoDeProducto = tipoDeProducto;
            this.precioPorKilo = precioPorKilo;
            this.cantidadDeKilos = cantidadDeKilos;
            this.nombre = nombre;
            codigoDeProducto++;
            this.cantidadSolicitada = 0;
            this.precioPorCantidad = 0;
        }

        public EProdcuto TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
        public float PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }
        public float CantidadDeKilos { get => cantidadDeKilos; set => cantidadDeKilos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CodigoDeProducto { get => codigoDeProducto;}       
        
        public float CantidadSolicitada { get => cantidadSolicitada; }
        public float PrecioPorCantidad { get => precioPorCantidad; }

        public override string ToString()
        {
            return $"{TipoDeProducto} - {Nombre} - ${PrecioPorKilo} - Stock: {CantidadDeKilos} Kg.";
        }

        public bool SetearCantidadSolicitada(float cantidadSolicitada)
        {
            this.cantidadSolicitada = cantidadSolicitada;

            return true;
        }

        public bool SetearPrecioPorCantidadSolicitada(float precioPorCantidad)
        {
            this.precioPorCantidad = precioPorCantidad;

            return true;
        }


    }
}