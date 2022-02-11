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

    public partial class SuperheroModel
    {
        /// <summary>
        /// Initializes a new instance of the SuperheroModel class.
        /// </summary>
        public SuperheroModel() { }

        /// <summary>
        /// Initializes a new instance of the SuperheroModel class.
        /// </summary>
        public SuperheroModel(int id, string name = default(string), string slug = default(string), PowerstatsModel powerstats = default(PowerstatsModel), AppearanceModel appearance = default(AppearanceModel), BiographyModel biography = default(BiographyModel), WorkModel work = default(WorkModel), ConnectionsModel connections = default(ConnectionsModel), ImagesModel images = default(ImagesModel))
        {
            Id = id;
            Name = name;
            Slug = slug;
            Powerstats = powerstats;
            Appearance = appearance;
            Biography = biography;
            Work = work;
            Connections = connections;
            Images = images;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "powerstats")]
        public PowerstatsModel Powerstats { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appearance")]
        public AppearanceModel Appearance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "biography")]
        public BiographyModel Biography { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "work")]
        public WorkModel Work { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connections")]
        public ConnectionsModel Connections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public ImagesModel Images { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Powerstats != null)
            {
                this.Powerstats.Validate();
            }
        }
    }
}