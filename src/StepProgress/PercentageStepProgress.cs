using SAS.HierarchicalProgress.Models;

namespace SAS.HierarchicalProgress.StepProgress
{
    /// <summary>
    /// Percentage-based progress reporting
    /// </summary>
    public class PercentageStepProgress : IStepProgressDeterminate
    {
        /// <summary>
        /// Percentage-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        public PercentageStepProgress(IStepBase step)
        {
            this.Step = step;
            this.Current = 0.00M;
        }

        /// <summary>
        /// Percentage-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        /// <param name="ratio">Ratio of elapsed progress (expected 0.00 - 1.00)</param>
        public PercentageStepProgress(IStepBase step, decimal ratio)
        {
            this.Step = step;
            this.Current = ratio;
        }

        /// <summary>
        /// The step associated with this progress instance
        /// </summary>
        public IStepBase Step { get; private set; }

        /// <summary>
        /// Current ratio value (expected 0.00 - 1.00)
        /// </summary>
        public decimal Current { get; private set; }

        /// <summary>
        /// Total ratio value (1.00)
        /// </summary>
        public decimal Total { get; private set; } = 1.00M;

        /// <summary>
        /// Simple linear progress calculation
        /// </summary>
        public virtual decimal ProgressRatio => Current / Total;
    }
}
