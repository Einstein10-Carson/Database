using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class ServiceTokenTB
    {
        [Key]
public int ServiceTokenID { get; set; }
public int ServiceID { get; set; }
public DateTime ServiceDate { get; set; }
public int Patient { get; set; }
public DateTime ServiceTokenDate { get; set; }
public int ServiceTokenQueueNo { get; set; }
public int CurrentStatusID { get; set; }
public DateTime CreateDate { get; set; }
public int CreateBy { get; set; }
    }
    
}