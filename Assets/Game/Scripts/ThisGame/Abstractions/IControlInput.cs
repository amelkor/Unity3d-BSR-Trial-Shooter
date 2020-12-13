namespace ThisGame
{
    /// <summary>
    /// Controls incoming input to component.
    /// </summary>
    public interface IControlInput
    {
        /// <summary>
        /// Enable or disable any incoming input to the component.
        /// </summary>
        bool InputEnabled { get; set; }
    }
}