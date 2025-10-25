using SAS.HierarchicalProgress.Models;

namespace SAS.HierarchicalProgress.StepProgress
{
    /// <summary>
    /// Quantity-based progress reporting
    /// </summary>
    public class QuantityStepProgress : IStepProgressDeterminate
    {
        /// <summary>
        /// Quantity-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        /// <param name="current">Current quantity</param>
        /// <param name="total">Total expected quantity</param>
        public QuantityStepProgress(IStepBase step, int current, int total)
        {
            this.Step = step;
            this.Current = (decimal)current;
            this.Total = (decimal)total;
        }

        /// <summary>
        /// Quantity-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        /// <param name="current">Current quantity</param>
        /// <param name="total">Total expected quantity</param>
        public QuantityStepProgress(IStepBase step, uint current, uint total)
        {
            this.Step = step;
            this.Current = (decimal)current;
            this.Total = (decimal)total;
        }

        /// <summary>
        /// Quantity-based progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        /// <param name="current">Current quantity</param>
        /// <param name="total">Total expected quantity</param>
        public QuantityStepProgress(IStepBase step, decimal current, decimal total)
        {
            this.Step = step;
            this.Current = current;
            this.Total = total;
        }

        /// <summary>
        /// The step associated with this progress instance
        /// </summary>
        public IStepBase Step { get; private set; }

        /// <summary>
        /// Current quantity value
        /// </summary>
        public decimal Current { get; private set; }

        /// <summary>
        /// Total/final expected quantity value
        /// </summary>
        public decimal Total { get; private set; }

        /// <summary>
        /// Simple linear progress calculation
        /// </summary>
        public virtual decimal ProgressRatio => Current / Total;
    }
}
