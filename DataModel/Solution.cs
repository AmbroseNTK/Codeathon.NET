//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Codeathon.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solution()
        {
            this.SolutionReviews = new HashSet<SolutionReview>();
            this.Comments = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public string SourceCode { get; set; }
        public string ExecuteTime { get; set; }
        public System.DateTime Datetime { get; set; }
    
        public virtual Challenge Challenge { get; set; }
        public virtual PLanguage PLanguage { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolutionReview> SolutionReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
