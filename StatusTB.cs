using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class StatusTB
    {
        [Key]
 public int StatusID { get; set; }
public String StatusText { get; set; }
public string StatusGroup { get; set; }
public int StatusOrder { get; set; }
public DateTime CreateDate { get; set; }
public int CreateBy { get; set; }
public DateTime ModifiedDate { get; set; }
public int ModifiedBy { get; set; } 
    }
}