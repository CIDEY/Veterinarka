//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinarka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int Id { get; set; }
        public Nullable<int> IdOwner { get; set; }
        public Nullable<int> IdAnimal { get; set; }
        public Nullable<int> IdDoctor { get; set; }
        public Nullable<int> IdVaccination { get; set; }
    
        public virtual Animal Animal { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Vaccination Vaccination { get; set; }
    }
}
