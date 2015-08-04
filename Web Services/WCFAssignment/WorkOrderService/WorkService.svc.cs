using System;
using System.Collections.Generic;
using WO.DataEdmx;
using BE = WO.BusinessEntity;
using DE = WO.DataEdmx;
namespace WorkOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WorkService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WorkService.svc or WorkService.svc.cs at the Solution Explorer and start debugging.
    public class WorkService : IWorkService
    {
        //<summary>
        //method to add or update data according to the action given
        //1 to add a workorder
        //2 to update workorder
        //</summary>
        public bool SendWorkOrderData(IList<BE.WorkOrder> workOrders)
        {
            try
            {
                foreach (BE.WorkOrder works in workOrders)
                {
                    if (works.action == 1)
                    {
                        if (DE.WorkEntityClass.AddWorkOrder(works))
                            return true;
                        else
                            return false;
                    }
                   if(works.action==2)
                    {
                        if (DE.WorkEntityClass.UpdateWorkOrder(works))
                            return true;
                        else
                            return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
