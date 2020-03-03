using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class RoomTB
    {
        [Key]
       public int RoomNo { get; set; }
public string BayArea { get; set; }
public int ServiceID { get; set; }
public bool IsActive { get; set; }
public DateTime CreateDate { get; set; }
public int CreatedBy { get; set; }
public DateTime ModifiedDate { get; set; }
public int ModifiedBy { get; set; } 
    }
    
}