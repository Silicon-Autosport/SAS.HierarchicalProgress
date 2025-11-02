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
            this.ProgressRatio = 0.00M;
        }

        /// <summary>
        /// Percentage-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        /// <param name="ratio">Ratio of elapsed progress (expected 0.00 - 1.00)</param>
        public PercentageStepProgress(IStepBase step, decimal ratio)
        {
            this.Step = step;
            this.ProgressRatio = ratio;
        }

        /// <summary>
        /// The step associated with this progress instance
        /// </summary>
        public IStepBase Step { get; private set; }

        /// <summary>
        /// Simple linear progress calculation
        /// </summary>
        public decimal ProgressRatio { get; private set; }

        /// <summary>
        /// Human readable representation
        /// </summary>
        /// <returns>PR% (ex: 67%)</returns>
        public override string ToString()
        {
            return $"{(ProgressRatio * 100.00M).ToString("F2")}%";
        }
    }
}
