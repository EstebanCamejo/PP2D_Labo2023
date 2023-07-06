using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class Heladera
    {
        private List<Producto> listaProducto;
        public Heladera() 
        {
            this.listaProducto = new List<Producto>();  
        }

        public Heladera(List<Producto> productos) 
        {
            this.listaProducto = productos;
        }

        public List<Producto> ListaProducto
        {
            get { return this.listaProducto; }
            set { this.listaProducto = value;}
        }
        /// <summary>
        /// El metodo recibe un nuevo producto y luego de confirmar que no se encuentra en la lista se guarda en la misma
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public Heladera ActualizarProductoEnLalista(Producto producto, List<Producto>productosHeladera)
        {
            try
            {
                Heladera listaProductoActualizada = new Heladera(productosHeladera);

                if (producto is not null)
                {
                    for (int i = 0; i < listaProductoActualizada.ListaProducto.Count; i++)
                    {
                        if (listaProductoActualizada.ListaProducto[i].Nombre == producto.Nombre)
                        {
                            listaProductoActualizada.ListaProducto[i].CantidadDeKilos -= producto.CantidadSolicitada;

                            return listaProductoActualizada;
                        }
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }

            return null;
        }

        /// <summary>
        /// El metodo recibe un nuevo producto y luego de confirmar que este no existe lo guarda en la lista
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool AgregarProductoALista(Producto producto)
        {
            try
            {
                if (producto is not null)
                {
                    foreach (Producto p in this.listaProducto)
                    {
                        if (p.Nombre == producto.Nombre)
                        {
                            return false;
                            break;
                        }
                    }
                    listaProducto.Add(producto);
                    return true;
                }
            }
            catch (Exception)
            {
                throw; 
            }
            
            return false;   
        }

        public bool SetearNuevaCantidad(float cantidad, Producto producto)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.CodigoDeProducto == producto.CodigoDeProducto)
                {
                    p.CantidadDeKilos += cantidad;
                    return true;
                }
            }
            return false;
        }

        public bool SetearPrecios(float precio, Producto producto)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.CodigoDeProducto == producto.CodigoDeProducto && p.PrecioPorKilo != producto.PrecioPorKilo)
                {
                    p.PrecioPorKilo = precio;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// El metodo recibe un objeto producto con una nueva cantidad seteada por el vendedor y actualiza el stock
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ActualizarCantidad (Producto producto)
        {
            try
            {
                foreach (Producto p in this.listaProducto)
                {
                    if (p.CodigoDeProducto == producto.CodigoDeProducto)
                    {
                        if (p.CantidadDeKilos >= producto.CantidadSolicitada)
                        {
                            p.CantidadDeKilos -= producto.CantidadSolicitada;

                            return true;
                        }
                    }
                }
            }            
            catch (Exception) 
            {
                throw;
            }
            
            return false;
        }

        /// <summary>
        /// El metodo recibe un producto y lo busca en la lista y confirma si la cantidad dispobible puede satisfacer
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool DisponibilidadProducto (Producto producto)
        {
            try
            {
                foreach (Producto p in this.listaProducto)
                {
                    if (p.Nombre == producto.Nombre && p.CantidadDeKilos >= producto.CantidadSolicitada)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }        
            return false;
        }
        /// <summary>
        /// EL metodo recibe un listado actualizado de productos y actualiza su estado
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ActualizarProductosDeLaHeladera(List<Producto> producto)
        {
            try
            {
                if (producto is not null)
                {
                    this.listaProducto = producto;
                    return true;
                }
            }
            catch (Exception) 
            {
                throw;
            }           
            return false;
        }

        public Heladera HeladeraCargada()
        {
            try
            {
                this.listaProducto = CoreDelSistema.Productos;
                return this;
            }
            catch (Exception) 
            {
                throw;
            }                       
        }
        
        public Producto DevolverProducto (int Id)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.CodigoDeProducto == Id)
                {
                    return p;
                }
            }
            return null;
        }

        public Producto DevolverProducto(Producto producto)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.CodigoDeProducto == producto.CodigoDeProducto)
                {                    
                    return p;                    
                }
            }
            return null;
        }

        public Producto DevolverProducto(string nombre)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.Nombre == nombre)
                {
                    return p;
                }
            }
            return null;
        }


    }
    }
