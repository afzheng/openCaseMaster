//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace openCaseMaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_testCaseSteps
    {
        public int ID { get; set; }
        public Nullable<int> type { get; set; }
        public string stepXML { get; set; }
        public string name { get; set; }
        public Nullable<int> userID { get; set; }
        public string mark { get; set; }
        public string paramXML { get; set; }
        public Nullable<int> PID { get; set; }
        public Nullable<int> FID { get; set; }
    
        public virtual project project { get; set; }
        public virtual caseFramework caseFramework { get; set; }
    }
}
