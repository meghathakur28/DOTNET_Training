using System;
using System.Collections.Generic;
using System.Text;

namespace End_To_End_25
{
    public  class Payment
    {
         public int PaymentId {  get; set; }
         public int PaymentMode { get; set; }

         public double PaymentAmount {  get; set; }

         public bool IsCoupon {  get; set; }
    }
}
