//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class tGuestBook
    {
        public int Id { get; set; }
        public string Leave_name { get; set; }
        public string Email { get; set; }
        public string Telphone { get; set; }
        public string Address { get; set; }
        public Nullable<int> QQ { get; set; }
        public string Title { get; set; }
        public string GuestContent { get; set; }
        public Nullable<System.DateTime> Leave_time { get; set; }
        public string Leave_ip { get; set; }
        public string ReplayContent { get; set; }
        public string Replay_ip { get; set; }
        public Nullable<System.DateTime> Replay_time { get; set; }
    }
}
