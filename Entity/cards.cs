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
    
    public partial class cards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cards()
        {
            this.packagecard = new HashSet<packagecard>();
        }
    
        public int CardID { get; set; }
        public string manacost { get; set; }
        public string name { get; set; }
        public string pt { get; set; }
        public int set { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string Level { get; set; }
        public int SingoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packagecard> packagecard { get; set; }
        public virtual sets sets { get; set; }
    }
}
