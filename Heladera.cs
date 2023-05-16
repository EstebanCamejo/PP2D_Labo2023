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
        }
        /// <summary>
        /// El metodo recibe un nuevo producto y luego de confirmar que no se encuentra en la lista se guarda en la misma
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ActualizarProductoEnLalista(Producto producto)
        {
            if (producto is not null)
            {              
                for (int i = 0;i < this.listaProducto.Count;i++) 
                {
                    if (listaProducto[i].CodigoDeProducto==producto.CodigoDeProducto)     
                    {
                        listaProducto[i] = producto;

                        return true;
                        break;
                    }
                }                                
            }
            return false;
        }

        /// <summary>
        /// El metodo recibe un nuevo producto y luego de confirmar que este no existe lo guarda en la lista
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool AgregarProductoALista(Producto producto)
        {
            if(producto is not null)
            {
                foreach(Producto p in this.listaProducto) 
                {
                    if (p.CodigoDeProducto == producto.CodigoDeProducto)
                    {
                        return false;
                        break;
                    }
                }
                listaProducto.Add(producto);    
                return true;
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
            foreach (Producto p in this.listaProducto)
            {
                if(p.CodigoDeProducto == producto.CodigoDeProducto)
                {                   
                    if (p.CantidadDeKilos>= producto.CantidadSolicitada)
                    {
                        p.CantidadDeKilos -= producto.CantidadSolicitada;
                        
                        return true;
                    }                                        
                }                
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
            foreach (Producto p in this.listaProducto)
            {
                if (p.Nombre == producto.Nombre && p.CantidadDeKilos >= producto.CantidadSolicitada)
                {
                    return true;               
                }
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
            if (producto is not null)
            {
                this.listaProducto = producto;
                return true;
            }
            return false;
        }

        public Heladera HeladeraCargada()
        {
            this.listaProducto = CoreDelSistema.Productos;

            return this;
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
