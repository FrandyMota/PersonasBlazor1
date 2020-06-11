using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonasBlazor1.BLL;
using PersonasBlazor1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasBlazor1.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Personas persona = new Personas();
            persona.PersonaId = 0;
            persona.Nombre = "prueba";
            persona.Cedula = "40215682997";
            persona.Direccion = "cotui";
            persona.Telefono = "8096578942";
            persona.Balance = 0;
            paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);
          
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Personas persona = new Personas();
            persona.PersonaId = 0;
            persona.Nombre = "prueba";
            persona.Cedula = "40215682997";
            persona.Direccion = "cotui";
            persona.Telefono = "8096578942";
            persona.Balance = 0;
            paso = PersonasBLL.Eliminar(persona.PersonaId);
            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {            
            Personas persona = new Personas();
            persona.PersonaId = 0;
            persona.Nombre = "prueba";
            persona.Cedula = "40215682997";
            persona.Direccion = "cotui";
            persona.Telefono = "8096578942";
            persona.Balance = 0;
            PersonasBLL.Buscar(1);
            
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Personas> lista = PersonasBLL.GetList();

            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GetListTest1()
        {
            List<Personas> lista = PersonasBLL.GetList();

            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Personas persona = new Personas();
            persona.PersonaId = 0;
            persona.Nombre = "prueba";
            persona.Cedula = "40215682997";
            persona.Direccion = "cotui";
            persona.Telefono = "8096578942";
            persona.Balance = 0;
            PersonasBLL.Existe(1);
        }
    }
}