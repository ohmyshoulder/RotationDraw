//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class gamepackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gamepackage()
        {
            this.packagecard = new HashSet<packagecard>();
        }
    
        public int gamepackageid { get; set; }
        public int gamepackageset { get; set; }
        public int gameid { get; set; }
        public int startuserid { get; set; }
        public int rank { get; set; }
        public Nullable<bool> isNow { get; set; }
    
        public virtual game game { get; set; }
        public virtual users users { get; set; }
        public virtual sets sets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packagecard> packagecard { get; set; }
    }
}
