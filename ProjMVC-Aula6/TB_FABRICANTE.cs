//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjMVC_Aula5
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_FABRICANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_FABRICANTE()
        {
            this.TB_PRODUTO = new HashSet<TB_PRODUTO>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO { get; set; }
    }
}