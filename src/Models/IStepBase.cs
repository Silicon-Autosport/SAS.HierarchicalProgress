namespace SAS.HierarchicalProgress.Models
{
    /// <summary>
    /// Base implementation of IStep without the ExecuteAsync return type template
    /// </summary>
    public interface IStepBase
    {
        /// <summary>
        /// Friendly name for the step. Typically for display in the UI
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Getter for the list of steps that will be run as part of ExecuteAsync
        /// </summary>
        public IEnumerable<IStepBase> Steps { get; }
    }
}
