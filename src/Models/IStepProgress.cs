namespace SAS.HierarchicalProgress.Models
{
    /// <summary>
    /// A base (indeterminate) step progress type
    /// </summary>
    public interface IStepProgress
    {
        /// <summary>
        /// Step associated with this progress report
        /// </summary>
        IStepBase Step { get; }
    }
}
