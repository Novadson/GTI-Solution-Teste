using System.ComponentModel;

namespace Projeto_API.Enum
{
    public enum EstadosCivis
    {
        [Description("Solteiro(a)")]
        Solteiro,
        [Description("Casado(a)")]
        Casado,
        [Description("Divorciado(a)")]
        Divorciado,
        [Description("Viúvo(a)")]
        Viúvo,
        [Description("Separado(a) judicialmente")]
        Separado
    }
}
