namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Login Interface
    /// </summary>
    public interface ILogin
    {
        /// <summary>
        /// Gets or sets LoginNo
        /// </summary>
        int LoginNo { get; set; }

        /// <summary>
        /// Gets or Sets LoginUserName
        /// </summary>
        string LoginUserName { get; set; }

        /// <summary>
        /// Gets or sets LoginPassword
        /// </summary>
        string LoginPassword { get; set; }

    }
}
