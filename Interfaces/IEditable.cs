using System;

namespace Bowyer.EntityFrameworkCore.Interfaces
{
    public interface IEditable
    {
        DateTime EditedDate { get; set; }

        int? EditedByUserId { get; set; }
    }
}