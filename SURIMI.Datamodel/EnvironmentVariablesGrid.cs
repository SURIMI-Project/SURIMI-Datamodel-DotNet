namespace SURIMI.Datamodel
{
    public class EnvironmentVariablesGrid
    {
        public string? VariableCode { get; set; }

        public List<EnvironmentVariablesCell> EnvironmentVariablesCells { get; set; } = new List<EnvironmentVariablesCell>();
    }
}
