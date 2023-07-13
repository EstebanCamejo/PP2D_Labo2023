using PPLabo2_2D;
namespace PruebasUnitarias2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializarJson_ValidacionDeConversionDeArchivo()
        {
            // Arrange            
            List <Producto> listaTesting = new List<Producto>();            
            listaTesting.Add(new(EProdcuto.vacuno,2300,50, "Bife Ancho"));            
            listaTesting.Add(new(EProdcuto.aves, 2315,50, "Patitas de Pollo"));
            listaTesting.Add(new(EProdcuto.cerdo, 1700,50, "Costilla de Cerdo"));
            listaTesting.Add(new(EProdcuto.preparados, 1990,50, "Hamburguesas de Carne"));
            listaTesting.Add(new(EProdcuto.embutidos, 1975,50, "Chorizo"));

            string mensaje = "La deserializacion JSON no se realizo correctamente";

            // Act
            bool resultado = CoreDelSistema.SerializarProductosJson(listaTesting);

            // Assert
            Assert.AreNotEqual(mensaje,resultado);
        }

        [TestMethod]
        public void CalculadoraDeIva_DevuelveElValorAgregadoAlProducto()
        {
            Factura factura = new Factura();

            // Arrange
            factura.SubtotalFactura = 100;
            float ivaEsperado = 21;

            // Act
            float resultado = factura.CalcularIva();

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