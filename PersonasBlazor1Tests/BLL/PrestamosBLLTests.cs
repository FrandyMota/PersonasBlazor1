using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonasBlazor1.BLL;
using PersonasBlazor1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasBlazor1.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Prueba";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 100;
            paso = PrestamosBLL.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoId = 1;
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Prueba Modificada";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 100;
            paso = PrestamosBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();
            prestamos.PrestamoId = 0;
            prestamos.Monto = 200;
            prestamos.Balance = 200;
            prestamos.Concepto = "abs";
            paso = PrestamosBLL.Eliminar(prestamos.PrestamoId);
            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {            
            Prestamos prestamos = new Prestamos();
            prestamos.PrestamoId = 0;
            prestamos.Monto = 200;
            prestamos.Balance = 200;
            prestamos.Concepto = "abs";
            PrestamosBLL.Buscar(1);           
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Prestamos> lista = PrestamosBLL.GetList();

            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GetListTest1()
        {
            List<Prestamos> lista = PrestamosBLL.GetList();

            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Prestamos prestamos = new Prestamos();
            prestamos.PrestamoId = 0;
            prestamos.Monto = 200;
            prestamos.Balance = 200;
            prestamos.Concepto = "abs";
            PrestamosBLL.Existe(1);
        }
    }
}