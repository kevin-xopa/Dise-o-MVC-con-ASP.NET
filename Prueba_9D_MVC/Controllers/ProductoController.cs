using Prueba_9D_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_9D_MVC.Controllers
{
    public class ProductoController : Controller
    {
        //GET: Producto
        public ActionResult Index()
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    List<producto> lista = bd.producto.Where(a => a.id >= 1).ToList();
                    return View(lista);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al visualizar los productos ", e);
            }
            return View();
        }
        [HttpGet]
        public ActionResult AgregarProducto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarProducto(producto obj)
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    bd.producto.Add(obj);
                    bd.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al insertar el producto ", e);
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditarProducto(int id) 
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    producto producto = bd.producto.Find(id);
                    return View(producto);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al buscar el producto ", e);
            }
            return View();
        }
        [HttpPost]
        public ActionResult EditarProducto(producto obj)
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    producto existe = bd.producto.Find(obj.id);
                    existe.nombre = obj.nombre;
                    existe.precio = obj.precio;
                    existe.descripcion = obj.descripcion;
                    existe.existencia = obj.existencia;
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al editar el producto ", e);
            }
            return View();
        }
        public ActionResult DetallesProducto(int id) 
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    producto existe = bd.producto.Find(id);

                    return View(existe);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al obtener el producto ", e);
            }
            return View();
        }
        public ActionResult EliminarProducto(int id) 
        {
            try
            {
                using (EntityEntities bd = new EntityEntities())
                {
                    producto existe = bd.producto.Find(id);
                    bd.producto.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("ERROR al eliminar el producto ", e);
            }
            return View();
        }     
    }
}