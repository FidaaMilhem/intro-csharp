﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorWeb.Server.Model
{
    public partial class Playlist
    {
        public Playlist()
        {
            Track = new HashSet<Track>();
        }

        public int PlaylistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Track> Track { get; set; }
    }
}