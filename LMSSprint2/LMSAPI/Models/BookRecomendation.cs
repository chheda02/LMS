//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookRecomendation
    {
        public int BookRecomendationId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublication { get; set; }
    }
}
