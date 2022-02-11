﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Superheroes.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class WorkModel
    {
        /// <summary>
        /// Initializes a new instance of the WorkModel class.
        /// </summary>
        public WorkModel() { }

        /// <summary>
        /// Initializes a new instance of the WorkModel class.
        /// </summary>
        public WorkModel(string occupation = default(string), string baseProperty = default(string))
        {
            Occupation = occupation;
            BaseProperty = baseProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "occupation")]
        public string Occupation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "base")]
        public string BaseProperty { get; set; }

    }
}