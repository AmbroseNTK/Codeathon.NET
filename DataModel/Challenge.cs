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
    
    public partial class Challenge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Challenge()
        {
            this.ChallengeResults = new HashSet<Solution>();
            this.CompetitionChallenges = new HashSet<CompetitionChallenge>();
            this.TestCases = new HashSet<TestCase>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public bool IsPublic { get; set; }
    
        public virtual User Owner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solution> ChallengeResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitionChallenge> CompetitionChallenges { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestCase> TestCases { get; set; }
    }
}
