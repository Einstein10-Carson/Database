using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class ServiceTB
    {
        [Key]
        public  int ServiceID { get; set; }
public string ServiceName { get; set; }
public string BayArea { get; set; }
public int AvgServiceTimeSec { get; set; }
public DateTime CreateDate { get; set; }
public int CreateBy { get; set; }
public DateTime ModifiedDate { get; set; }
public int ModifiedBy { get; set; }
    }
}