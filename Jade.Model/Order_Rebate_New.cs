//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jade.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Rebate_New
    {
        public int id { get; set; }
        public string order_id { get; set; }
        public int reciver_id { get; set; }
        public int reciver_rebate { get; set; }
        public int reciver_level { get; set; }
        public int giver_id { get; set; }
        public int giver_level { get; set; }
        public string reason { get; set; }
        public int status { get; set; }
        public int rebate_type { get; set; }
        public System.DateTime rebate_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
    
        public virtual Member Giver { get; set; }
        public virtual Member Reciver { get; set; }
        public virtual Product_Order_Master Product_Order_Master { get; set; }
    }
}
