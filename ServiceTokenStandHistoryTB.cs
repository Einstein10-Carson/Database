using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class ServiceTokenStandHistoryTB
    {
        [Key]
public int ServiceTokenHistoryID { get; set; }
public int ServiceTokenID { get; set; }
public int ServiceRoomID { get; set; }
public int StatusID { get; set; }
public int TimeSpentSec { get; set; }
public DateTime CreateDate { get; set; }
public int CreateBy{ get; set; }
    }
}