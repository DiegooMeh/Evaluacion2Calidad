using System;
using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSoulGlo
{
    [TestClass]
    public class UnitTestAuxCategoria
    {

        [TestMethod]
        public void TestAgregarCategoriaComoObjeto()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaConParametros()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = 2;
            var Nombre = "Shampoo";
            var Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaConParametrosIdNegativo()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = -8;
            var Nombre = "Shampoo";
            var Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
        [TestMethod]
        public void TestAgregarCategoriaDescripcionSimbolos()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = 2;
            var Nombre = "Shampoo";
            var Descripcion = "!!#%%";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaSoloId()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Idcategoria = 2;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(cat);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void TestAgregarCategoriaSoloNombre()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Nombre = "Shampoo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(cat);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestEliminarCategoria()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Idcategoria = 2;
            cat.Nombre = "Jabon";
            cat.Descripcion = "Buen olor";
            auxCategoria.Agregar(cat);


            var Idcategoria = 2;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Eliminar(Idcategoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void TestEliminarCategoriaConIdNegativo()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Idcategoria = -4;
            cat.Nombre = "Shampoo";
            cat.Descripcion = "Lo mejor";
            auxCategoria.Agregar(cat);

            var Idcategoria = -4;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Eliminar(Idcategoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestEliminarCategoriaConIdNoExistente()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = -110;

            int resultadoEsperado = 0;
            int resultadoObtenido = 1;

            //ACT
            resultadoObtenido = auxCategoria.Eliminar(Idcategoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void TestAgregarCategoriaConNombreNull()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Idcategoria = 3;
            cat.Nombre = null;
            cat.Descripcion = "Lo mejor de lo mejor";

            int resultadoEsperado = 0;
            int resultadoObtenido = 1;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(cat.Idcategoria, cat.Nombre, cat.Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

    }
}