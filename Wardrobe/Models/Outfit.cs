//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wardrobe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outfit
    {
        public int OutfitID { get; set; }
        public string OutfitName { get; set; }
        public int ItemID { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
