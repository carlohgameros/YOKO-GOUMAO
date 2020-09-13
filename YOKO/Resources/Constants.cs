using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Resources
{
    public static class Constants
    {
        public static String isServicesActiveString= "";
        public static String currentServices = "";
        public static String legalServices = "select top 1 * from tblDatosFiscales order by id desc";
        public static String sellsCount = "SELECT top 1 Factura FROM tblFacturas order by Factura desc";
        public static String petRegister = "select * from tblPetRegister where petID = '";
        public static String petRegisterOnlyData = "select [description],[date] from tblPetRegister where petID = '";
        public static String clientList = "SELECT * FROM tblClientes where NombreComercial like '%";
        public static String usersList = "select* from tblUsers where UsrName like '%";
    }
}
