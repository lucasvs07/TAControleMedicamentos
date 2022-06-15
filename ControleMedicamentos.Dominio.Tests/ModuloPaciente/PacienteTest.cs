using ControleMedicamentos.Dominio.ModuloPaciente;
using FluentValidation.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.Dominio.Tests.ModuloPaciente
{
    [TestClass]
    public class PacienteTest
    {
        [TestMethod]
        public void Caso_Nome_Nulo()
        {
            Paciente paciente = new(null, "256874598632145");

            ValidadorPaciente pacienteTest = new();

            ValidationResult resultado = pacienteTest.Validate(paciente);

            Assert.AreEqual("Preencha o campo nome.", resultado.Errors[0].ErrorMessage);
        }

        [TestMethod]
        public void Caso_Nome_Vazio()
        {
            //arrange
            Paciente paciente = new("", "254785478965125");

            ValidadorPaciente pacienteTest = new();

            //action
            ValidationResult resultado = pacienteTest.Validate(paciente);

            //assert
            Assert.AreEqual("Preencha o campo nome.", resultado.Errors[0].ErrorMessage);
        }


    }
}
