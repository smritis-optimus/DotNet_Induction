using BE = WO.BusinessEntity;

namespace WO.DataEdmx
{
    //<summary>
    //partial class WorkOrder explicitly converted to Entity type class
    //</summary>
    public partial class WorkOrder
    {
        public static explicit operator WorkOrder(BE.WorkOrder workOrder)
        {
            return new WorkOrder
            {
                WONumber = workOrder.WONumber,
                WOShortText = workOrder.WOShortText,
                WOLongText = workOrder.WOLongText
            };
        }
    }
    //<summary>
    //partial class Operation explicitly converted to Entity type class
    //</summary>
    public partial class Operation
    {
        public static explicit operator Operation(BE.Operation operation)
        {
            return new Operation
            {
                OpID = operation.OpID,
                OpDesc = operation.OpDesc,
               OpStatus = operation.OpStatus
            };
        }
    }
}
