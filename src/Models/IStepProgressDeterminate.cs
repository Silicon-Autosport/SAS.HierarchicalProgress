namespace SAS.HierarchicalProgress.Models
{
    /// <summary>
    /// An extension that adds a determinate progress to IStepProgress
    /// </summary>
    public interface IStepProgressDeterminate : IStepProgress
    {
        /// <summary>
        /// Current progress value
        /// </summary>
        public decimal Current { get; }

        /// <summary>
        /// Maximum/final expected progress value
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Calculated ratio of Current/Total (0.00 - 1.00)
        /// </summary>
        /// <remarks>
        /// Although this could technically just be Current/Total, some implementations might want to 
        /// linearize speed differences in parts of the procedure by applying weights
        /// </remarks>
        public decimal ProgressRatio { get; }
    }
}
