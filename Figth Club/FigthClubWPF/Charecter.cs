//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FigthClubWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Charecter
    {
        public int Код_персонажа { get; set; }
        public int Код_пользователя { get; set; }
        public string Имя_персонажа { get; set; }
        public int Сила { get; set; }
        public int Выносливость { get; set; }
        public int Здоровье { get; set; }
        public string Особые_умения { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
