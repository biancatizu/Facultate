﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostComment
{
    using PostComment;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelPostCommentContainer : DbContext
    {
        public ModelPostCommentContainer()
            : base("name=ModelPostCommentContainer")
        {
            // Inhibare: lazy loading si creare proxy dinamic.
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        internal object Entry<T>(Posts posts)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public object Blog { get; internal set; }
    }
}
