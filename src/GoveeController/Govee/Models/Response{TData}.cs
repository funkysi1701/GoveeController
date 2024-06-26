﻿namespace GoveeController.Govee.Models
{
    /// <summary>
    /// Provides a base response for a request to the Govee API.
    /// </summary>
    /// <typeparam name="TData">The type of the data.</typeparam>
    public class Response<TData> : Response
        where TData : new()
    {
        /// <summary>
        /// Gets or sets the data contained within the response.
        /// </summary>
        public TData Data { get; set; } = new();
    }
}