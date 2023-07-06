using PPLabo2_2D;
namespace PruebasUnitarias2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeserializarJson_ValidacionDeConversionDeArchivo()
        {
            // Arrange
            Producto producto = new Producto();
            string mensaje = "La deserializacion JSON no se realizo correctamente";

            // Act
            string resultado = producto.DeSerializarJson();
            
            // Assert

            Assert.AreNotEqual(mensaje,resultado);
        }

        [TestMethod]
        public void CalculadoraDeIva_DevuelveElValorAgregadoAlProducto()
        {
            Factura factura = new Factura();

            // Arrange
            float subtotal = 100;
            float ivaEsperado = 21;

            // Act
            float resultado = factura.CalcularIva(subtotal);

            // Assert
            Assert.AreEqual(ivaEsperado, resultado);

        }

        [TestMethod]
        public void PagarFactura_DevuelveUnBooleanoComprobandoSiElCLientePuedePagar()
        {
            // Arrange
            float billeteraInicial = 1000;
            float totalFactura = 500;

            Cliente cliente = new Cliente("UsuarioTest","ContraseniaTest","NombreCLienteTest");
            cliente.Billetera = billeteraInicial;

            Factura factura = new Factura();
            factura.TotalFactura = totalFactura;

            // Act
            bool result = cliente.PagarFactura(factura);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(billeteraInicial - totalFactura, cliente.Billetera);
        }
    }
    
}