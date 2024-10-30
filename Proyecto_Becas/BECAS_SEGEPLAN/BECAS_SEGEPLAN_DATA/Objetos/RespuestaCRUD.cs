using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace BECAS_SEGEPLAN_DATA.Objetos
{
    public class RespuestaCRUD
    {
        public bool Resultado { get; set; }
        public string? Codigo { get; set; }
        public string? Mensaje { get; set; }
        public string? Metodo { get; set; }
        public decimal IdNew { get; set; }

        public string ErrorDB(DbEntityValidationException ex)
        {
            string Respuesta = "";
            foreach (DbEntityValidationResult item in ex.EntityValidationErrors)
            {
                // Get entry

                DbEntityEntry entry = item.Entry;
                string entityTypeName = entry.Entity.GetType().Name;

                // Display or log error messages

                foreach (DbValidationError subItem in item.ValidationErrors)
                {
                    string message = string.Format("Error '{0}' occurred in {1} at {2}", subItem.ErrorMessage, entityTypeName, subItem.PropertyName);
                    Respuesta = Respuesta + message;
                }
            }
            return Respuesta;
        }

    }
}
