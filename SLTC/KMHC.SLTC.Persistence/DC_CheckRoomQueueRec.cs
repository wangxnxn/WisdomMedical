//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_CheckRoomQueueRec
    {
        public DC_CheckRoomQueueRec()
        {
            this.DC_CheckRoomQueue = new HashSet<DC_CheckRoomQueue>();
        }
    
        public int CheckRoomQueueRecID { get; set; }
        public string SerialNumber { get; set; }
        public int ServiceOrderID { get; set; }
        public int ServiceOrderSIID { get; set; }
        public int ResidentID { get; set; }
        public System.DateTime SchDate { get; set; }
        public int PNCID { get; set; }
        public Nullable<int> DeptId { get; set; }
        public Nullable<int> CheckRoomID { get; set; }
        public int ServiceItemID { get; set; }
        public int CheckStatus { get; set; }
        public Nullable<System.DateTime> CheckBeginTime { get; set; }
        public Nullable<System.DateTime> CheckEndTime { get; set; }
        public Nullable<int> CheckEmployeeID { get; set; }
        public Nullable<System.DateTime> AdjustTime { get; set; }
        public string AdjustReason { get; set; }
        public Nullable<int> AdjustEmployeeID { get; set; }
        public string ServiceSchAdd { get; set; }
        public int OrganizationID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual DC_CheckRoom DC_CheckRoom { get; set; }
        public virtual ICollection<DC_CheckRoomQueue> DC_CheckRoomQueue { get; set; }
        public virtual DC_ServiceOrder DC_ServiceOrder { get; set; }
        public virtual DC_ServiceItem DC_ServiceItem { get; set; }
    }
}