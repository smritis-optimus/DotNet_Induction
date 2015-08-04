using System;
using System.Linq;
using BE=WO.BusinessEntity;
namespace WO.DataEdmx
{
    public class WorkEntityClass
    {
        public static bool AddWorkOrder(BE.WorkOrder workOrder)
        {
            WorkOrder work;
            work = (WorkOrder)workOrder;//explicit conversion to Entity class type
            Operation operation;
            try
            {
                //adding rows to the table WorkOrder
                using (WorkDataEntities db = new WorkDataEntities())
                {
                    db.WorkOrders.Add(work);
                    db.SaveChanges();
                }
                //adding rows to table Operation
                foreach (BE.Operation operations in workOrder.Operations)
                {
                    operation = (Operation)operations;
                    if (operations.OpStatus == "Open")//if status is open set null to OnCompleteeDate
                       operation.OpCompletionDate = null;
                    else
                      operation.OpCompletionDate = Convert.ToDateTime(operations.OpCompletionDate);
                    operation.WONumber = workOrder.WONumber;
                    using (WorkDataEntities db = new WorkDataEntities())
                    {
                        db.Operations.Add(operation);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool UpdateWorkOrder(BE.WorkOrder workOrder)
        {
            try
            {
                using (WorkDataEntities updateWork = new WorkDataEntities())
                {
                    int i = Convert.ToInt32(workOrder.WONumber);
                    //query for updating WorkOrder
                    var queryWorkOrder = (from WorkOrder in updateWork.WorkOrders
                                          where WorkOrder.WONumber == i
                                          select WorkOrder).FirstOrDefault();
                    //update only if any value is set
                    //primary key cannot be null so not checking for it
                    queryWorkOrder.WONumber = workOrder.WONumber;
                    if (workOrder.WOShortText != null)
                        queryWorkOrder.WOShortText = workOrder.WOShortText;
                    if (workOrder.WOLongText != null)
                        queryWorkOrder.WOLongText = workOrder.WOLongText;
                    //query for updating Operations
                    foreach (BE.Operation operations in workOrder.Operations)
                    {
                        i = operations.OpID;
                        var queryOperation = (from Operation in updateWork.Operations
                                              where Operation.OpID == i
                                              select Operation).FirstOrDefault();
                        //update only if any value is set
                        //primary key cannot be null so not checking for it
                        queryOperation.OpID = operations.OpID;
                        if (operations.OpDesc != null)
                            queryOperation.OpDesc = operations.OpDesc;
                        if (operations.OpStatus != null)
                            queryOperation.OpStatus = operations.OpStatus;
                        if (operations.OpCompletionDate != null)
                            queryOperation.OpCompletionDate = Convert.ToDateTime(operations.OpCompletionDate);
                    }
                    updateWork.SaveChanges();
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
