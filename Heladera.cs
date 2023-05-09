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

        public bool ActualizarProductoEnLalista(Producto producto)
        {
            if (producto is not null)
            {
              //foreach (Producto p in this.listaProducto)
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

        public bool ActualizarCantidad (Producto producto)
        {
            foreach (Producto p in this.listaProducto)
            {
                if(p.CodigoDeProducto == producto.CodigoDeProducto)
                {                   
                    if (p.CantidadDeKilos>= producto.CantidadDeKilos)
                    {
                        p.CantidadDeKilos -= producto.CantidadDeKilos;
                        
                        return true;
                    }                                        
                }                
            }
            return false;
        }

        public bool DisponibilidadProducto (Producto producto)
        {
            foreach (Producto p in this.listaProducto)
            {
                if (p.CodigoDeProducto == producto.CodigoDeProducto && p.CantidadDeKilos >= producto.CantidadDeKilos)
                {
                    return true;               
                }
            }
            return false;
        }
        public bool ActualizarProductosDeLaHeladera(List<Producto> producto)
        {
            if (producto is not null)
            {
                this.listaProducto = producto;
                return true;
            }
            return false;
        }

    }
    }
