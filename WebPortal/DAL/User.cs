//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Comments = new HashSet<Comment>();
            this.NewsDetails = new HashSet<NewsDetail>();
            this.Reactions = new HashSet<Reaction>();
        }
    
        public int id { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<NewsDetail> NewsDetails { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
    }
}
