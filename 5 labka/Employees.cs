//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _5_labka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public int OrderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
    
        public virtual Roles Roles { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
