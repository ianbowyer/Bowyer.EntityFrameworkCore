using System;

namespace Bowyer.EntityFrameworkCore.Interfaces
{
    public interface ICreatable
    {
        DateTime CreatedDate { get; set; }

        int? CreatedByUserId { get; set; }
    }
}