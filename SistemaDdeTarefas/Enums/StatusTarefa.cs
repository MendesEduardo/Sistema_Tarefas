using System.ComponentModel;

namespace SistemaDdeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Cl=oncluido")]
        Concluido = 3,
    }
}
