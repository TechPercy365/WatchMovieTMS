//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchMovieTMS.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movies
    {
        public int Id_Movie { get; set; }
        public string movieName { get; set; }
        public string movieGenre { get; set; }
        public string movieDescription { get; set; }
        public Nullable<System.DateTime> movieDate { get; set; }
        public Nullable<System.TimeSpan> movieTime { get; set; }
        public Nullable<decimal> movieCost { get; set; }
    }
}