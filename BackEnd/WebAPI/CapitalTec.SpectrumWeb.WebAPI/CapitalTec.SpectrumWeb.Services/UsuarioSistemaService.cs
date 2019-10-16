using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalTec.SpectrumWeb.Data;
using CapitalTec.SpectrumWeb.Entities;

namespace CapitalTec.SpectrumWeb.Services
{
    public class UsuarioSistemaService
    {
        UsuarioSistemaData objUsuarioSistemaData;
        public UsuarioSistemaService() {
            objUsuarioSistemaData = new UsuarioSistemaData();
        }

        public object getUsuarioSistema() {
            return objUsuarioSistemaData.getUsuarioSistema();
        }

        public object getUsuarioSistema_byID(UsuarioSistema paramObj) {
            return objUsuarioSistemaData.getUsuarioSistema_byID(paramObj);
        }
    }
}
