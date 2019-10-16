using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalTec.SpectrumWeb.Entities;

namespace CapitalTec.SpectrumWeb.Data
{
    public class UsuarioSistemaData
    {
        Database _localDbDefaul;

        public UsuarioSistemaData() {
            DatabaseProviderFactory providerFactoryDefault = new DatabaseProviderFactory();
            _localDbDefaul = providerFactoryDefault.CreateDefault();
        }


        public object getUsuarioSistema()
        {

            object[] Parameters = new object[] { };
            IRowMapper<UsuarioSistema> EntidadFileMapper = MapBuilder<UsuarioSistema>
                .MapNoProperties()
                .MapByName(prop => prop.CodRol)
                .MapByName(prop => prop.CodFuncion)
                .MapByName(prop => prop.DescripRol)
                 .Build();

            var listEntidad = _localDbDefaul.ExecuteSprocAccessor("TEST_SELECT", EntidadFileMapper, Parameters);
            return listEntidad.ToList();
        }

        public List<UsuarioSistema> getUsuarioSistema_byID(UsuarioSistema paramOBJ)
        {

            object[] Parameters = new object[] { paramOBJ.CodRol};
            //IRowMapper<UsuarioSistema> EntidadFileMapper = MapBuilder<UsuarioSistema>
            //    .MapNoProperties()
            //.MapByName(prop => prop.CODREGISTRO)
            //.MapByName(prop => prop.FECHAEMISION)
            //     .Build();

            var listEntidad = _localDbDefaul.ExecuteSprocAccessor<UsuarioSistema>("TEST_SELECT_BYID", Parameters);
            return listEntidad.ToList();
        }
    }
}
