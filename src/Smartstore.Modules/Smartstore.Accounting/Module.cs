using Smartstore.Engine.Modularity;

namespace Smartstore.Accounting
{
    internal class Module : ModuleBase
    {
        public override void Install()
        {
            // Aquí puedes agregar lógica de instalación, por ejemplo:
            // - Registrar configuraciones predeterminadas.
            // - Cargar recursos de idioma.
            // - Crear configuraciones específicas del módulo.

            base.Install();
        }

        public override void Uninstall()
        {
            // Aquí puedes agregar lógica de desinstalación, por ejemplo:
            // - Eliminar configuraciones específicas del módulo.
            // - Borrar recursos de idioma.
            // - Eliminar tablas relacionadas, si corresponde.

            base.Uninstall();
        }
    }
}
