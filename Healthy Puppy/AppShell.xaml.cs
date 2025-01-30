namespace Healthy_Puppy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ControlMedicoPage), typeof(ControlMedicoPage));
            Routing.RegisterRoute(nameof(DiagnosticoPage), typeof(DiagnosticoPage));
            Routing.RegisterRoute(nameof(CalendarioPage), typeof(CalendarioPage));
            Routing.RegisterRoute(nameof(ConfiguracionPage), typeof(ConfiguracionPage));
            Routing.RegisterRoute(nameof(InfoPerroPage), typeof(InfoPerroPage)); // Asegúrate de registrar esta ruta
        }
    }
}
