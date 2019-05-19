//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTUTOR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.comments = new HashSet<comment>();
            this.history_lessons = new HashSet<history_lessons>();
            this.sessions = new HashSet<session>();
        }
    
        public int student_id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int status { get; set; }
        public Nullable<int> parent_id { get; set; }
        public string email { get; set; }
        public int @class { get; set; }
        public string avatar { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public Nullable<System.DateTime> dateCreate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<history_lessons> history_lessons { get; set; }
        public virtual parent parent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<session> sessions { get; set; }
        public virtual status status1 { get; set; }
    }
}